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

        // campi da eliminare
        private const String codart = "desc";

        // campi di utilità
        private readonly FileSystemWatcher watcher = new FileSystemWatcher();

        private Boolean modified = false;
        private DescriptionFileHandler handler;
        private ItemDescription details = null;
            
        // ---------------

        public Form1()
        {
            InitializeComponent();

            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += OnChanged;
            watcher.Path = agape_rfid_desktop.Properties.Resources.productDescriptionDataPath;
            watcher.IncludeSubdirectories = false;

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
            this.modified = false;
        }

        private Boolean checkOrderParameters()
        {
            if (this.codartTxt.Text == "" || this.descTxt.Text == "" || this.idTxt.Text == "")
                return false;
            return true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (modified)
            {
                MessageBox.Show("Sono state apportate modifiche non salvate ai dati");
                return;
            }

            if (this.searchTxt.Text == "")
            {
                // pianta una grana
               return;
            }

            // cerco nel db
            //agapeTaggedItemsDS.TaggedItemsViewDataTable table = new agapeTaggedItemsDS.TaggedItemsViewDataTable();
            //taggedItemsViewTableAdapter.FillByCodMatricola(agapeTaggedItemsDS.TaggedItemsView, searchTxt.Text);
            

            // se trovo visualizzo il pannello sottostante
            this.tabPane.Visible = true;
            this.saveBtn.Enabled = false;

            watcher.EnableRaisingEvents = false;
            watcher.Filter = codart + ".txt";

            // se no pianto un'altra grana
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agapeTaggedItemsDS.TaggedItemsView' table. You can move, or remove it, as needed.
           // this.taggedItemsViewTableAdapter.Fill(this.agapeTaggedItemsDS.TaggedItemsView);

        }

        private void tabPane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPane.SelectedIndex == 1)
            {
                // load product-related description files
                if (details == null)
                {
                    try
                    {
                        details = handler.loadItemDescription(codart + ".txt");
                        loadField();
                    }
                    catch (IOException) 
                    {
                        System.Windows.Forms.MessageBox.Show(this,"File di descrizione non trovato");
                    }
                }
            }
        }

        private void loadField()
        {
            this.descEnTxt.Text = details[Languages.EN].Description;
            this.descItTxt.Text = details[Languages.IT].Description;
            this.valuesEnTxt.Text = details[Languages.EN].Values;
            this.valuesItTxt.Text = details[Languages.IT].Values;
            this.photoEnTxt.Text = details[Languages.EN].PhotoPath;
            this.photoItTxt.Text = details[Languages.IT].PhotoPath;
        }

        private void pictureEn_DoubleClick(object sender, EventArgs e)
        {
            if (this.details[Languages.EN].PhotoPath != "")
                System.Diagnostics.Process.Start(this.details[Languages.EN].PhotoPath);
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(agape_rfid_desktop.Properties.Resources.productDescriptionDataPath + "\\" + codart + ".txt");
            watcher.EnableRaisingEvents = true;
        }

        private void recordModified(object sender, EventArgs e)
        {
            this.saveBtn.Enabled = true;
            this.modified = true;
        }

        private void browseItBtn_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.photoItTxt.Text = this.openFileDialog1.FileName;
            this.details[Languages.IT].PhotoPath = this.openFileDialog1.FileName;
            this.pictureIt.Image = new Bitmap(this.details[Languages.IT].PhotoPath);
        }

        private void browseEnBtn_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.photoItTxt.Text = this.openFileDialog1.FileName;
            this.details[Languages.IT].PhotoPath = this.openFileDialog1.FileName;
            this.pictureEn.Image = new Bitmap(this.details[Languages.EN].PhotoPath);
        }

        private void pictureIt_Click(object sender, EventArgs e)
        {
            if (this.details[Languages.IT].PhotoPath != "")
                System.Diagnostics.Process.Start(this.details[Languages.IT].PhotoPath);
        }

        private void descEnTxt_Leave(object sender, EventArgs e)
        {
            this.details[Languages.EN].Description = this.descEnTxt.Text;
        }

        private void valuesEnTxt_Leave(object sender, EventArgs e)
        {
            this.details[Languages.EN].Values = this.valuesEnTxt.Text;
        }

        private void descItTxt_Leave(object sender, EventArgs e)
        {
            this.details[Languages.IT].Description = this.descItTxt.Text;
        }

        private void valuesItTxt_Leave(object sender, EventArgs e)
        {
            this.details[Languages.IT].Values = this.valuesItTxt.Text;
        }

        private void tabPane_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (modified && tabPane.SelectedIndex != 0)
            {
                MessageBox.Show("Sono state apportate modifiche non salvate ai dati");
                tabPane.SelectedIndex = 0;
                return;
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            // da eseguire nel thread della gui
            details = handler.loadItemDescription(codart + ".txt");
            loadField();
        }
    }
}
