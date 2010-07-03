using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace agape_rfid_desktop
{
    class DescriptionFileHandler
    {

        private DirectoryInfo dirPath;

        public DescriptionFileHandler()
        {
            this.dirPath = new DirectoryInfo(agape_rfid_desktop.Properties.Settings.Default.productDescriptionDataPath);
        }

        public void loadItemDescription(ItemDescription details, String fileName)
        {
            FileInfo file = new FileInfo(dirPath.FullName + "\\" + fileName);
            if (!file.Exists)
            {
                throw new IOException("File does not exist");
            }
            FileStream s = file.Open(FileMode.Open, FileAccess.Read);
            StreamReader stream = new StreamReader(s, Encoding.Default);
            String content = stream.ReadToEnd();
            String[] splitted = content.Split(new string[] { "[","]\r\n","\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < splitted.Length - 1; i++)
            {
                if (splitted[i] == agape_rfid_desktop.Properties.Resources.descIT) 
                {
                    details[Languages.IT].Description = splitted[++i];
                }
                else if (splitted[i] == agape_rfid_desktop.Properties.Resources.descEN)
                {
                    details[Languages.EN].Description = splitted[++i];
                }
                else if (splitted[i] == agape_rfid_desktop.Properties.Resources.valIT)
                {
                    details[Languages.IT].Values = splitted[++i];
                }
                else if (splitted[i] == agape_rfid_desktop.Properties.Resources.valEN)
                {
                    details[Languages.EN].Values = splitted[++i];
                } 
            }

                // alla fine della fiera...close file stream
            s.Close();
        }

    }
}
