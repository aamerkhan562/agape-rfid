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
        private DataEntry entryForm;
        public Scan(agapeDataSet.AGAPE_RFIDRow row)
        {
            InitializeComponent();
            this.row = row;

            this.ordNumLabel.Text = row.NumeroOrdine;
            this.orderDateLabel.Text = row.DataOrdine.ToShortDateString();
            this.codArtLabel.Text = row.CodArt;
            this.descArtLabel.Text = row.DescrizioneArticolo;
        }

        public Scan()
        {
            InitializeComponent();
        }

        public void setData(agapeDataSet.AGAPE_RFIDRow row)
        {
            this.row = row;

            this.ordNumLabel.Text = row.NumeroOrdine;
            this.orderDateLabel.Text = row.DataOrdine.ToShortDateString();
            this.codArtLabel.Text = row.CodArt;
            this.descArtLabel.Text = row.DescrizioneArticolo;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entryForm = new DataEntry(row, dateTimePicker1.Value, this);
            entryForm.Show();
        }

    }
}