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

        public static void SerializeToXml<T>(ref T inObject, string fileName)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(T));

                StreamWriter file = new StreamWriter(fileName);
                writer.Serialize(file, inObject);
                file.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error XML serialize");
            }
        }

        public static void DeserializeFromXml<T>(ref T inObject, string inFileName)
        {
            try
            {
                if (File.Exists(inFileName))
                {
                    XmlSerializer reader = new XmlSerializer(typeof(T));

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

        public static void SerializeToJson<T>(ref T inObject, string fileName)
        {
            try
            {
                FileStream stream1 = new FileStream(fileName, FileMode.OpenOrCreate);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

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

        public static void DeserializeFromJson<T>(ref T inObject, string inFileName)
        {
            try
            {
                if (File.Exists(inFileName))
                {
                    FileStream stream1 = new FileStream(inFileName, FileMode.OpenOrCreate);
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

                    inObject = (T)ser.ReadObject(stream1);
                    stream1.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error JSON deserialize");
            }
        }

        public static void SerializeToBin<T>(ref T inObject, string fileName)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

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

        public static void DeserializeFromBin<T>(ref T inObject, string inFileName)
        {
            try
            {
                if (File.Exists(inFileName))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

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