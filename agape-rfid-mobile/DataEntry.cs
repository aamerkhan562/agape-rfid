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
        private static bool openFlag = false;

        private static string keyANFCMAD = "A0A1A2A3A4A5";
        private static string keyANFCNDEF = "D3F7D3F7D3F7";
        private static string keyA = "FFFFFFFFFFFF";
        private static string keyB = "111111111111";
        private static string acsStandard = "FF078069";
        private string acsWriteProtected = "78778800";

        public DataEntry(agapeDataSet.AGAPE_RFIDRow row, DateTime exitDate, Scan scanForm)
        {
            InitializeComponent();
            this.row = row;
            this.exitDate = exitDate;
            this.scanForm = scanForm;

            this.KeyPreview = true;

            if (host == null)
                host = new ATHF_DLL_NET.C_HFHost(this);

            if(!openFlag)
                openFlag = host.AT570RFID_Port_Open();

            host.ActivateForm = this;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value = ++progressBar1.Value % progressBar1.Maximum;
        }

        private void DataEntry_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
        }

        private void smButton_Click(object sender, EventArgs e)
        {
            
            //timer1.Enabled = false;

            //updateDatabase(txtData.Text);
            //this.Close();
            //scanForm.Close();

            //string sh = stringToHex("www.google.com/12345");
            //host.AT570RFID_RF4_KeyLoad("04", "A", "1", "111111111111");
            //host.AT570RFID_RF4_Block_Write("01", "A", "1", "1BABABABABABABABABABABABABABABAB", (uint)32);
            //host.AT570RFID_RF4_Block_Write("02", "A", "1", "2BABABABABABABABABABABABABABABAB", (uint)32);
            //host.AT570RFID_RF4_Block_Write("03", "A", "1", "3BABABABABABABABABABABABABABABAB", (uint)32);
        }

        private void initCard_Click(object sender, EventArgs e)
        {
            int nblocks = 1;

            string tbData = keyA + acsStandard + keyB;

            int j = 0;
            for (int i = 7; j < nblocks; i += 4, j++)
            {
                host.AT570RFID_RF4_KeyLoad(i.ToString("X2"), "B", "1", keyB);
                host.AT570RFID_RF4_Block_Write(i.ToString("X2"), "B", "1", tbData, (uint)32);
            }
        }

        private void readUID()
        {
            host.AT570RFID_RF4_Read_UID();
        }

        private string stringToHex(string s)
        {
            UTF8Encoding enc = new UTF8Encoding();
            StringBuilder sb = new StringBuilder();
            byte[] chars = enc.GetBytes(s);
            foreach (byte c in chars)
            {
                sb.Append(String.Format("{0:X2}", c));
            }
            return sb.ToString();
        }

        private void writeUrl(string url)
        {
            int nblocks = url.Length / 16 + ((url.Length % 16 == 0) ? 0 : 1);
            url = url.PadRight(nblocks * 16);
            
            string ws = stringToHex(url);

            int i = 4;
            int j = 0;
            for (; j < nblocks; i += 1)
            {
                host.AT570RFID_RF4_KeyLoad(i.ToString("X2"), "A", "1", keyA);
                for (; j < nblocks && i % 4 < 3; i++)
                {
                    host.AT570RFID_RF4_Block_Write(i.ToString("X2"), "A", "1", ws.Substring(j*32, 32), Convert.ToUInt32(32));
                    j++;
                }
                string tbData = keyA + acsWriteProtected + keyB;

                host.AT570RFID_RF4_Block_Write(i.ToString("X2"), "A", "1", tbData, Convert.ToUInt32(32));
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            // UID
            if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F7)
                readUID();

            base.OnKeyDown(e);
        }

        private void updateDatabase(string uid)
        {
            DialogResult dr = DialogResult.OK;
            do
            {
                try
                {
                    int count = AGAPE_RFID_TTableAdapter1.GetDataByKey(row.NumeroOrdine, row.DataOrdine, row.ProgressivoArticolo).Count;
                    if(count==0)
                        AGAPE_RFID_TTableAdapter1.Insert(row.NumeroOrdine, row.DataOrdine, row.ProgressivoArticolo, row.CodArt, row.DescrizioneArticolo, row.CodRivenditore, row.AnagraficaRivenditore, row.CodCliente, row.AnagraficaCliente, uid, exitDate);
                    else
                        AGAPE_RFID_TTableAdapter1.Update(row.NumeroOrdine, row.DataOrdine, row.ProgressivoArticolo, row.CodArt, row.DescrizioneArticolo, row.CodRivenditore, row.AnagraficaRivenditore, row.CodCliente, row.AnagraficaCliente, uid, exitDate, row.NumeroOrdine, row.DataOrdine, row.ProgressivoArticolo);
                }
                catch (Exception)
                {
                    dr = MessageBox.Show(
                        "Error saving on DB",
                        "Error",
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
            this.txtData.Text = data;
            if (data!= null && data != "" && data != "None" && data.Substring(0, 2) != "ER" && data.Substring(0, 2) != "OK")
            {
                updateDatabase(data);
                writeUrl("www.porcoilmondochecciosottoipiedi.it");

                ATHF_DLL_NET.C_HFHost.PlaySuccess();

                return;
            }
            ATHF_DLL_NET.C_HFHost.PlayFail();
        }

        #endregion

    }
}