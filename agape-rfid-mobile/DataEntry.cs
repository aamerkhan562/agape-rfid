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
    public enum Status
    {
        InitKeyLoad,
        InitWrite,
        ReadUid,
        KeyLoad,
        WriteUrl,
        WriteDB
    }

    public partial class DataEntry : Form, ATHF_DLL_NET.I_HFHost
    {
        private agapeDataSet.AGAPE_RFIDRow row;
        private DateTime exitDate;
        private Scan scanForm;

        private Status status;
        private string[] preparedData;

        private static ATHF_DLL_NET.C_HFHost host;
        private static bool openFlag = false;

        private static string keyANFCMAD = "A0A1A2A3A4A5";
        private static string keyANFCNDEF = "D3F7D3F7D3F7";
        private static string keyA = "FFFFFFFFFFFF";
        private static string keyB = "111111111111";
        private static string acsStandard = "FF078069";
        private static string acsWriteProtected = "78778800";

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

            this.currentRetries = 0;
            this.currentBlock = 0;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            this.Hide();
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
            currentBlock = 3;
            status = Status.InitKeyLoad;

            initKeyLoad(currentBlock);
            /*
            string tbData = keyA + acsStandard + keyB;

            int j = 0;
            for (int i = 3; j < nblocks; i += 4, j++)
            {
                
                host.AT570RFID_RF4_Block_Write(i.ToString("X2"), "B", "1", tbData, (uint)32);
            }
            */
        }

        private void initKeyLoad(int currentBlock)
        {
            host.AT570RFID_RF4_KeyLoad((currentBlock).ToString("X2"), "B", "1", keyB);
        }

        private void initWrite(int currentBlock)
        {
            string tbData = keyA + acsStandard + keyB;
            host.AT570RFID_RF4_Block_Write((currentBlock).ToString("X2"), "B", "1", tbData, Convert.ToUInt32(32));
        }

        private void cancButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
            scanForm.Hide();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F7)
            {
                status = Status.ReadUid;
                preparedData = prepareData("porcoilmondochecciosottoipiedi.it/index.asp&artNum=10");
                currentRetries = 0;
                currentBlock = 0;
                // UID
                readUID();
            }

            base.OnKeyDown(e);
        }

        private string[] prepareData(string url)
        {
            string encodedData = NFCStandarForMifare.encodeURI(URIPrefix.HTTP_WWW, url);

            int tlvBlocks = encodedData.Length/32;

            if (encodedData.Length % 32 > 0)
                tlvBlocks++;

            encodedData = encodedData.PadRight(tlvBlocks * 32, '0');
            int dataBlocks = (tlvBlocks / 3) * 4 + ((tlvBlocks % 3 == 0) ? 0 : 1)*4;

            string[] nfcData = new string[dataBlocks];

            for (int i=0; i < dataBlocks/4; i++)
            {
                int j = 0;
                for (; j < 3 ; j++)
                {
                    if ((i * 3 + j) * 32 < encodedData.Length)
                        nfcData[i * 4 + j] = encodedData.Substring((i * 3 + j) * 32, 32);
                    else
                        nfcData[i * 4 + j] = "00000000000000000000000000000000";
                }
                nfcData[i * 4 + j] = keyANFCNDEF + acsWriteProtected + keyB;
            }

            string[] madData = NFCStandarForMifare.encodeMAD(keyB);

            string[] data = new string[nfcData.Length + madData.Length];

            int k = 0;
            for (int i = 0; i < madData.Length; i++, k++)
                data[k] = madData[i];
            for (int i = 0; i < nfcData.Length; i++, k++)
                data[k] = nfcData[i];

            return data;
        }

        private void readUID()
        {
            host.AT570RFID_RF4_Read_UID();
        }

        private void keyLoad(int currentBlock)
        {
            host.AT570RFID_RF4_KeyLoad((currentBlock + 1).ToString("X2"), "A", "1", keyA);
        }

        private void writeUrl(int currentBlock)
        {
            host.AT570RFID_RF4_Block_Write((currentBlock+1).ToString("X2"), "A", "1", preparedData[currentBlock], Convert.ToUInt32(32));

            /*
            int stringBlocks = computeBlocks(url);
            url = url.PadRight(stringBlocks * 16);
            int n = (stringBlocks / 3) * 4 + ((stringBlocks % 3 == 0) ? 0 : 1);

            string ws = stringToHex(url);

            int blockAddr = 4 + currentBlock;
            int writePermAddr = (blockAddr / 4) * 4 + 4;

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
            */
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

        #region I_HFHost Members

        private string currentUID;
        private int currentBlock;
        private int currentRetries;

        private static int MAX_RETRIES = 3;

        public void GetMemoryData(string data)
        {
            this.txtData.Text = data;

            if (status == Status.InitKeyLoad)
            {
                if (data != null && data == "OK")
                {
                    status = Status.InitWrite;
                    initWrite(currentBlock);
                    return;
                }
                else if (currentRetries < MAX_RETRIES)
                {
                    status = Status.InitWrite;
                    initWrite(currentBlock);
                    return;
                }
            }
            else if(status == Status.InitWrite)
            {
                if (data != null && data == "OK")
                {
                    if (currentBlock == 19)
                    {
                        ATHF_DLL_NET.C_HFHost.PlaySuccess();
                        return;
                    }
                    else
                    {
                        currentRetries = 0;
                        currentBlock+=4;
                        status = Status.InitKeyLoad;
                        initKeyLoad(currentBlock);
                        return;
                    }
                }
                else if (currentRetries < MAX_RETRIES)
                {
                    status = Status.InitKeyLoad;
                    initKeyLoad(currentBlock);
                    currentRetries++;
                    return;
                }
            }
            else if (status == Status.ReadUid)
            {
                if(data!= null && data != "" && data != "None" )//&& data.Substring(0, 2) != "ER" && data.Substring(0, 2) != "OK")
                {
                    currentUID = data;
                    status = Status.KeyLoad;
                    keyLoad(currentBlock);
                    currentRetries=0;
                    return;
                }
                else if (currentRetries < MAX_RETRIES)
                {
                    readUID();
                    currentRetries++;
                    return;
                }
            }
            else if (status == Status.KeyLoad)
            {
                if (data != null && data == "OK")
                {
                    status = Status.WriteUrl;
                    writeUrl(currentBlock);
                    return;
                }
                else if (currentRetries < MAX_RETRIES)
                {
                    status = Status.WriteUrl;
                    writeUrl(currentBlock);
                    return;
                }
            }
            else if(status == Status.WriteUrl)
            {
                if (data != null && data == "OK")
                {
                    if (currentBlock == preparedData.Length-1)
                    {
                        status = Status.WriteDB;
                        updateDatabase(currentUID);
                        ATHF_DLL_NET.C_HFHost.PlaySuccess();
                        return;
                    }
                    else
                    {
                        currentRetries = 0;
                        currentBlock++;
                        status = Status.KeyLoad;
                        keyLoad(currentBlock);
                        return;
                    }
                }
                else if (currentRetries < MAX_RETRIES)
                {
                    status = Status.KeyLoad;
                    keyLoad(currentBlock);
                    currentRetries++;
                    return;
                }
            }     
            ATHF_DLL_NET.C_HFHost.PlayFail();
        }

        #endregion

    }
}