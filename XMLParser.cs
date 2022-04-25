using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace XMLParser
{
    public class XMLParser
    {
        public static void ZlecenieXDocumentParse()
        {
            /*
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\kkure\source\repos\XMLParser\XMLFile1.xml");
                XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Store/Product");
                string product_id = "", product_name = "", product_price = "";
                foreach (XmlNode node in nodes)
                {
                    product_id = node.SelectSingleNode("Product_id").InnerText;
                    product_name = node.SelectSingleNode("Product_name").InnerText;
                    product_price = node.SelectSingleNode("Product_price").InnerText;
                    Console.WriteLine(product_id + " " + product_name + " " + product_price);
                }
            */

            XmlDocument zlecenie = new XmlDocument();
            zlecenie.Load(@"C:\Users\kkure\source\repos\XMLParser\Zlecenie_T2202431_6.4.2022_ZAM00058.xml");
            XmlNodeList xmlItems = zlecenie.DocumentElement.SelectNodes("/document_data/document_items/item");
            var item_number = "";
            string item_quantity = "";
            string document_number = "";
            foreach (XmlNode xmlNode in xmlItems)
            {
                item_number = xmlNode.SelectSingleNode("item_number").InnerText;
                document_number = xmlNode.SelectSingleNode("document_number").InnerText;
                item_quantity = xmlNode.SelectSingleNode("item_quantity").InnerText;
                Console.WriteLine("| " + item_number + " | " + document_number + " | " + item_quantity + " | ");
            }

            XmlNodeList xmlDetails = zlecenie.DocumentElement.SelectNodes("/document_data/document_items/item/matlist/glass_products/g_rect");
            string product_des = "", glasswidth = "", glassheight = "";
            foreach (XmlNode xmlNode in xmlDetails)
            {
                product_des = xmlNode.SelectSingleNode("product_des").InnerText;
                glasswidth = xmlNode.SelectSingleNode("glasswidth").InnerText;
                glassheight = xmlNode.SelectSingleNode("glassheight").InnerText;
                Console.WriteLine(product_des + glasswidth + glassheight);
            }

            Console.WriteLine("| " + item_number + " | " + document_number + " | " + item_quantity + " | " + product_des + " | " + glasswidth + " | " + glassheight);


            /*
            XDocument xml = XDocument.Load(@"C:\Users\kkure\source\repos\XMLParser\Zlecenie_T2202431_6.4.2022_ZAM00058.xml");

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
            */
        }
    }
}
