namespace agape_rfid_mobile
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.cercaBtn = new System.Windows.Forms.Button();
            this.orderNumTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.fillByNumeroOrdinePanel = new System.Windows.Forms.Panel();
            this.numeroOrdineLabel = new System.Windows.Forms.Label();
            this.numeroOrdineTextBox = new System.Windows.Forms.TextBox();
            this.fillByNumeroOrdineButton = new System.Windows.Forms.Button();
            this.agapeDataSet = new agape_rfid_mobile.agapeDataSet();
            this.itemsViewTableAdapter = new agape_rfid_mobile.agapeDataSetTableAdapters.ItemsViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewBindingSource)).BeginInit();
            this.fillByNumeroOrdinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agapeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cercaBtn
            // 
            this.cercaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cercaBtn.Location = new System.Drawing.Point(308, 3);
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
            this.orderNumTb.Size = new System.Drawing.Size(234, 23);
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
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.DataSource = this.itemsViewBindingSource;
            this.dataGrid1.Location = new System.Drawing.Point(3, 32);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(377, 288);
            this.dataGrid1.TabIndex = 4;
            // 
            // fillByNumeroOrdinePanel
            // 
            this.fillByNumeroOrdinePanel.AutoScroll = true;
            this.fillByNumeroOrdinePanel.Controls.Add(this.numeroOrdineLabel);
            this.fillByNumeroOrdinePanel.Controls.Add(this.numeroOrdineTextBox);
            this.fillByNumeroOrdinePanel.Controls.Add(this.fillByNumeroOrdineButton);
            this.fillByNumeroOrdinePanel.Location = new System.Drawing.Point(10, 330);
            this.fillByNumeroOrdinePanel.Name = "fillByNumeroOrdinePanel";
            this.fillByNumeroOrdinePanel.Size = new System.Drawing.Size(370, 81);
            // 
            // numeroOrdineLabel
            // 
            this.numeroOrdineLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.numeroOrdineLabel.Location = new System.Drawing.Point(8, 11);
            this.numeroOrdineLabel.Name = "numeroOrdineLabel";
            this.numeroOrdineLabel.Size = new System.Drawing.Size(119, 17);
            this.numeroOrdineLabel.Text = "Numero Ordine:";
            // 
            // numeroOrdineTextBox
            // 
            this.numeroOrdineTextBox.Location = new System.Drawing.Point(134, 8);
            this.numeroOrdineTextBox.Name = "numeroOrdineTextBox";
            this.numeroOrdineTextBox.Size = new System.Drawing.Size(100, 23);
            this.numeroOrdineTextBox.TabIndex = 1;
            // 
            // fillByNumeroOrdineButton
            // 
            this.fillByNumeroOrdineButton.Location = new System.Drawing.Point(8, 41);
            this.fillByNumeroOrdineButton.Name = "fillByNumeroOrdineButton";
            this.fillByNumeroOrdineButton.Size = new System.Drawing.Size(158, 20);
            this.fillByNumeroOrdineButton.TabIndex = 2;
            this.fillByNumeroOrdineButton.Text = "Fill By Numero Ordine:";
            this.fillByNumeroOrdineButton.Click += new System.EventHandler(this.fillByNumeroOrdineButton_Click);
            // 
            // agapeDataSet
            // 
            this.agapeDataSet.DataSetName = "agapeDataSet";
            this.agapeDataSet.Prefix = "";
            this.agapeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.ClientSize = new System.Drawing.Size(383, 455);
            this.Controls.Add(this.fillByNumeroOrdinePanel);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderNumTb);
            this.Controls.Add(this.cercaBtn);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsViewBindingSource)).EndInit();
            this.fillByNumeroOrdinePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agapeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cercaBtn;
        private System.Windows.Forms.TextBox orderNumTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.BindingSource itemsViewBindingSource;
        private agape_rfid_mobile.agapeDataSetTableAdapters.ItemsViewTableAdapter itemsViewTableAdapter;
        private agapeDataSet agapeDataSet;
        private System.Windows.Forms.Panel fillByNumeroOrdinePanel;
        private System.Windows.Forms.Label numeroOrdineLabel;
        private System.Windows.Forms.TextBox numeroOrdineTextBox;
        private System.Windows.Forms.Button fillByNumeroOrdineButton;
    }
}

