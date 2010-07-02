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
    public partial class OrderMD : Form
    {
        private Scan scanForm;
        public OrderMD()
        {
            InitializeComponent();
            scanForm = new Scan();
        }

        private void cercaBtn_Click(object sender, EventArgs e)
        {
            AGAPE_RFIDTableAdapter.FillByNumeroOrdine(agapeDataSet.AGAPE_RFID, orderNumTb.Text);
            scanBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data
            // this.AGAPE_RFIDTableAdapter.Fill(this.agapeDataSet.AGAPE_RFID);
        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            agapeDataSet.AGAPE_RFIDRow dr = (agapeDataSet.AGAPE_RFIDRow)((DataRowView)agapeBindingSource.Current).Row;
            scanForm.setData(dr);
            scanForm.Show();
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            int row = dataGrid1.CurrentCell.RowNumber;
            this.dataGrid1.Select(row);
            this.dataGrid1.CurrentCell = new DataGridCell(row, 0); ;
            scanBtn.Enabled = true;
        }
    }
}