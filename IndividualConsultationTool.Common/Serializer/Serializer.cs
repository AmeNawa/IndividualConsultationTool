using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
using IndividualConsultationTool.Common.Secure;
using Ninject;

namespace IndividualConsultationTool.Common.Serializer
{
    public static class Serializer
    {
        /// <summary>
        /// Serialize any object to xml File
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="path"></param>
        /// <param name="fileName">File name without extension like .xml</param>
        /// <param name="encrypt">Set true if you want to encrypt your out file</param>
        public static void ObjectToXmlFile<T>(T obj, string path, string fileName, bool encrypt)
        {
            var kernel = Infrastructure.Factory.GetInstance();
            var AES = kernel.Get<ICrypt>();

            var folderPath = Path.Combine(Environment.CurrentDirectory, path);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var fullPath = Path.Combine(folderPath, fileName) + ".xml";
            if (!File.Exists((fullPath)))
            {
                File.Create(fullPath);
            }

            var content = encrypt ? AES.Encrypt(ObjectToXmlString(obj)) : ObjectToXmlString((obj));

            File.WriteAllText(fullPath, content, Encoding.UTF8);
        }



        /// <summary>
        /// Serialize xml file to any object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <param name="name"></param>
        /// <param name="decrypt">Set true if file has been encrypted</param>
        /// <returns></returns>
        public static T XmlFileToObject<T>(string filePath, string name, bool decrypt)
        {
            try
            {
                var kernel = Infrastructure.Factory.GetInstance();
                var AES = kernel.Get<ICrypt>();
                var folderPath = Path.Combine(filePath, name);
                var xmlString = XmlFileToString(filePath, name, decrypt);

                return XmlStringToObject<T>(AES.Decrypt(xmlString));
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }


        /// <summary>
        /// Serialize xml file to string
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName">Without extension like .xml</param>
        /// <param name="decrypt">Set true if file has been encrypted</param>
        /// <returns></returns>
        public static string XmlFileToString(string path, string fileName, bool decrypt)
        {
            try
            {
                var kernel = Infrastructure.Factory.GetInstance();
                var AES = kernel.Get<ICrypt>();
                var fullPath = Path.Combine(path, fileName) + ".xml";
                var result = File.ReadAllText(fullPath, Encoding.UTF8);

                return decrypt ? AES.Decrypt(result) : result;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }


        /// <summary>
        /// Serialize object to string with xml's standards
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static string ObjectToXmlString<T>(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            var stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, obj);

            return stringWriter.ToString();
        }


        /// <summary>
        /// Create object of type T from string if xml's standards are valid
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        private static T XmlStringToObject<T>(string xmlString)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                var reader = new StringReader(xmlString);
                var result = serializer.Deserialize(reader);

                return (T)result;
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}