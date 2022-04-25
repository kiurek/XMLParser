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
            XmlNodeList xmlList = zlecenie.DocumentElement.SelectNodes("/document_data/document_items/item");
            string item_number = "", document_number = "", item_quantity = "", product_des = "";
            foreach (XmlNode xmlItem in xmlList)
            {
                item_number = xmlItem.SelectSingleNode("item_number").InnerText;
                document_number = xmlItem.SelectSingleNode("document_number").InnerText;
                item_quantity = xmlItem.SelectSingleNode("item_quantity").InnerText;
                product_des = xmlItem.SelectSingleNode("/mat_list/glass_products/g_rect/product_des").InnerText;
                Console.WriteLine(item_number + " " + document_number + " " + item_quantity + " " + product_des);
            }


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
                int e = 0;
                e++;
                Console.WriteLine(e +"Nr dokumentu: " + element.Value);
            }

            foreach (XElement element in xElements1)
            {
                Console.WriteLine("Ilość: " + element.Value);
            }

            foreach (XElement element in xElements2)
            {
                Console.WriteLine("Nazwa: " + element.Value);
            }

            foreach (XElement element in xElements3)
            {
                Console.WriteLine("Szerokość: " + element.Value);
            }

            foreach (XElement element in xElements4)
            {
                Console.WriteLine("Wysokość: " + element.Value);
            }

            foreach (XElement element in xElements5)
            {
                Console.WriteLine("Grubość: " + element.Value);
            }

            foreach (XElement element in xElements6)
            {
                Console.WriteLine("Kolor: " + element.Value);
            }

            foreach (XElement element in xElements7)
            {
                Console.WriteLine("Kolor szkła: " + element.Value);
            }
            
            foreach (XElement element in xElements8)
            {
                Console.WriteLine("Podsumowanie: " + element.Value);
            }
            */
        }
    }
}
