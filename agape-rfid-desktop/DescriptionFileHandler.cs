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
        public String Path
        {
            get { return Path; }
            set
            {
                DirectoryInfo dir1 = new DirectoryInfo(@value);
                if (dir1.Exists)
                {
                    dirPath = dir1;
                }
                else
                {
                    throw new IOException("The supplied path does not exist");
                }
            }
        }

        public DescriptionFileHandler(String path)
        {
            this.Path = path;
        }

        public ItemDescription loadItemDescription(String fileName)
        {
            FileInfo file = new FileInfo(dirPath.FullName + "\\" + fileName);
            if (!file.Exists)
            {
                throw new IOException("File does not exist");
            }
            FileStream s = file.Open(FileMode.Open, FileAccess.Read);


            // alla fine della fiera...close file stream
            s.Close();

            return new ItemDescription(Languages.IT,"aDescription","aValue","aPath");
        }

    }
}
