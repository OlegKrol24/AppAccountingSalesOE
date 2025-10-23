using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.IO;
using NLog;
using System.Runtime.Serialization.Formatters.Binary;

namespace AppAccountingSalesOE
{
    public class ClassSerialize
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        // Серіалізація у формат XML
        public static void SerializeToXml<T>(ref T inObject, string fileName)
        {
            try
            {
                // Створюємо об'єкт для серіалізації у формат XML
                XmlSerializer writer = new XmlSerializer(typeof(T));

                // Записуємо XML до файлу
                StreamWriter file = new StreamWriter(fileName);
                writer.Serialize(file, inObject);
                file.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error XML serialize");
            }
        }

        // Десеріалізація з XML
        public static void DeserializeFromXml<T>(ref T inObject, string inFileName)
        {
            try
            {
                // Спочатку перевіряємо чи існує файл
                if (File.Exists(inFileName))
                {
                    // Створюємо об'єкт для десеріалізації формату XML
                    XmlSerializer reader = new XmlSerializer(typeof(T));

                    // Зчитуємо XML з файлу
                    StreamReader file = new StreamReader(inFileName);
                    inObject = (T)reader.Deserialize(file);
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error XML deserialize");
            }
        }

        // Серіалізація у формат JSON
        public static void SerializeToJson<T>(ref T inObject, string fileName)
        {
            try
            {
                // Створюємо серіалізатор JSON
                FileStream stream1 = new FileStream(fileName, FileMode.OpenOrCreate);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

                // Записуємо JSON до файлу
                ser.WriteObject(stream1, inObject);
                stream1.Position = 0;
                StreamReader sr = new StreamReader(stream1);
                stream1.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error JSON serialize");
            }
        }

        // Десеріалізація з JSON
        public static void DeserializeFromJson<T>(ref T inObject, string inFileName)
        {
            try
            {
                // Спочатку перевіряємо чи існує файл
                if (File.Exists(inFileName))
                {
                    // Створюємо об'єкт для десеріалізації формату JSON
                    FileStream stream1 = new FileStream(inFileName, FileMode.OpenOrCreate);
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

                    // Зчитуємо JSON з файлу
                    inObject = (T)ser.ReadObject(stream1);
                    stream1.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error JSON deserialize");
            }
        }

        // Серіалізація у формат BIN
        public static void SerializeToBin<T>(ref T inObject, string fileName)
        {
            try
            {
                // Створюємо серіалізатор BIN
                BinaryFormatter formatter = new BinaryFormatter();

                // Записуємо BIN до файлу
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    formatter.Serialize(fs, inObject);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error BIN serialize");
            }
        }

        // Десеріалізація з BIN
        public static void DeserializeFromBin<T>(ref T inObject, string inFileName)
        {
            try
            {
                // Спочатку перевіряємо чи існує файл
                if (File.Exists(inFileName))
                {
                    // Створюємо об'єкт для десеріалізації формату BIN
                    BinaryFormatter formatter = new BinaryFormatter();

                    // Зчитуємо BIN з файлу
                    using (FileStream fs = new FileStream(inFileName, FileMode.Open))
                    {
                        inObject = (T)formatter.Deserialize(fs);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error BIN deserialize");
            }
        }
    }
}