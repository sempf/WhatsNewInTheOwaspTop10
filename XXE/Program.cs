using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

// POC: James Jardine

namespace XXE
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = File.ReadAllText("C:\\doc.xml");

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
