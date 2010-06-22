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
    public partial class DataEntry : Form
    {
        public DataEntry(DataRow row, String rfidId)
        {
            InitializeComponent();
        }
    }
}