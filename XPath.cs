using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ConsoleApplication2
{
    public static class XPath
    {
        public const string NoResultsError = "No results were found. Xpath is case-sensitive. Node input: ";
        public const string XPathException = "Error selecting node. Message: ";

        //public static void Xpath(string xml, string nodeName)
        //{
        //    string output = string.Empty;
        //    XmlDocument xdoc = new XmlDocument();
        //    xdoc.LoadXml("<myRoot>" + xml + "</myRoot>"); //wrap a custom root element to work with bad xml

        //    try
        //    {
        //        output = (xdoc.SelectSingleNode("//" + nodeName)?.InnerXml ??
        //            NoResultsError + nodeName);
        //    }
        //    catch (XPathException exp)
        //    {
        //        output = XPathException + exp.Message;
        //    }

        //    Console.WriteLine(output);
        //}

        public static void Xpath2(string xml, string nodeName, int occurance)
        {
            string output = string.Empty;
            var itemNum = occurance;
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml("<myRoot>" + xml + "</myRoot>"); //wrap a custom root element to work with bad xml

            try
            {
                output = (xdoc.SelectNodes("//" + nodeName)?.Item(itemNum)?.InnerXml ?? NoResultsError + nodeName
                    + ", Occurance input: " + itemNum.ToString());
            }
            catch (XPathException exp)
            {
                output = XPathException + exp.Message;
            }

            Console.WriteLine(output);
        }
    }
}
