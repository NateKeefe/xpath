using System;
using System.IO;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var xml = File.ReadAllText("XMLFile1.xml");
            //XPath.Xpath2(xml, "accountNumber", 1);
            //Console.ReadLine();
            Descendants.GetAllNodes(xml, "myRoot");
            Console.ReadLine();
        }
    }
}