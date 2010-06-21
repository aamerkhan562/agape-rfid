using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agape_rfid_desktop
{
    class ItemDescription
    {

        public Languages Language;
        public String Description;
        public String Values;
        public String PhotoPath;

        public ItemDescription(Languages language, String desc, String values, String photoPath)
        {
            this.Language = language;
            this.Description = desc;
            this.Values = values;
            this.PhotoPath = photoPath;
        }

        public override String ToString()
        {
            return Language + " " + Description + " " + Values + " " + PhotoPath;
        }
    }

    enum Languages
    {
        IT,EN
    }
}
