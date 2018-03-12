using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ConsoleApplication2
{
    public static class Descendants
    {
        public static void GetAllNodes(string xml, string root)
        {
            string output = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml("<myRoot>" + xml + "</myRoot>"); //wrap a custom root element to work with bad xml

            //MemoryStream xmlStream = new MemoryStream();
            //xmlDoc.Save(xmlStream);
            //xmlStream.Position = 0;
            //XDocument xDoc = XDocument.Load(xmlStream);
            //XElement xRoot = XElement.Load(xmlStream);

            XmlNodeList nodeList = xmlDoc.SelectNodes("//myRoot");

            foreach(XmlNode node in nodeList)
            {
                var xmlRoot = xmlDoc.DocumentElement;
                foreach(name in xmlRoot)
                {

                }
            }
        }
    }

                //    for (int i = 0; i<elements.Count; i++)
                //{
                //    Console.WriteLine("Name: {0}, value: {1}", elements[i].Name, elements[i].InnerXml);
                //    Console.WriteLine();
                //}

}
