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
    public partial class Scan : Form
    {
        private agapeDataSet.AGAPE_RFIDRow row;
        public Scan(agapeDataSet.AGAPE_RFIDRow row)
        {
            InitializeComponent();
            this.row = row;

            this.ordNumLabel.Text = row.NumeroOrdine;
            this.orderDateLabel.Text = row.DataOrdine.ToShortDateString();
            this.codArtLabel.Text = row.CodArt;
            this.descArtLabel.Text = row.DescrizioneArticolo;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DataEntry(row, dateTimePicker1.Value, this).Show();
        }

    }
}