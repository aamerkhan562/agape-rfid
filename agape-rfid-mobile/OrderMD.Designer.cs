namespace agape_rfid_mobile
{
    partial class OrderMD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cercaBtn = new System.Windows.Forms.Button();
            this.orderNumTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agapeDataSet = new agape_rfid_mobile.agapeDataSet();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.PrgArt = new System.Windows.Forms.DataGridTextBoxColumn();
            this.CodArt = new System.Windows.Forms.DataGridTextBoxColumn();
            this.CodRiv = new System.Windows.Forms.DataGridTextBoxColumn();
            this.CodCli = new System.Windows.Forms.DataGridTextBoxColumn();
            this.itemsViewTableAdapter = new agape_rfid_mobile.agapeDataSetTableAdapters.ItemsViewTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scanBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agapeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cercaBtn
            // 
            this.cercaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cercaBtn.Location = new System.Drawing.Point(163, 6);
            this.cercaBtn.Name = "cercaBtn";
            this.cercaBtn.Size = new System.Drawing.Size(72, 20);
            this.cercaBtn.TabIndex = 0;
            this.cercaBtn.Text = "Cerca";
            this.cercaBtn.Click += new System.EventHandler(this.cercaBtn_Click);
            // 
            // orderNumTb
            // 
            this.orderNumTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.orderNumTb.Location = new System.Drawing.Point(68, 3);
            this.orderNumTb.Name = "orderNumTb";
            this.orderNumTb.Size = new System.Drawing.Size(89, 23);
            this.orderNumTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.Text = "# Ordine";
            // 
            // itemsViewBindingSource
            // 
            this.itemsViewBindingSource.DataMember = "ItemsView";
            this.itemsViewBindingSource.DataSource = this.agapeDataSet;
            // 
            // agapeDataSet
            // 
            this.agapeDataSet.DataSetName = "agapeDataSet";
            this.agapeDataSet.Prefix = "";
            this.agapeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.DataSource = this.itemsViewBindingSource;
            this.dataGrid1.Location = new System.Drawing.Point(3, 62);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.Size = new System.Drawing.Size(233, 98);
            this.dataGrid1.TabIndex = 6;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.PrgArt);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.CodArt);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.CodRiv);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.CodCli);
            this.dataGridTableStyle1.MappingName = "itemsView";
            // 
            // PrgArt
            // 
            this.PrgArt.Format = "";
            this.PrgArt.FormatInfo = null;
            this.PrgArt.HeaderText = "Prg.Art.";
            this.PrgArt.MappingName = "ProgressivoArticolo";
            this.PrgArt.Width = 28;
            // 
            // CodArt
            // 
            this.CodArt.Format = "";
            this.CodArt.FormatInfo = null;
            this.CodArt.HeaderText = "Cod.Art.";
            this.CodArt.MappingName = "CodArt";
            this.CodArt.Width = 60;
            // 
            // CodRiv
            // 
            this.CodRiv.Format = "";
            this.CodRiv.FormatInfo = null;
            this.CodRiv.HeaderText = "Cod.Riv.";
            this.CodRiv.MappingName = "CodRivenditore";
            this.CodRiv.Width = 60;
            // 
            // CodCli
            // 
            this.CodCli.Format = "";
            this.CodCli.FormatInfo = null;
            this.CodCli.HeaderText = "Cod.Cli.";
            this.CodCli.MappingName = "CodCliente";
            this.CodCli.Width = 60;
            // 
            // itemsViewTableAdapter
            // 
            this.itemsViewTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.Text = "Data";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsViewBindingSource, "DescrizioneArticolo", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBox1.Location = new System.Drawing.Point(3, 186);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(233, 61);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.Text = "Descrizione";
            // 
            // scanBtn
            // 
            this.scanBtn.Enabled = false;
            this.scanBtn.Location = new System.Drawing.Point(164, 253);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(72, 20);
            this.scanBtn.TabIndex = 13;
            this.scanBtn.Text = "Scan";
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsViewBindingSource, "DataOrdine", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "d"));
            this.textBox2.Location = new System.Drawing.Point(68, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(89, 23);
            this.textBox2.TabIndex = 17;
            // 
            // OrderMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 280);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.scanBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderNumTb);
            this.Controls.Add(this.cercaBtn);
            this.Name = "OrderMD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agapeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cercaBtn;
        private System.Windows.Forms.TextBox orderNumTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dataGrid1;
        private agapeDataSet agapeDataSet;
        private System.Windows.Forms.BindingSource itemsViewBindingSource;
        private agape_rfid_mobile.agapeDataSetTableAdapters.ItemsViewTableAdapter itemsViewTableAdapter;
        private System.Windows.Forms.DataGridTextBoxColumn PrgArt;
        private System.Windows.Forms.DataGridTextBoxColumn CodArt;
        private System.Windows.Forms.DataGridTextBoxColumn CodRiv;
        private System.Windows.Forms.DataGridTextBoxColumn CodCli;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button scanBtn;
        private System.Windows.Forms.TextBox textBox2;
    }
}

