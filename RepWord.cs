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
using Word = Microsoft.Office.Interop.Word;

namespace AppAccountingSalesOE
{
    public class RepWord : IDisposable
    {
        public Word.Application wordapp;
        Word.Documents wordappdocuments;
        Word.Document wordappdocument;
        private Word.Range wordrange; // Діапазон для вставки тексту
        private static readonly LoggerService loggerService = new LoggerService();

        public RepWord()
        {
            try
            {
                wordapp = new Word.Application();
                wordapp.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося запустити Word. Переконайтесь, що встановлений Microsoft Word та бібліотеки Interop\n\n" + ex.Message);
                throw;
            }
        }

        public void Dispose()
        {
            // Release COM objects
            if (wordapp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(wordapp);
            if (wordappdocuments != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(wordappdocuments);
            if (wordappdocument != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(wordappdocument);
            if (wordrange != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(wordrange);

            wordapp = null;
            wordappdocuments = null;
            wordappdocument = null;
            wordrange = null;

            GC.Collect();
            loggerService.Info("RepWord Dispose OK");
            GC.GetTotalMemory(true);
        }

        // Створюємо новий документ
        public void CreateNewDocument(string fullPathAndFilename)
        {
            try
            {
                wordappdocuments = wordapp.Documents;
                wordappdocument = wordappdocuments.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                wordapp.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone;
                wordappdocument.Saved = true;
                wordappdocument.SaveAs2(fullPathAndFilename,
                                        Word.WdSaveFormat.wdFormatDocumentDefault, // .docx формат
                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing, Type.Missing);

                loggerService.Info("CreateNewDocument " + fullPathAndFilename + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "CreateNewDocument " + fullPathAndFilename);

                if (wordapp != null) wordapp.Quit();

                Dispose();
            }
        }

        public void OpenDocument(string fullPathAndFilename)
        {
            try
            {
                wordappdocuments = wordapp.Documents;
                wordappdocument = wordappdocuments.Open(fullPathAndFilename,
                                                        Type.Missing, false, Type.Missing, Type.Missing,
                                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                        Type.Missing, Type.Missing, Type.Missing);

                loggerService.Info("OpenDocument " + fullPathAndFilename + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "OpenDocument");
            }
        }

        public void CloseDocument()
        {
            try
            {
                if (wordappdocument != null) wordappdocument.Close();
                if (wordapp != null) wordapp.Quit();

                loggerService.Info("CloseDocument OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "CloseDocument");
            }
        }

        public void Save(string fullPathAndFilename)
        {
            try
            {
                if (wordappdocument == null)
                {
                    wordappdocuments = wordapp.Documents;
                    wordappdocument = wordappdocuments[1];
                }

                wordappdocument.Saved = false;

                if (string.IsNullOrEmpty(wordappdocument.Path)) SaveAs(fullPathAndFilename);

                else wordappdocument.Save();

                loggerService.Info("Save " + fullPathAndFilename + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "Save");

                MessageBox.Show("Виникла проблема при збереженні файлу: " + ex.Message);
            }
        }

        public void SaveAs(string fullPathAndFilename)
        {
            try
            {
                if (wordappdocument == null)
                {
                    wordappdocuments = wordapp.Documents;
                    wordappdocument = wordappdocuments[1];
                }

                wordappdocument.Saved = true;

                wordappdocument.SaveAs2(fullPathAndFilename,
                                        Word.WdSaveFormat.wdFormatDocumentDefault,
                                        Type.Missing, Type.Missing, false, Type.Missing,
                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing, Type.Missing);

                loggerService.Info("SaveAs " + fullPathAndFilename + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "SaveAs " + fullPathAndFilename);
            }
        }

        // Вставка тексту в кінець документа
        public void InsertText(string text, bool isBold = false, string alignment = "left")
        {
            try
            {
                if (wordappdocument == null)
                {
                    wordappdocuments = wordapp.Documents;
                    wordappdocument = wordappdocuments[1];
                }
                wordrange = wordappdocument.Range(wordappdocument.Content.End - 1, wordappdocument.Content.End - 1);
                wordrange.Text = text + "\n";

                if (isBold) wordrange.Font.Bold = 1;

                // Встановлення вирівнювання
                switch (alignment.ToLower())
                {
                    case "left":
                        wordrange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        break;

                    case "center":
                        wordrange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        break;

                    case "right":
                        wordrange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                        break;

                    default:
                        throw new ArgumentException("Невалідне вирівнювання: " + alignment + ". Допустимі значення: left, center, right.");
                }

                loggerService.Info("InsertText: " + text + " з вирівнюванням " + alignment + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "InsertText: " + text + " з вирівнюванням " + alignment);
            }
        }

        // Вставка таблиці
        public void InsertTable(List<List<string>> data)
        {
            try
            {
                if (wordappdocument == null)
                {
                    wordappdocuments = wordapp.Documents;
                    wordappdocument = wordappdocuments[1];
                }

                wordrange = wordappdocument.Range(wordappdocument.Content.End - 1, wordappdocument.Content.End - 1);
                
                int rows = data.Count;
                int cols = data[0].Count; // Припускаємо, що всі рядки однакові

                Word.Table table = wordappdocument.Tables.Add(wordrange, rows, cols);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++) table.Cell(i + 1, j + 1).Range.Text = data[i][j];
                }

                table.Borders.Enable = 1; // Увімкнути рамки

                loggerService.Info("InsertTable OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "InsertTable");
            }
        }

        // Експорт документа в PDF
        public void ExportToPdf(string pdfPath)
        {
            try
            {
                if (wordappdocument == null)
                {
                    wordappdocuments = wordapp.Documents;
                    wordappdocument = wordappdocuments[1];
                }

                wordappdocument.ExportAsFixedFormat(
                    pdfPath,
                    Word.WdExportFormat.wdExportFormatPDF,
                    OpenAfterExport: false,
                    OptimizeFor: Word.WdExportOptimizeFor.wdExportOptimizeForPrint,
                    Item: Word.WdExportItem.wdExportDocumentContent,
                    IncludeDocProps: true,
                    KeepIRM: true,
                    CreateBookmarks: Word.WdExportCreateBookmarks.wdExportCreateNoBookmarks,
                    DocStructureTags: true,
                    BitmapMissingFonts: true,
                    UseISO19005_1: false
                );

                loggerService.Info("ExportToPdf " + pdfPath + " OK");
            }
            catch (Exception ex)
            {
                loggerService.Error(ex, "ExportToPdf " + pdfPath);
                MessageBox.Show("Виникла проблема при експорті в PDF. " + ex.Message);
            }
        }
    }
}