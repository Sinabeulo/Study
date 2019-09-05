using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Winform.Manager
{
    /// <summary>
    /// 2019.09.05
    /// </summary>
    public static class FileManager
    {
        public static void SaveFileToTxt(this IEnumerable<string> fileTxtData, string fullPath)
        {
            //Directory.Exists(fullPath);

            using (FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                using(StreamWriter writer = new StreamWriter(fs))
                {
                    foreach(var item in fileTxtData)
                    {
                        writer.WriteLine(item);
                    }
                }
            }

        }


        public static IList<string> ReadFileToList(string fullPath)
        {
            IList<string> resultList = new List<string>();
            using (FileStream fs = new FileStream(fullPath, FileMode.Open))
            {
                using(StreamReader reader = new StreamReader(fs))
                {
                    while(reader.EndOfStream == false)
                    {
                        resultList.Add(reader.ReadLine());
                    }
                }
            }

            return resultList;
        }


        public static void SaveFileToXML(this IEnumerable<XMLElementModel> fileSource, string fullPath)
        {
            XmlDocument doc = new XmlDocument();
            List<Tuple<XmlElement, string>> xmlDataList = new List<Tuple<XmlElement, string>>();

            foreach (var src in fileSource)
            {
                switch (src.ElementType)
                {
                    case XMLElementModel.XMLType.Attribute:
                        //XmlElement element = doc.CreateElement(src.Header);
                        //element.SetAttribute(src.AttributeHeader, src.Attribute);

                        break;
                    case XMLElementModel.XMLType.Element:
                        //XmlElement element = doc.CreateElement(src.Header);
                        break;
                }
            }


            doc.Save("temp.xml");
        }

    }

    public class XMLElementModel
    {
        public string Header { get; set; }
        public string Data { get; set; }
        
        public string AttributeHeader { get; set; }
        public string Attribute { get; set; }

        public XMLType ElementType { get; set; }

        public enum XMLType
        {
            Attribute,
            Element
        }
    }
}
