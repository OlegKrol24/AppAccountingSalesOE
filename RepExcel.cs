using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AppAccountingSalesOE
{
    public class RepExcel : IDisposable
    {
        public Excel.Application excelapp;
        Excel.Workbooks excelappworkbooks;
        Excel.Workbook excelappworkbook;
        private Excel.Sheets excelsheets;
        private Excel.Worksheet excelworksheet;
        private Excel.Range excelcells;

        private static readonly LoggerService loggerService = new LoggerService();

        public RepExcel()
        {
            try
            {
                excelapp = new Excel.Application();
                excelapp.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося запустити Excel. Переконайтесь, що встановлений Microsoft Excel та бібліотеки Interop.\n\n" + ex.Message);
                throw;
            }
        }

        public void Dispose()
        {
            if (excelapp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelapp);
            if (excelappworkbooks != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelappworkbooks);
            if (excelappworkbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelappworkbook);
            if (excelsheets != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelsheets);
            if (excelworksheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelworksheet);
            if (excelcells != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelcells);

            excelapp = null;
            excelappworkbooks = null;
            excelappworkbook = null;
            excelsheets = null;
            excelworksheet = null;
            excelcells = null;
            GC.Collect();
            loggerService.Info("RepExcel Dispose OK");
            GC.GetTotalMemory(true);
        }

        // Створюємо нову книгу
        public void CreateNewBook(string fullPathAndFilename)
        {
            try
            {
                excelapp.SheetsInNewWorkbook = 2;
                excelapp.Workbooks.Add(Type.Missing);
                excelapp.DisplayAlerts = false;
                excelappworkbooks = excelapp.Workbooks;
                excelappworkbook = excelappworkbooks[1];
                excelsheets = excelappworkbook.Worksheets;
                excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
                excelworksheet.UsedRange.Columns.AutoFit();
                excelworksheet.Name = "Saturn Data";
                excelappworkbook.Saved = true;

                excelappworkbook.SaveAs(fullPathAndFilename,
                                        Excel.XlFileFormat.xlOpenXMLWorkbook,
                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                        Excel.XlSaveAsAccessMode.xlNoChange,
                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                
                excelapp.Workbooks.Close();
                excelapp.Quit();
                loggerService.Info("CreateNewBook " + fullPathAndFilename + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "CreateNewBook " + fullPathAndFilename);

                if (excelapp != null) excelapp.Quit();

                Dispose();
            }
        }

        public void OpenBook(string fullPathAndFilename)
        {
            try
            {
                excelapp.Workbooks.Open(fullPathAndFilename,
                                        Type.Missing, false, Type.Missing, Type.Missing,
                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing, Type.Missing);

                excelappworkbooks = excelapp.Workbooks;
                excelappworkbook = excelappworkbooks[1];
                loggerService.Info("OpenBook " + fullPathAndFilename + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "OpenBook");
            }
        }

        public void CloseBook()
        {
            try
            {
                if (excelappworkbooks != null) excelapp.Workbooks.Close();
                if (excelapp != null) excelapp.Quit();

                loggerService.Info("CloseBook OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "CloseBook");
            }
        }

        public void Save(string fullPathAndFilename)
        {
            try
            {
                if (excelappworkbook == null)
                {
                    excelappworkbooks = excelapp.Workbooks;
                    excelappworkbook = excelappworkbooks[1];
                }

                excelappworkbook.Saved = false;

                if (string.IsNullOrEmpty(excelappworkbook.Path)) SaveAs(fullPathAndFilename);

                else excelappworkbook.Save();

                loggerService.Info("Save " + fullPathAndFilename + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "Save");
                MessageBox.Show("Виникла проблема при збереженні файлу. " + ex.Message); // Розкоментуй для GUI
            }
        }

        public void SaveAs(string fullPathAndFilename)
        {
            try
            {
                if (excelappworkbook == null)
                {
                    excelappworkbooks = excelapp.Workbooks;
                    excelappworkbook = excelappworkbooks[1];
                }

                excelappworkbook.Saved = true;

                excelappworkbook.SaveAs(fullPathAndFilename,
                                        Excel.XlFileFormat.xlOpenXMLWorkbook,
                                        Type.Missing, Type.Missing, false, Type.Missing,
                                        Excel.XlSaveAsAccessMode.xlNoChange,
                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                loggerService.Info("SaveAs " + fullPathAndFilename + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "SaveAs " + fullPathAndFilename);
            }
        }

        public void SetValue(string pageName, string address, string strValues, string typeValue, bool isBold = false)
        {
            try
            {
                if (excelappworkbook == null)
                {
                    excelappworkbooks = excelapp.Workbooks;
                    excelappworkbook = excelappworkbooks[1];
                }

                excelsheets = excelappworkbook.Worksheets;

                try
                {
                    excelworksheet = (Excel.Worksheet)excelsheets[pageName];
                }
                catch
                {
                    excelsheets.Add();
                    excelworksheet = (Excel.Worksheet)excelsheets.get_Item(excelsheets.Count);
                    excelworksheet.Name = pageName;
                }

                excelcells = excelworksheet.get_Range(address, address);

                if (typeValue == "double") excelcells.Value2 = Convert.ToDouble(strValues, CultureInfo.GetCultureInfo("en-US").NumberFormat);
                else if (typeValue == "string") excelcells.Value2 = strValues;
                else throw new ArgumentException("Unsupported typeValue: " + typeValue);
                
                if (isBold) excelcells.EntireRow.Font.Bold = true;
                
                loggerService.Info("SetValue page - " + pageName + " address - " + address + " Value - " + strValues + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "SetValue page - " + pageName + " address - " + address + " Value - " + strValues);
            }
        }

        public string GetValue(string pageName, string address)
        {
            try
            {
                if (excelappworkbook == null)
                {
                    excelappworkbooks = excelapp.Workbooks;
                    excelappworkbook = excelappworkbooks[1];
                }

                excelsheets = excelappworkbook.Worksheets;
                excelworksheet = (Excel.Worksheet)excelsheets[pageName];
                excelcells = excelworksheet.get_Range(address, address);

                return Convert.ToString(excelcells.Value2);
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "GetValue page - " + pageName + " address - " + address);
                return string.Empty;
            }
        }

        public void HiddenRow(string pageName, int indexRow)
        {
            try
            {
                if (excelappworkbook == null)
                {
                    excelappworkbooks = excelapp.Workbooks;
                    excelappworkbook = excelappworkbooks[1];
                }

                excelsheets = excelappworkbook.Worksheets;
                excelworksheet = (Excel.Worksheet)excelsheets[pageName];
                excelworksheet.Range["A" + indexRow, "A" + indexRow].Rows.Hidden = true;
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "HiddenRow page - " + pageName + " row - " + indexRow);
            }
        }

        public void DisplayRow(string pageName, int indexRow)
        {
            try
            {
                if (excelappworkbook == null)
                {
                    excelappworkbooks = excelapp.Workbooks;
                    excelappworkbook = excelappworkbooks[1];
                }

                excelsheets = excelappworkbook.Worksheets;
                excelworksheet = (Excel.Worksheet)excelsheets[pageName];
                excelworksheet.Range["A" + indexRow, "A" + indexRow].Rows.Hidden = false;
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "DisplayRow page - " + pageName + " row - " + indexRow);
            }
        }

        public void AutoFitColumns(string pageName)
        {
            try
            {
                if (excelappworkbook == null)
                {
                    excelappworkbooks = excelapp.Workbooks;
                    excelappworkbook = excelappworkbooks[1];
                }

                excelsheets = excelappworkbook.Worksheets;
                excelworksheet = (Excel.Worksheet)excelsheets[pageName];
                excelworksheet.UsedRange.Columns.AutoFit();
                loggerService.Info("AutoFitColumns on page " + pageName + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "AutoFitColumns on page " + pageName);
            }
        }
    }
}