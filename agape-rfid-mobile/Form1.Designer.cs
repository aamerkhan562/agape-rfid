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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.cercaBtn = new System.Windows.Forms.Button();
            this.orderNumTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cercaBtn
            // 
            this.cercaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cercaBtn.Location = new System.Drawing.Point(353, 3);
            this.cercaBtn.Name = "cercaBtn";
            this.cercaBtn.Size = new System.Drawing.Size(72, 20);
            this.cercaBtn.TabIndex = 0;
            this.cercaBtn.Text = "Cerca";
            this.cercaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderNumTb
            // 
            this.orderNumTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.orderNumTb.Location = new System.Drawing.Point(68, 3);
            this.orderNumTb.Name = "orderNumTb";
            this.orderNumTb.Size = new System.Drawing.Size(279, 23);
            this.orderNumTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.Text = "# Ordine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(428, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderNumTb);
            this.Controls.Add(this.cercaBtn);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cercaBtn;
        private System.Windows.Forms.TextBox orderNumTb;
        private System.Windows.Forms.Label label1;
    }
}

