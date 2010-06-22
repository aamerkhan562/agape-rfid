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
        // controllo se il file di descrizione .txt viene modificato e aggiorno i campi
        private readonly FileSystemWatcher watcher = new FileSystemWatcher();

        // 
        private Boolean modified = false;
        private DescriptionFileHandler handler;
        private ItemDescription details = null;
            
        // ---------------

        public Form1()
        {
            InitializeComponent();

            // init watcher
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += OnChanged;
            watcher.Path = agape_rfid_desktop.Properties.Resources.productDescriptionDataPath;
            watcher.IncludeSubdirectories = false;

            // init description file handler
            handler = new DescriptionFileHandler(agape_rfid_desktop.Properties.Resources.productDescriptionDataPath);
        }

        // ---------------------------------------------------------------------------------------------------------------------
        // EVENT HANDLERS

        // search button handler
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (this.searchTxt.Text == "")
            {
                // pianta una grana
                return;
            }

            if (!notifyUnsavedChangesAndUpdate()) // not saved changes in old item
            {
                return;
            }

            if (agapeTaggedItemsDS.TaggedItemsView.Rows.Count != 0) // found item
            {
                this.tabPane.Visible = true;

                watcher.EnableRaisingEvents = false;
                watcher.Filter = agapeTaggedItemsDS.TaggedItemsView.Rows[0][agapeTaggedItemsDS.TaggedItemsView.CodArtColumn] + ".txt";

                details = null;
                tabPane.SelectedIndex = 0;
            }
            else // nothin found 
            {
                this.tabPane.Visible = false;
                MessageBox.Show("Nessun ordine trovato con la matricola specificata");
            }
        }

        // save button handler
        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        // handler when changing pane in order to let the user save changed data
        private void tabPane_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabPane.SelectedIndex != 0 && !notifyUnsavedChangesAndUpdate()) // not saved changes in old item
            {
                tabPane.SelectedIndex = 0;
                return;
            }
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
                        updateDetails();
                        loadField();
                    }
                    catch (IOException) 
                    {
                        System.Windows.Forms.MessageBox.Show(this,"File di descrizione non trovato");
                        details = new ItemDescription();
                    }
                }
            }
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(agape_rfid_desktop.Properties.Resources.productDescriptionDataPath + "\\" + agapeTaggedItemsDS.TaggedItemsView.Rows[0][agapeTaggedItemsDS.TaggedItemsView.CodArtColumn] + ".txt");
            if (file.Exists)
            {
                System.Diagnostics.Process.Start(file.FullName);
                watcher.EnableRaisingEvents = true;
            }
        }

        // se cambio il campo, update details
        private void descEnTxt_Leave(object sender, EventArgs e)
        {
            this.details[Languages.EN].Description = this.descEnTxt.Text;
        }

        // se cambio il campo, update details
        private void valuesEnTxt_Leave(object sender, EventArgs e)
        {
            this.details[Languages.EN].Values = this.valuesEnTxt.Text;
        }

        // se cambio il campo, update details
        private void descItTxt_Leave(object sender, EventArgs e)
        {
            this.details[Languages.IT].Description = this.descItTxt.Text;
        }

        // se cambio il campo, update details
        private void valuesItTxt_Leave(object sender, EventArgs e)
        {
            this.details[Languages.IT].Values = this.valuesItTxt.Text;
        }

        private void picture_Click(object sender, EventArgs e)
        {
            if (details.PhotoPath != "")
            {
                System.Diagnostics.Process.Start(details.PhotoPath);
                watcher.EnableRaisingEvents = true;
            }
        }

        private void browseBtn_Click_1(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.photoPathTxt.Text = this.openFileDialog1.FileName;
            this.details.PhotoPath = this.openFileDialog1.FileName;
            this.picture.Image = new Bitmap(this.details.PhotoPath);
        }

        private void loadField()
        {
            this.descEnTxt.Text = details[Languages.EN].Description;
            this.descItTxt.Text = details[Languages.IT].Description;
            this.valuesEnTxt.Text = details[Languages.EN].Values;
            this.valuesItTxt.Text = details[Languages.IT].Values;
            this.photoPathTxt.Text = details.PhotoPath;
            this.picture.Image = details.Photo;
        }

        private Boolean checkOrderParameters()
        {
            if (this.codartTxt.Text == "" || this.descTxt.Text == "" || this.idTxt.Text == "")
                return false;
            return true;
        }

        private void recordModified(object sender, EventArgs e)
        {
            this.saveBtn.Enabled = true;
            this.modified = true;
        }

        // delegato per gestire la modifica del file .txt di descrizione
        // il contenuto della form viene aggiornato
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate () { // EDT
                updateDetails(); 
                loadField();
            });
        }

        private void saveChanges()
        {
            if (!checkOrderParameters())
            {
                this.errorLbl.Text = "Campi obbligori (*) mancanti o incorretti";
                return;
            }

            // updates view
            this.Validate();
            this.errorLbl.Text = "";

            // updates model
            this.bindingSource1.EndEdit();
            this.saveBtn.Enabled = false;
            this.modified = false;

            // load changes on db
            taggedItemsViewTableAdapter.Update(agapeTaggedItemsDS.TaggedItemsView); // on merc??
        }

        private void updateDetails() {
            details = handler.loadItemDescription(agapeTaggedItemsDS.TaggedItemsView.Rows[0][agapeTaggedItemsDS.TaggedItemsView.CodArtColumn] + ".txt");
            details.PhotoPath = agape_rfid_desktop.Properties.Resources.photoPath + "\\" + agapeTaggedItemsDS.TaggedItemsView.Rows[0][agapeTaggedItemsDS.TaggedItemsView.CodArtColumn] + ".png";
        }

        private Boolean notifyUnsavedChangesAndUpdate()
        {
            if (modified)
            {
                DialogResult res = MessageBox.Show("Sono state apportate modifiche non salvate ai dati.\nSalvare prima di procedere?", "Attenzione", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    saveChanges();
                }
                else if (res == DialogResult.Cancel)
                {
                    return false;
                }
            }

            // queries the db and updated the backed model
            taggedItemsViewTableAdapter.FillByCodMatricola(agapeTaggedItemsDS.TaggedItemsView, searchTxt.Text);
            // da scaricare ad un worker thread o MERC?

            this.saveBtn.Enabled = false;
            modified = false;

            return true;
        }

    }
}