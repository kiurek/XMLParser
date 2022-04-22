using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace XMLParser
{
    class XMLParser
    {
        public static void ZlecenieXDocumentParse()
        {
            XDocument xml = XDocument.Load(@"C:\Users\Kubiś\source\repos\kiurek\XMLParser\Zlecenie_T2202431_6.4.2022_ZAM00058.xml");

            IEnumerable<XElement> xElements = xml.Descendants("document_number");

            IEnumerable<XElement> xElements1 = xml.Descendants("item_quantity");

            IEnumerable<XElement> xElements2 = xml.Descendants("product_des");

            IEnumerable<XElement> xElements3 = xml.Descendants("glasswidth");

            IEnumerable<XElement> xElements4 = xml.Descendants("glassheight");

            IEnumerable<XElement> xElements5 = xml.Descendants("product_thickness");

            IEnumerable<XElement> xElements6 = xml.Descendants("pane_structure").Descendants("pane").Descendants("key");

            IEnumerable<XElement> xElements7 = xml.Descendants("spacer_colour").Descendants("key");

            IEnumerable<XElement> xElements8 = xml.Descendants("order_text");

            foreach (XElement element in xElements)
            {
                Console.WriteLine("Nr dokumentu: " + element.Value);
            }

            Console.WriteLine();

            foreach (XElement element in xElements1)
            {
                Console.WriteLine("Ilość: " + element.Value);
            }

            Console.WriteLine();

            foreach (XElement element in xElements2)
            {
                Console.WriteLine("Nazwa: " + element.Value);
            }

            Console.WriteLine();

            foreach (XElement element in xElements3)
            {
                Console.WriteLine("Szerokość: " + element.Value);
            }

            Console.WriteLine();

            foreach (XElement element in xElements4)
            {
                Console.WriteLine("Wysokość: " + element.Value);
            }

            Console.WriteLine();

            foreach (XElement element in xElements5)
            {
                Console.WriteLine("Grubość: " + element.Value);
            }

            Console.WriteLine();

            foreach (XElement element in xElements6)
            {
                Console.WriteLine("Kolor: " + element.Value);
            }

            Console.WriteLine();

            foreach (XElement element in xElements7)
            {
                Console.WriteLine("Kolor szkła: " + element.Value);
            }

            Console.WriteLine();

            foreach (XElement element in xElements8)
            {
                Console.WriteLine("Podsumowanie: " + element.Value);
            }

            Console.WriteLine();
        }
    }
}
