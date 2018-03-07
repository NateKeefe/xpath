using System;
using System.IO;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var xml = File.ReadAllText(@"C:\Users\Admin\documents\visual studio 2015\Projects\ConsoleApplication2\ConsoleApplication2\XMLFile1.xml");

            //XPath.Xpath(xml, "account", 2);
            //XPath.Xpath(xml, "amount", 2);
            //XPath.Xpath(xml, "mainLine", 2);
            //XPath.Xpath(xml, "postingPeriod", 2);
            //XPath.Xpath(xml, "tranDate", 2);
            //XPath.Xpath(xml, "tranId", 2);
            //XPath.Xpath(xml, "type", 2);
            //XPath.Xpath(xml, "accountNumber", 2);
            //XPath.Xpath(xml, "test434g3", 2);

            //XPath.XmlTextOnly(xml);

            //XPath.XmlDict(xml);

            Console.ReadLine();
        }
    }
}