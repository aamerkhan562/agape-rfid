using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using it.mintlab.desktopnet.mercframework;

namespace agape_rfid_desktop
{
    public partial class Form1 : Form
    {

        // campi di utilità

        private Boolean modifiedData = false;

        // ---------------

        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!checkOrderParameters())
            {
                this.errorLbl.Text = "Campi obbligatori (*) mancanti o incorretti";
            }
        }

        private Boolean checkOrderParameters()
        {
            if (this.codartTxt.Text == "" || this.descTxt.Text == "" || this.idTxt.Text == "")
                return false;
            return true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (this.searchTxt.Text == "")
            {
                // pianta una grana
               return;
            }

            // cerco nel db

            // se trovo visualizzo il pannello sottostante
            this.tabPane.Visible = true;

            // se no pianto un'altra grana
        }

    }
}
