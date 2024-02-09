using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;
using System.Security.Cryptography;


namespace SerialDeserialFile
{
    public class SerialDeserial
    {
        public void Serialize(string path, Object obj)
        {
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }


            string objectTypeName = obj.GetType().Name;
            string fileName = $"{objectTypeName}.xml";
            string filePath = Path.Combine(path, fileName);

            XmlSerializer serializer = new XmlSerializer(obj.GetType());

            using (StreamWriter writer = new StreamWriter(filePath,true))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public List<T> Deserialize<T>(string path)
        {
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }


            string objectTypeName = typeof(T).Name;
            string fileName = $"{objectTypeName}.xml";
            string filePath = Path.Combine(path, fileName);

            if (!File.Exists(filePath))
        {
                throw new FileNotFoundException("File not found.", filePath);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StreamReader reader = new StreamReader(filePath))
            {
                return (List<T>)serializer.Deserialize(reader);
            }
        }
    }
}
