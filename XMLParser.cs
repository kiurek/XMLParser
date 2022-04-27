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
            
            XmlNodeList xmlItems = zlecenie.SelectNodes("/document_data/document_items/item");
            string item_number = "", document_number = "", item_quantity = "", product_des = "", glasswidth = "", glassheight = "", product_thickness = "", spacer_colour = "", colour = "";
            foreach (XmlNode xmlNode in xmlItems)
            {
                item_number = xmlNode.SelectSingleNode("item_number").InnerText;
                document_number = xmlNode.SelectSingleNode("document_number").InnerText;
                item_quantity = xmlNode.SelectSingleNode("item_quantity").InnerText;

                    XmlNodeList xmlDetails = zlecenie.SelectNodes("/document_data/document_items/item/matlist/glass_products/g_rect");
                    foreach (XmlNode xmlNode1 in xmlDetails)
                    {
                        product_des = xmlNode1.SelectSingleNode("product_des").InnerText;
                        glasswidth = xmlNode1.SelectSingleNode("glasswidth").InnerText;
                        glassheight = xmlNode1.SelectSingleNode("glassheight").InnerText;
                        product_thickness = xmlNode1.SelectSingleNode("product_thickness").InnerText;

                            XmlNodeList xmlColour = zlecenie.SelectNodes("/document_data/document_items/item/matlist/glass_products/g_rect/pane_structure/pane");
                            foreach (XmlNode xmlNode3 in xmlColour)
                            {
                                colour = xmlNode3.SelectSingleNode("key").InnerText;
                            }
                                XmlNodeList xmlGlass = zlecenie.SelectNodes("/document_data/document_items/item/matlist/glass_products/g_rect/edge_seal/spacer_colour");
                                foreach (XmlNode xmlNode2 in xmlGlass)
                                {
                                    spacer_colour = xmlNode2.SelectSingleNode("des").InnerText;
                                }
                    }
            Console.WriteLine("| " + item_number + " | " + document_number + " | " + item_quantity + " | " + product_des + " | " + glasswidth + " | " + glassheight + " | " + product_thickness + " | " + colour + " | " + spacer_colour);
            }
        }
    }
}
