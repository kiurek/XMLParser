using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace XMLParser
{
    class XMLParser
    {
        public static void ZlecenieXDocumentParse()
        {
            XDocument xml = XDocument.Load(@"C:\Users\kkure\source\repos\XMLParser\Zlecenie.xml");

            IEnumerable<XElement> xElements = xml.Descendants("product_des");

            IEnumerable<XElement> xElements1 = xml.Descendants("glasswidth");

            IEnumerable<XElement> xElements2 = xml.Descendants("glassheight");

            IEnumerable<XElement> xElements3 = xml.Descendants("pane_structure").Descendants("pane");

            foreach (XElement element in xElements)
            {
                Console.WriteLine("Nazwa: " + element.Value);
            }

            foreach (XElement element in xElements1)
            {
                Console.WriteLine("Szerokość: " + element.Value);
            }

            foreach (XElement element in xElements2)
            {
                Console.WriteLine("Wysokość: " + element.Value);
            }

            foreach (XElement element in xElements3)
            {
                Console.WriteLine("Kolor: " + element.Value);
            }
        }
    }
}
