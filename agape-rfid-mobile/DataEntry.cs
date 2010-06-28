using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace agape_rfid_mobile
{
    public partial class DataEntry : Form , ATHF_DLL_NET.I_HFHost
    {
        private DataRow row;
        private DateTime exitDate;
        private Scan scanForm;

        public DataEntry(DataRow row, DateTime exitDate, Scan scanForm)
        {
            InitializeComponent();
            this.row = row;
            this.exitDate = exitDate;
            this.scanForm = scanForm;

            ATHF_DLL_NET.C_HFHost h = new ATHF_DLL_NET.C_HFHost(this);
            h.AT570RFID_RF4_Read_UID();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value = ++progressBar1.Value % progressBar1.Maximum;
        }

        private void DataEntry_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void smButton_Click(object sender, EventArgs e)
        {
            updateDatabase(textBox1.Text);
            timer1.Enabled = false;
            this.Close();
            scanForm.Close();
        }
   
        private void updateDatabase(string uid)
        {
            DialogResult dr = DialogResult.Retry;
            do
            {
                try
                {
                    AGAPE_RFID_TTableAdapter1.Insert((string)row["NumeroOrdine"], (DateTime)row["DataOrdine"], (string)row["ProgressivoArticolo"], (string)row["CodArt"], (string)row["DescrizioneArticolo"], (string)row["CodRivenditore"], (string)row["AnagraficaRivenditore"], (string)row["CodCliente"], (string)row["AnagraficaCliente"], uid, exitDate);
                }
                catch (Exception)
                {
                    dr = MessageBox.Show(
                        "Error saving on DB",
                        "",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                }
            } while (dr == DialogResult.Retry);
        }

        private void cancButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
            scanForm.Close();
        }


        #region I_HFHost Members

        public void GetMemoryData(string data)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void DataEntry_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Keypressed");
        }

    }
}