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
            this.timer1 = new System.Windows.Forms.Timer();
            this.cancButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.smButton.Location = new System.Drawing.Point(60, 152);
            this.smButton.Name = "smButton";
            this.smButton.Size = new System.Drawing.Size(99, 20);
            this.smButton.TabIndex = 5;
            this.smButton.Text = "SMB";
            this.smButton.Click += new System.EventHandler(this.smButton_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 11;
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
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.smButton);
            this.Controls.Add(this.backBtn);
            this.Name = "DataEntry";
            this.Text = "DataEntry";
            this.Load += new System.EventHandler(this.DataEntry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataEntry_KeyDown);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cancButton;
        private destDataSet destDataSet;
        private System.Windows.Forms.TextBox textBox1;
        private agape_rfid_mobile.destDataSetTableAdapters.AGAPE_RFID_TTableAdapter AGAPE_RFID_TTableAdapter1;
    }
}