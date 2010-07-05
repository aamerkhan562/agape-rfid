namespace agape_rfid_mobile
{
    partial class DataEntry
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
            this.backBtn = new System.Windows.Forms.Button();
            this.smButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cancButton = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.taggedItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destDataSet = new agape_rfid_mobile.destDataSet();
            this.AGAPE_RFID_TTableAdapter1 = new agape_rfid_mobile.destDataSetTableAdapters.AGAPE_RFID_TTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.taggedItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(65, 20);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Indietro";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // smButton
            // 
            this.smButton.Location = new System.Drawing.Point(3, 196);
            this.smButton.Name = "smButton";
            this.smButton.Size = new System.Drawing.Size(177, 71);
            this.smButton.TabIndex = 5;
            this.smButton.Text = "Scan";
            this.smButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(232, 20);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.Text = "Scansionare il tag...";
            // 
            // cancButton
            // 
            this.cancButton.Location = new System.Drawing.Point(170, 3);
            this.cancButton.Name = "cancButton";
            this.cancButton.Size = new System.Drawing.Size(65, 20);
            this.cancButton.TabIndex = 8;
            this.cancButton.Text = "Annulla";
            this.cancButton.Click += new System.EventHandler(this.cancButton_Click);
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(186, 196);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(49, 23);
            this.txtData.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Init";
            this.button1.Click += new System.EventHandler(this.initCard_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.messageLabel.Location = new System.Drawing.Point(3, 72);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(232, 20);
            // 
            // taggedItemsBindingSource
            // 
            this.taggedItemsBindingSource.DataMember = "AGAPE_RFID_T";
            this.taggedItemsBindingSource.DataSource = this.destDataSet;
            // 
            // destDataSet
            // 
            this.destDataSet.DataSetName = "destDataSet";
            this.destDataSet.Prefix = "";
            this.destDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AGAPE_RFID_TTableAdapter1
            // 
            this.AGAPE_RFID_TTableAdapter1.ClearBeforeFill = true;
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.ControlBox = false;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cancButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.smButton);
            this.Controls.Add(this.backBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataEntry";
            this.Text = "DataEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.taggedItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource taggedItemsBindingSource;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button smButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancButton;
        private destDataSet destDataSet;
        private System.Windows.Forms.TextBox txtData;
        private agape_rfid_mobile.destDataSetTableAdapters.AGAPE_RFID_TTableAdapter AGAPE_RFID_TTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label messageLabel;
    }
}