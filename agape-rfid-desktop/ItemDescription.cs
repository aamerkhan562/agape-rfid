using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace agape_rfid_desktop
{
    class ItemDescription
    {
        public String CodArt
        {
            get;
            set;
        }
        public String Product
        {
            get;
            set;
        }

        public String SerialNumber
        {
            get;
            set;
        }

        public String Customer
        {
            get;
            set;
        }

        public String Vendor
        {
            get;
            set;
        }

        public DateTime deliveryDate
        {
            get;
            set;
        }

        private LocalizedDetails[] details = new LocalizedDetails[2];

        private Bitmap photo;
        public Bitmap Photo
        {
            get { return photo; }
            private set { photo = value; }
        }

        private String photoPath;
        public String PhotoPath
        {
            get { return photoPath; }
            set
            {
                try
                {
                    Photo = new Bitmap(value);
                    photoPath = value;
                }
                catch {
                    Photo = Properties.Resources.warning;
                    photoPath = "";
                }
            }

        }

        public ItemDescription()
        {
            for (int i = 0; i < details.Length; i++) 
            {
                details[i] = new LocalizedDetails();
            }
        }

        public LocalizedDetails this[Languages index]
        { // The get accessor.
             get
             {
                 return details[(int)index];
            }
        }

        public override String ToString()
        {
            String res = "";
            foreach (LocalizedDetails det in details)
            {
                res +=  det.ToString();
            }
            return res;
        }
    }

    public class LocalizedDetails
    {
        public String Description;
        public String Values;

        public LocalizedDetails() : this("", "", "") { }

        public LocalizedDetails(String desc, String values, String photoPath)
        {
            this.Description = desc;
            this.Values = values;
        }

        public override String ToString()
        {
            return Description + " " + Values;
        }
    }

    public enum Languages : int
    {
        IT,EN
    }
}
