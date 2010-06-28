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
        private agapeDataSet.AGAPE_RFIDRow row;
        private DateTime exitDate;
        private Scan scanForm;
        private static ATHF_DLL_NET.C_HFHost host;

        public DataEntry(agapeDataSet.AGAPE_RFIDRow row, DateTime exitDate, Scan scanForm)
        {
            InitializeComponent();
            this.row = row;
            this.exitDate = exitDate;
            this.scanForm = scanForm;

            if (host == null)
                host = new ATHF_DLL_NET.C_HFHost(this);
            host.AT570RFID_Port_Open();
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
            
            timer1.Enabled = false;

            host.AT570RFID_RF4_Read_UID();

            //updateDatabase(txtData.Text);
            //this.Close();
            //scanForm.Close();
        }
   
        private void updateDatabase(string uid)
        {
            DialogResult dr = DialogResult.Retry;
            do
            {
                try
                {
                    int count = AGAPE_RFID_TTableAdapter1.GetCountByKey(row.NumeroOrdine, row.DataOrdine.ToShortDateString(), row.ProgressivoArticolo).Count;
                    if(count==0)
                        AGAPE_RFID_TTableAdapter1.Insert(row.NumeroOrdine, row.DataOrdine, row.ProgressivoArticolo, row.CodArt, row.DescrizioneArticolo, row.CodRivenditore, row.AnagraficaRivenditore, row.CodCliente, row.AnagraficaCliente, uid, exitDate);
                    else
                        AGAPE_RFID_TTableAdapter1.Update(row.NumeroOrdine, row.DataOrdine, row.ProgressivoArticolo, row.CodArt, row.DescrizioneArticolo, row.CodRivenditore, row.AnagraficaRivenditore, row.CodCliente, row.AnagraficaCliente, uid, exitDate, row.NumeroOrdine, row.DataOrdine, row.ProgressivoArticolo);
                }
                catch (Exception ex)
                {
                    dr = MessageBox.Show(
                        "Error saving on DB",
                        ex.Message,
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
            if (data != "None")
            {
                this.txtData.Text = data;
                updateDatabase(data);

                ATHF_DLL_NET.C_HFHost.PlaySuccess();
            }
        }

        #endregion

    }
}