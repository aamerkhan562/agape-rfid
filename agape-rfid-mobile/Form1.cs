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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cercaBtn_Click(object sender, EventArgs e)
        {
            itemsViewTableAdapter.FillByNumeroOrdine(agapeDataSet.ItemsView, orderNumTb.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agapeDataSet.ItemsView' table. You can move, or remove it, as needed.
            this.itemsViewTableAdapter.Fill(this.agapeDataSet.ItemsView);

        }
    }
}