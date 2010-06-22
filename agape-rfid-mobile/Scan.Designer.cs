namespace agape_rfid_mobile
{
    partial class Scan
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
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.ordNumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.codArtLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.descArtLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.Text = "Prodotto selezionato:";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(65, 20);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Indietro";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ordNumLabel
            // 
            this.ordNumLabel.Location = new System.Drawing.Point(120, 46);
            this.ordNumLabel.Name = "ordNumLabel";
            this.ordNumLabel.Size = new System.Drawing.Size(116, 20);
            this.ordNumLabel.Text = "label2";
            this.ordNumLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.Text = "Numero Ordine";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.Text = "Data Ordine";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.Location = new System.Drawing.Point(120, 66);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(116, 20);
            this.orderDateLabel.Text = "label5";
            this.orderDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.Text = "Codice Articolo";
            // 
            // codArtLabel
            // 
            this.codArtLabel.Location = new System.Drawing.Point(120, 86);
            this.codArtLabel.Name = "codArtLabel";
            this.codArtLabel.Size = new System.Drawing.Size(116, 20);
            this.codArtLabel.Text = "label7";
            this.codArtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(4, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.Text = "Descrizione Articolo:";
            // 
            // descArtLabel
            // 
            this.descArtLabel.Location = new System.Drawing.Point(4, 126);
            this.descArtLabel.Name = "descArtLabel";
            this.descArtLabel.Size = new System.Drawing.Size(232, 49);
            this.descArtLabel.Text = "label9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Avanti";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 24);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.Text = "Data di uscita";
            // 
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descArtLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.codArtLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ordNumLabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Name = "Scan";
            this.Text = "Scan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label ordNumLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label codArtLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label descArtLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}