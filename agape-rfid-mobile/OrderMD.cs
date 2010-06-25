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
        public OrderMD()
        {
            InitializeComponent();
        }

        private void cercaBtn_Click(object sender, EventArgs e)
        {
            AGAPE_RFIDTableAdapter.FillByNumeroOrdine(agapeDataSet.AGAPE_RFID, orderNumTb.Text);
            scanBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agapeDataSet.ItemsView' table. You can move, or remove it, as needed.
            //this.itemsViewTableAdapter.Fill(this.agapeDataSet.ItemsView);
        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = ((DataRowView)agapeBindingSource.Current).Row;
            new Scan(dr).Show();
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