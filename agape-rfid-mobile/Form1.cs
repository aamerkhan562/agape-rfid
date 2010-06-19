using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.mintlab.compactnet.mercframework;

namespace agape_rfid_mobile
{
    public partial class Form1 : FormMerc
    {
        public Form1()
        {
            InitializeComponent();
            Framework f = new Framework();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dispatcher.deliverMessage("Frame", "go");
        }


        [MessageBinding(message="init")]
        private void buttonClicked()
        {
            int i = 0;
            this.Text = "Culo" + i++;
        }
    }
}