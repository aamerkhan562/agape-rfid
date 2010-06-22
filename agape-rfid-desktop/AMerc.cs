using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.mintlab.desktopnet.mercframework;

namespace agape_rfid_desktop
{
    class AMerc : Merc 
    {
        [MessageBinding(message="init")]
        public void init()
        {
            Console.Write("init");
        }
    }
}
