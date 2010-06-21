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
            this.itemsViewBindingSource.Filter = "NumeroOrdine='" + orderNumTb.Text+"'";
            this.itemsViewTableAdapter.Fill(this.agapeDataSet.ItemsView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fillByNumeroOrdineButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsViewTableAdapter.FillByNumeroOrdine(this.agapeDataSet.ItemsView, numeroOrdineTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}