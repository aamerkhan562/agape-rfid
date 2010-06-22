namespace agape_rfid_mobile
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agapeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cercaBtn
            // 
            this.cercaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cercaBtn.Location = new System.Drawing.Point(211, 3);
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
            this.orderNumTb.Size = new System.Drawing.Size(137, 23);
            this.orderNumTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
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
            this.dataGrid1.Location = new System.Drawing.Point(3, 77);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(280, 289);
            this.dataGrid1.TabIndex = 6;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.PrgArt);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.CodArt);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.CodRiv);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.CodCli);
            // 
            // PrgArt
            // 
            this.PrgArt.Format = "";
            this.PrgArt.FormatInfo = null;
            this.PrgArt.HeaderText = "Prg.Art.";
            this.PrgArt.MappingName = "ProgressivoArticolo";
            // 
            // CodArt
            // 
            this.CodArt.Format = "";
            this.CodArt.FormatInfo = null;
            this.CodArt.HeaderText = "Cod.Art.";
            this.CodArt.MappingName = "CodArt";
            // 
            // CodRiv
            // 
            this.CodRiv.Format = "";
            this.CodRiv.FormatInfo = null;
            this.CodRiv.HeaderText = "Cod.Riv.";
            this.CodRiv.MappingName = "CodRivenditore";
            // 
            // CodCli
            // 
            this.CodCli.Format = "";
            this.CodCli.FormatInfo = null;
            this.CodCli.HeaderText = "Cod.Cli.";
            this.CodCli.MappingName = "CodCliente";
            // 
            // itemsViewTableAdapter
            // 
            this.itemsViewTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(286, 493);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderNumTb);
            this.Controls.Add(this.cercaBtn);
            this.Name = "Form1";
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
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn PrgArt;
        private System.Windows.Forms.DataGridTextBoxColumn CodArt;
        private System.Windows.Forms.DataGridTextBoxColumn CodRiv;
        private System.Windows.Forms.DataGridTextBoxColumn CodCli;
    }
}

