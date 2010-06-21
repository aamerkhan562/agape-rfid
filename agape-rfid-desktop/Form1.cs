using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using it.mintlab.desktopnet.mercframework;

namespace agape_rfid_desktop
{
    public partial class Form1 : Form
    {

        // campi di utilità

        private Boolean modifiedData = false;
        private Boolean descriptionLoaded = false;
        private DescriptionFileHandler handler;

        // ---------------

        public Form1()
        {
            InitializeComponent();

            handler = new DescriptionFileHandler(agape_rfid_desktop.Properties.Resources.productDescriptionDataPath);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!checkOrderParameters())
            {
                this.errorLbl.Text = "Campi obbligori (*) mancanti o incorretti";
            }

            this.Validate();
            this.bindingSource1.EndEdit();
            taggedItemsViewTableAdapter.Update(agapeTaggedItemsDS.TaggedItemsView);
            this.saveBtn.Enabled = false;
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
            //agapeTaggedItemsDS.TaggedItemsViewDataTable table = new agapeTaggedItemsDS.TaggedItemsViewDataTable();
            taggedItemsViewTableAdapter.FillByCodMatricola(agapeTaggedItemsDS.TaggedItemsView, searchTxt.Text);
            

            // se trovo visualizzo il pannello sottostante
            this.tabPane.Visible = true;
            this.saveBtn.Enabled = false;

            // se no pianto un'altra grana
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agapeTaggedItemsDS.TaggedItemsView' table. You can move, or remove it, as needed.
            this.taggedItemsViewTableAdapter.Fill(this.agapeTaggedItemsDS.TaggedItemsView);

        }

        private void tabPane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPane.SelectedIndex == 1)
            {
                // load product-related description files
                if (!descriptionLoaded)
                {
                    try
                    {
                        this.Text = handler.loadItemDescription("desc.txt").ToString();
                        this.pictureIt.Image = new Bitmap("C:\\Documents and Settings\\User\\Desktop\\mint-lab\\desc\\img.png");
                    }
                    catch (IOException) 
                    {
                        System.Windows.Forms.MessageBox.Show(this,"File di descrizione non trovato");
                    }
                }
            }
        }

        private void pictureEn_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Documents and Settings\\User\\Desktop\\mint-lab\\desc\\img.png");
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(agape_rfid_desktop.Properties.Resources.productDescriptionDataPath + "\\" + "desc.txt");
        }

        private void bindingSource1_DataMemberChanged(object sender, EventArgs e)
        {
            this.Text = "datamember changed";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.Text = "current changed";
        }

        private void recordModified(object sender, EventArgs e)
        {
            this.saveBtn.Enabled = true;
        }
    }
}
