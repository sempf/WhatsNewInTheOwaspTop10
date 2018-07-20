using System;
using System.IO;
using System.Xml;

// POC James Jardine
// HT Carl Sampson

namespace XXE
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = File.ReadAllText("C:\\temp\\doc.xml");

            XmlReaderSettings rs = new XmlReaderSettings();

            rs.ProhibitDtd = false;

            XmlReader myReader = XmlReader.Create(new StringReader(xml), rs);

            while (myReader.Read())
            {
                Console.WriteLine(myReader.Value);
            }
            Console.ReadLine();
        }
    }
}
