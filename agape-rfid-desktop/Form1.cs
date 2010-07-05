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
        private Boolean isDescriptionLoaded = false;
            
        // ---------------

        public Form1()
        {
            InitializeComponent();

            // check initial settings
            checkInitialSettings();

            // init description file handler
            handler = new DescriptionFileHandler();

            // init watcher
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += OnChanged;
            watcher.Path = agape_rfid_desktop.Properties.Settings.Default.productDescriptionDataPath;
            watcher.IncludeSubdirectories = false;
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

            if (agapeTaggedItemsDS.AGAPE_RFID_T.Rows.Count != 0) // found item
            {
                this.tabPane.Visible = true;

                this.saveBtn.Enabled = false;
                modified = false;

                updateDetails();
                loadField();

                watcher.EnableRaisingEvents = false;
                watcher.Filter = details.CodArt + ".txt";

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
                if (!isDescriptionLoaded)
                {
                    DialogResult res = MessageBox.Show("File di descrizione non trovato. Crearlo ora?","File non trovato",MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        System.IO.File.Copy(agape_rfid_desktop.Properties.Settings.Default.descTemplatePath, agape_rfid_desktop.Properties.Settings.Default.productDescriptionDataPath + "\\" + this.codartTxt.Text + ".txt");
                        loadDescriptionFile();
                    }
                    isDescriptionLoaded = true;
                }
            }
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            loadDescriptionFile();
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
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.photoPathTxt.Text = this.openFileDialog1.FileName;
                this.details.PhotoPath = this.openFileDialog1.FileName;
                this.picture.Image = new Bitmap(this.details.PhotoPath);
            }
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
            AGAPE_RFID_TTableAdapter.Update(agapeTaggedItemsDS.AGAPE_RFID_T);

            //
            updateDetails();
            loadField();

            watcher.EnableRaisingEvents = false;
            watcher.Filter = details.CodArt + ".txt";
        }

        private void updateDetails() {
            details = new ItemDescription();
            details.CodArt = this.codartTxt.Text;
            details.Product = this.descTxt.Text;
            details.SerialNumber = this.idTxt.Text;
            details.deliveryDate = this.datePicker.Value;
            details.Customer = agapeTaggedItemsDS.AGAPE_RFID_T.Rows[0][agapeTaggedItemsDS.AGAPE_RFID_T.AnagraficaClienteColumn] + "";
            details.Vendor = agapeTaggedItemsDS.AGAPE_RFID_T.Rows[0][agapeTaggedItemsDS.AGAPE_RFID_T.AnagraficaRivenditoreColumn] + "";
            try
            {
                handler.loadItemDescription(details, agapeTaggedItemsDS.AGAPE_RFID_T.Rows[0][agapeTaggedItemsDS.AGAPE_RFID_T.CodArtColumn] + ".txt");
                isDescriptionLoaded = true;
            }
            catch (Exception)
            {
                isDescriptionLoaded = false;
            }

           // details.PhotoPath = agape_rfid_desktop.Properties.Settings.Default.photoPath + "\\" + agapeTaggedItemsDS.AGAPE_RFID_T.Rows[0][agapeTaggedItemsDS.AGAPE_RFID_T.CodArtColumn] + ".jpg";
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
            AGAPE_RFID_TTableAdapter.FillByCodMatricola(agapeTaggedItemsDS.AGAPE_RFID_T, searchTxt.Text);
            // da scaricare ad un worker thread o MERC?

            this.saveBtn.Enabled = false;
            modified = false;

            return true;
        }

        private void checkInitialSettings()
        {
            DirectoryInfo dir = new DirectoryInfo(agape_rfid_desktop.Properties.Settings.Default.productDescriptionDataPath);
            if (!dir.Exists)
            {
                dir = new DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\agape-rfid\\desc");
                if (!dir.Exists) { dir.Create(); }
                agape_rfid_desktop.Properties.Settings.Default.productDescriptionDataPath = dir.FullName;
            }
            dir = new DirectoryInfo(agape_rfid_desktop.Properties.Settings.Default.photoPath);
            if (!dir.Exists)
            {
                dir = new DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\agape-rfid\\img");
                if (!dir.Exists) { dir.Create(); }
                agape_rfid_desktop.Properties.Settings.Default.photoPath = dir.FullName;
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (details != null)
            {
                CertificateHandler.createCertificate(details,this.itRbtn.Checked ? Languages.IT : Languages.EN);
                //CertificateHandler.giveItATry();
            }
        }

        private void loadDescriptionFile()
        {
            FileInfo file = new FileInfo(agape_rfid_desktop.Properties.Settings.Default.productDescriptionDataPath + "\\" + agapeTaggedItemsDS.AGAPE_RFID_T.Rows[0][agapeTaggedItemsDS.AGAPE_RFID_T.CodArtColumn] + ".txt");
            if (file.Exists)
            {
                System.Diagnostics.Process.Start(file.FullName);
                watcher.EnableRaisingEvents = true;
            }
        }
    }
}