using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLParser
{
    public class XMLParser
    {

        public static void ZlecenieXDocumentParse()
        {            
            XmlDocument zlecenie = new XmlDocument();
            zlecenie.Load(@"C:\Users\Kubiś\Source\Repos\kiurek\XMLParser\Zlecenie_T2202431_6.4.2022_ZAM00058.xml");
            
            List<string> item_number = new List<string>();
            List<string> document_number = new List<string>();
            List<string> item_quantity = new List<string>();
            List<string> product_des = new List<string>();
            List<string> glasswidth = new List<string>();
            List<string> glassheight = new List<string>();
            List<string> product_thickness = new List<string>();
            List<string> spacer_colour = new List<string>();
            List<string> colour = new List<string>();
            List<string> record_glasstext1 = new List<string>();

            XmlNodeList xmlItems = zlecenie.SelectNodes("/document_data/document_items/item");
            foreach (XmlNode xmlNode in xmlItems)
            {
                item_number.Add(xmlNode.SelectSingleNode("item_number").InnerText);
                document_number.Add(xmlNode.SelectSingleNode("document_number").InnerText);
                item_quantity.Add(xmlNode.SelectSingleNode("item_quantity").InnerText);
            }

            XmlNodeList xmlDetails = zlecenie.DocumentElement.SelectNodes("/document_data/document_items/item/matlist/glass_products/g_rect");
            foreach (XmlNode xmlNode in xmlDetails)
            {
                product_des.Add(xmlNode.SelectSingleNode("product_des").InnerText);
                glasswidth.Add(xmlNode.SelectSingleNode("glasswidth").InnerText);
                glassheight.Add(xmlNode.SelectSingleNode("glassheight").InnerText);
                product_thickness.Add(xmlNode.SelectSingleNode("product_thickness").InnerText);
                record_glasstext1.Add(xmlNode.SelectSingleNode("record_glasstext1").InnerText);
                
            }

            XmlNodeList xmlGlass = zlecenie.SelectNodes("/document_data/document_items/item/matlist/glass_products/g_rect/edge_seal/spacer_colour");
            foreach (XmlNode xmlNode in xmlGlass)
            {
                spacer_colour.Add(xmlNode.SelectSingleNode("key").InnerText);
            }

            XmlNodeList xmlColours = zlecenie.SelectNodes("/document_data/document_items/item/matlist/glass_products/g_rect/pane_structure/pane");
            foreach (XmlNode xmlNode in xmlColours)
            {
                colour.Add(xmlNode.SelectSingleNode("key").InnerText);
            }

            for (int i = 0, j = 1, counter = 0; i < item_number.Count; counter += 2, j = counter + 1, i++)
            {
                Console.WriteLine("| " + item_number[i] + " | " + document_number[i] + " | " + item_quantity[i] + " | " + product_des[i] + " | " + glasswidth[i] + " | " + glassheight[i] + " | " + product_thickness[i] + " | " + spacer_colour[i] + " | " + colour[counter] + colour[j] + " | " + record_glasstext1[i]);
                
            }
        }
    }
}
