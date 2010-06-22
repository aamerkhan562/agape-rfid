using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agape_rfid_desktop
{
    class ItemDescription
    {
        private LocalizedDetails[] details = new LocalizedDetails[2];

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
        public String PhotoPath;

        public LocalizedDetails() : this("", "", "") { }

        public LocalizedDetails(String desc, String values, String photoPath)
        {
            this.Description = desc;
            this.Values = values;
            this.PhotoPath = photoPath;
        }

        public override String ToString()
        {
            return Description + " " + Values + " " + PhotoPath;
        }
    }

    public enum Languages : int
    {
        IT,EN
    }
}
