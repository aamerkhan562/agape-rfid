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

namespace agape_rfid_desktop
{
    class CertificateHandler
    {
        public static void createCertificate(ItemDescription desc, Languages lang)
        {

            using (WordprocessingDocument template = WordprocessingDocument.Open(agape_rfid_desktop.Properties.Settings.Default.templatePath, false))
            using (WordprocessingDocument outDoc = WordprocessingDocument.Create(agape_rfid_desktop.Properties.Settings.Default.outputWordFilePath + "//" + "pippo" + ".docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                outDoc.AddThumbnailPart(ThumbnailPartType.Wmf);
                ThumbnailPart thumbnailPart1 = template.ThumbnailPart;
                ThumbnailPart thumbnailPart2 = outDoc.ThumbnailPart;
                using (StreamReader streamReader = new StreamReader(thumbnailPart1.GetStream()))
                using (StreamWriter streamWriter = new StreamWriter(thumbnailPart2.GetStream(FileMode.Create)))
                {
                    streamWriter.Write(streamReader.ReadToEnd());
                }

                outDoc.AddMainDocumentPart();
                MainDocumentPart outPart1 = template.MainDocumentPart;
                MainDocumentPart outPart2 = outDoc.MainDocumentPart;
                using (StreamReader streamReader = new StreamReader(outPart1.GetStream()))
                using (StreamWriter streamWriter = new StreamWriter(outPart2.GetStream(FileMode.Create)))
                {
                    streamWriter.Write(streamReader.ReadToEnd());
                }

               /* XmlDocument xmldocument = new XmlDocument();
                xmldocument.LoadXml(outDoc.MainDocumentPart.Document.OuterXml);

                XmlNodeList nodelist = xmldocument.GetElementsByTagName("w:t");
                foreach (System.Xml.XmlNode node in nodelist)
                {
                     if (node.FirstChild.Value == "names") {
                        node.ReplaceChild(xmldocument.CreateTextNode(desc.Product), node.FirstChild);
                     }
                     else if (node.FirstChild.Value == "desc-it")
                     {
                         node.ReplaceChild(xmldocument.CreateTextNode(desc[Languages.IT].Description), node.FirstChild);
                     }
                     else if (node.FirstChild.Value == "desc-en")
                     {
                         node.ReplaceChild(xmldocument.CreateTextNode(desc[Languages.EN].Description), node.FirstChild);
                     }
                     else if (node.FirstChild.Value == "material")
                     {
                         node.ReplaceChild(xmldocument.CreateTextNode("Materiale/Materials"), node.FirstChild);
                     }
                     else if (node.FirstChild.Value == "serial")
                     {
                         node.ReplaceChild(xmldocument.CreateTextNode("Numero di serie / Serial number: " + desc.SerialNumber), node.FirstChild);
                     }
                     else if (node.FirstChild.Value == "date")
                     {
                         node.ReplaceChild(xmldocument.CreateTextNode("Data di consegna / Delivery date: " + desc.deliveryDate.ToShortDateString()), node.FirstChild);
                     }
                     else if (node.FirstChild.Value == "customer")
                     {
                         node.ReplaceChild(xmldocument.CreateTextNode("Nome Cliente / Customer Name: " + desc.Customer), node.FirstChild);
                     }
                     else if (node.FirstChild.Value == "vendor")
                     {
                         node.ReplaceChild(xmldocument.CreateTextNode("Nome rivenditore / Vendor name: " + desc.Vendor), node.FirstChild);
                     }

                }

                nodelist = xmldocument.GetElementsByTagName("w:document");

                outDoc.MainDocumentPart.Document = new Document(xmldocument.LastChild.OuterXml);
                outDoc.MainDocumentPart.Document.Save();*/
            }

            // open word and show the file
            try
            {
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = agape_rfid_desktop.Properties.Settings.Default.outputWordFilePath + "//" + desc.Product + ".docx";
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
