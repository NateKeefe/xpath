using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ConsoleApplication2
{
    public static class XPath
    {
        public const string NoResultsError = "No results were found. ";
        public const string XPathException = "Error selecting node. Message: ";
        public const string MaxDepth = "///////////////////////////////////////////////////////////////";

        public static void Xpath(string xml, string nodeName, int nodeDepth)
        {
            string output = string.Empty;
            string depth = XPath.MaxDepth.Remove(nodeDepth);

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml("<root>" + xml + "</root>");

            try
            {
                var data = (xdoc.SelectSingleNode(depth + nodeName)?.InnerXml ?? "No Results");
                output = (xdoc.SelectSingleNode(depth + nodeName)?.InnerXml ?? "No Results");

                if (output == "No Results")
                {
                    output = XPath.NoResultsError + "Node Name: " + nodeName + " Nodes depth: " + nodeDepth;
                }
            }
            catch (XPathException exp)
            {
                output = XPath.XPathException + exp.Message;
            }

            Console.WriteLine(output);
        }

        public static void XmlDict(string xml)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml("<root>" + xml + "</root>");

            XElement root = XElement.Load(new XmlNodeReader(xdoc));

            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (XElement el in root.Elements())
                dict.Add(el.Name.LocalName, el.Value);
            foreach (string str in dict.Keys)
                Console.WriteLine("{0}:{1}", str, dict[str]);
        }

        public static void XmlTextOnly(string xml)
        {
            string contents = string.Empty;

            XmlDocument document = new XmlDocument();
            document.LoadXml("<root>" + xml + "</root>");

            foreach (XmlNode child in document.DocumentElement.ChildNodes)
            {
                if (child.NodeType == XmlNodeType.Element)
                {
                    contents += child.InnerText + ",";
                }
            }

            Console.WriteLine(contents);
        }
    }
}
