using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace LearningLine.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new SalesOrder
            {
                Number = 42,
                Customer = "Big Bucks Supermart",
                Notes = "This customer has lots of money. Do not apply discount.",
            };

            var xml = SalesOrderToXml(order);
            Console.WriteLine(xml);
            Console.ReadKey(true);
        }

        static string SalesOrderToXml(SalesOrder order)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var result = new StringBuilder();
            var settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Indent = true
            };
            var stream = XmlTextWriter.Create(result, settings);
            var ser = new XmlSerializer(typeof(SalesOrder));
            ser.Serialize(stream, order, ns);
            return result.ToString();
        }
    }
}
