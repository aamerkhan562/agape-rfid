using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace agape_rfid_desktop
{
    class CertificateHandler
    {

        public static void findAll<T>(OpenXmlElement root, List<T> res) 
        {
            foreach (OpenXmlElement el in root.Elements())
            {
                if (el.GetType() == typeof(T))
                {
                    Object obj = el;
                    res.Add((T)obj);
                }
                if (el.HasChildren)
                {
                    findAll<T>(el, res);
                }
            }
        }

        public static void createCertificate(ItemDescription desc, Languages lang)
        {
            System.IO.File.Copy(agape_rfid_desktop.Properties.Settings.Default.certTemplatePath, agape_rfid_desktop.Properties.Settings.Default.outputWordFilePath + "\\" + desc.Product + "-Certificate.docx", true);
            using (WordprocessingDocument outDoc = WordprocessingDocument.Open(agape_rfid_desktop.Properties.Settings.Default.outputWordFilePath + "\\" + desc.Product + "-Certificate.docx",true))
            {
                List<DocumentFormat.OpenXml.Wordprocessing.Text> nodes = new List<DocumentFormat.OpenXml.Wordprocessing.Text>();
                findAll<DocumentFormat.OpenXml.Wordprocessing.Text>(outDoc.MainDocumentPart.Document.Body,nodes);
                foreach (DocumentFormat.OpenXml.Wordprocessing.Text txt in nodes)
                {
                    if (txt.Text == "title")
                    {
                        txt.Text = (lang == Languages.IT ? "Certificato di autenticità" : "Certificate of authenticy");
                    }
                     if (txt.Text == "name") {
                         txt.Text = (lang == Languages.IT ? "Prodotto: " : "Product: ") + desc.Product;
                     }
                     else if (txt.Text == "desc")
                     {
                         txt.Text = (lang == Languages.IT ? desc[Languages.IT].Description : desc[Languages.EN].Description);
                     }
                     else if (txt.Text == "material")
                     {
                         txt.Text = (lang == Languages.IT ? "Materiale: " : "Materials: ");
                     }
                     else if (txt.Text == "serial")
                     {
                         txt.Text = (lang == Languages.IT ? "Numero di serie : " : "Serial number: ") + desc.SerialNumber;
                     }
                     else if (txt.Text == "date")
                     {
                         txt.Text = (lang == Languages.IT ? "Data di consegna: " : "Delivery date: " )+ desc.deliveryDate.ToShortDateString();
                     }
                     else if (txt.Text == "customer")
                     {
                         txt.Text = (lang == Languages.IT ? "Nome Cliente: ":"Customer Name: ") + desc.Customer;
                     }
                     else if (txt.Text == "vendor")
                     {
                         txt.Text = (lang == Languages.IT ? "Nome rivenditore ":" Vendor name: ") + desc.Vendor;
                     }
                }

                if (desc.Photo != null)
                { 
                    ImagePart imagePart = outDoc.MainDocumentPart.AddImagePart(ImagePartType.Jpeg); 
                    imagePart.FeedData(File.Open(desc.PhotoPath,FileMode.Open));
                    //Blip blip = outDoc.MainDocumentPart.Document.Descendants<Blip>().First();
                    //blip.Embed = "rId102";
                    outDoc.MainDocumentPart.Document.Save();
                }
                //outDoc.MainDocumentPart.Document.MainDocumentPart.AddImagePart(ImagePartType.Bmp);
            }

            // open word and show the file
            try
            {
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = agape_rfid_desktop.Properties.Settings.Default.outputWordFilePath + "//" + desc.Product + "-Certificate.docx";
                myProcess.StartInfo.Verb = "Open";
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            }
            catch (Exception)
            {
                Console.WriteLine("Error opening file");
            }
        }
    }
}
