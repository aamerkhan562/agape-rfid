
namespace agape_rfid_desktop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPane = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.finalCustomerTxt = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agapeTaggedItemsDS = new agape_rfid_desktop.agapeTaggedItemsDS();
            this.label7 = new System.Windows.Forms.Label();
            this.vendorTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codartTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.browseItBtn = new System.Windows.Forms.Button();
            this.photoItTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureIt = new System.Windows.Forms.PictureBox();
            this.valuesItTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.descItTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.browseEnBtn = new System.Windows.Forms.Button();
            this.photoEnTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureEn = new System.Windows.Forms.PictureBox();
            this.valuesEnTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.descEnTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.printBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enRbtn = new System.Windows.Forms.RadioButton();
            this.itRbtn = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.taggedItemsViewTableAdapter = new agape_rfid_desktop.agapeTaggedItemsDSTableAdapters.TaggedItemsViewTableAdapter();
            this.groupBox1.SuspendLayout();
            this.tabPane.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agapeTaggedItemsDS)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIt)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEn)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.searchTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ricerca";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(341, 33);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(45, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Cerca";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(141, 35);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(168, 20);
            this.searchTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero matricola/serie:";
            // 
            // tabPane
            // 
            this.tabPane.Controls.Add(this.tabPage1);
            this.tabPane.Controls.Add(this.tabPage2);
            this.tabPane.Controls.Add(this.tabPage3);
            this.tabPane.Location = new System.Drawing.Point(12, 104);
            this.tabPane.Name = "tabPane";
            this.tabPane.SelectedIndex = 0;
            this.tabPane.Size = new System.Drawing.Size(547, 339);
            this.tabPane.TabIndex = 1;
            this.tabPane.Visible = false;
            this.tabPane.SelectedIndexChanged += new System.EventHandler(this.tabPane_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorLbl);
            this.tabPage1.Controls.Add(this.saveBtn);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.finalCustomerTxt);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.vendorTxt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.datePicker);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.idTxt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.descTxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.codartTxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ordine";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(6, 289);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 15;
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(435, 284);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(96, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Salva modifiche";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "(*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "(*)";
            // 
            // finalCustomerTxt
            // 
            this.finalCustomerTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "AnagraficaCliente", true));
            this.finalCustomerTxt.Location = new System.Drawing.Point(158, 242);
            this.finalCustomerTxt.Name = "finalCustomerTxt";
            this.finalCustomerTxt.Size = new System.Drawing.Size(142, 20);
            this.finalCustomerTxt.TabIndex = 11;
            this.finalCustomerTxt.TextChanged += new System.EventHandler(this.recordModified);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TaggedItemsView";
            this.bindingSource1.DataSource = this.agapeTaggedItemsDS;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            this.bindingSource1.DataMemberChanged += new System.EventHandler(this.bindingSource1_DataMemberChanged);
            // 
            // agapeTaggedItemsDS
            // 
            this.agapeTaggedItemsDS.DataSetName = "agapeTaggedItemsDS";
            this.agapeTaggedItemsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nome cliente finale:";
            // 
            // vendorTxt
            // 
            this.vendorTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "AnagraficaRivenditore", true));
            this.vendorTxt.Location = new System.Drawing.Point(158, 206);
            this.vendorTxt.Name = "vendorTxt";
            this.vendorTxt.Size = new System.Drawing.Size(142, 20);
            this.vendorTxt.TabIndex = 9;
            this.vendorTxt.TextChanged += new System.EventHandler(this.recordModified);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nome cliente/rivenditore:";
            // 
            // datePicker
            // 
            this.datePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "DataUscita", true));
            this.datePicker.Location = new System.Drawing.Point(158, 167);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 7;
            this.datePicker.ValueChanged += new System.EventHandler(this.recordModified);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data consegna/uscita:";
            // 
            // idTxt
            // 
            this.idTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CodMatricola", true));
            this.idTxt.Location = new System.Drawing.Point(158, 130);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(142, 20);
            this.idTxt.TabIndex = 5;
            this.idTxt.TextChanged += new System.EventHandler(this.recordModified);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero matricola/serie:";
            // 
            // descTxt
            // 
            this.descTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "DescrizioneArticolo", true));
            this.descTxt.Location = new System.Drawing.Point(158, 58);
            this.descTxt.Multiline = true;
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(350, 52);
            this.descTxt.TabIndex = 3;
            this.descTxt.TextChanged += new System.EventHandler(this.recordModified);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrizione:";
            // 
            // codartTxt
            // 
            this.codartTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agapeTaggedItemsDS, "TaggedItemsView.CodArt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.codartTxt.Location = new System.Drawing.Point(158, 20);
            this.codartTxt.Name = "codartTxt";
            this.codartTxt.Size = new System.Drawing.Size(142, 20);
            this.codartTxt.TabIndex = 1;
            this.codartTxt.TextChanged += new System.EventHandler(this.recordModified);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cod. articolo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.detailsBtn);
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dettagli aggiuntivi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(323, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Apri file in NotePad:";
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(429, 8);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(100, 23);
            this.detailsBtn.TabIndex = 2;
            this.detailsBtn.Text = "Modifica dettagli";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(9, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 269);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.browseItBtn);
            this.tabPage4.Controls.Add(this.photoItTxt);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.pictureIt);
            this.tabPage4.Controls.Add(this.valuesItTxt);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.descItTxt);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(516, 243);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Italiano";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // browseItBtn
            // 
            this.browseItBtn.Location = new System.Drawing.Point(271, 175);
            this.browseItBtn.Name = "browseItBtn";
            this.browseItBtn.Size = new System.Drawing.Size(56, 23);
            this.browseItBtn.TabIndex = 11;
            this.browseItBtn.Text = "Sfoglia";
            this.browseItBtn.UseVisualStyleBackColor = true;
            // 
            // photoItTxt
            // 
            this.photoItTxt.Location = new System.Drawing.Point(100, 177);
            this.photoItTxt.Name = "photoItTxt";
            this.photoItTxt.Size = new System.Drawing.Size(142, 20);
            this.photoItTxt.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Foto:";
            // 
            // pictureIt
            // 
            this.pictureIt.Location = new System.Drawing.Point(350, 154);
            this.pictureIt.Name = "pictureIt";
            this.pictureIt.Size = new System.Drawing.Size(100, 83);
            this.pictureIt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIt.TabIndex = 8;
            this.pictureIt.TabStop = false;
            // 
            // valuesItTxt
            // 
            this.valuesItTxt.Location = new System.Drawing.Point(100, 87);
            this.valuesItTxt.Multiline = true;
            this.valuesItTxt.Name = "valuesItTxt";
            this.valuesItTxt.Size = new System.Drawing.Size(350, 52);
            this.valuesItTxt.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Pregi/unicità:";
            // 
            // descItTxt
            // 
            this.descItTxt.Location = new System.Drawing.Point(100, 15);
            this.descItTxt.Multiline = true;
            this.descItTxt.Name = "descItTxt";
            this.descItTxt.Size = new System.Drawing.Size(350, 52);
            this.descItTxt.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Descrizione:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.browseEnBtn);
            this.tabPage5.Controls.Add(this.photoEnTxt);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.pictureEn);
            this.tabPage5.Controls.Add(this.valuesEnTxt);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.descEnTxt);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(516, 243);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Inglese";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // browseEnBtn
            // 
            this.browseEnBtn.Location = new System.Drawing.Point(269, 175);
            this.browseEnBtn.Name = "browseEnBtn";
            this.browseEnBtn.Size = new System.Drawing.Size(56, 23);
            this.browseEnBtn.TabIndex = 18;
            this.browseEnBtn.Text = "Sfoglia";
            this.browseEnBtn.UseVisualStyleBackColor = true;
            // 
            // photoEnTxt
            // 
            this.photoEnTxt.Location = new System.Drawing.Point(100, 177);
            this.photoEnTxt.Name = "photoEnTxt";
            this.photoEnTxt.Size = new System.Drawing.Size(142, 20);
            this.photoEnTxt.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Foto:";
            // 
            // pictureEn
            // 
            this.pictureEn.Location = new System.Drawing.Point(350, 154);
            this.pictureEn.Name = "pictureEn";
            this.pictureEn.Size = new System.Drawing.Size(100, 83);
            this.pictureEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEn.TabIndex = 15;
            this.pictureEn.TabStop = false;
            this.pictureEn.DoubleClick += new System.EventHandler(this.pictureEn_DoubleClick);
            // 
            // valuesEnTxt
            // 
            this.valuesEnTxt.Location = new System.Drawing.Point(100, 87);
            this.valuesEnTxt.Multiline = true;
            this.valuesEnTxt.Name = "valuesEnTxt";
            this.valuesEnTxt.Size = new System.Drawing.Size(350, 52);
            this.valuesEnTxt.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Pregi/unicità:";
            // 
            // descEnTxt
            // 
            this.descEnTxt.Location = new System.Drawing.Point(100, 15);
            this.descEnTxt.Multiline = true;
            this.descEnTxt.Name = "descEnTxt";
            this.descEnTxt.Size = new System.Drawing.Size(350, 52);
            this.descEnTxt.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Descrizione:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Localizzazione";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.printBtn);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(539, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stampa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(458, 124);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Stampa";
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enRbtn);
            this.groupBox2.Controls.Add(this.itRbtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 103);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selezione lingua";
            // 
            // enRbtn
            // 
            this.enRbtn.AutoSize = true;
            this.enRbtn.Location = new System.Drawing.Point(12, 62);
            this.enRbtn.Name = "enRbtn";
            this.enRbtn.Size = new System.Drawing.Size(59, 17);
            this.enRbtn.TabIndex = 1;
            this.enRbtn.Text = "Inglese";
            this.enRbtn.UseVisualStyleBackColor = true;
            // 
            // itRbtn
            // 
            this.itRbtn.AutoSize = true;
            this.itRbtn.Checked = true;
            this.itRbtn.Location = new System.Drawing.Point(12, 29);
            this.itRbtn.Name = "itRbtn";
            this.itRbtn.Size = new System.Drawing.Size(59, 17);
            this.itRbtn.TabIndex = 0;
            this.itRbtn.TabStop = true;
            this.itRbtn.Text = "Italiano";
            this.itRbtn.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // taggedItemsViewTableAdapter
            // 
            this.taggedItemsViewTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.tabPane);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "agape-rfid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPane.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agapeTaggedItemsDS)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIt)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEn)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TabControl tabPane;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codartTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox finalCustomerTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vendorTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox valuesItTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox descItTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox photoItTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureIt;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.TextBox photoEnTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureEn;
        private System.Windows.Forms.TextBox valuesEnTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox descEnTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseItBtn;
        private System.Windows.Forms.Button browseEnBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton enRbtn;
        private System.Windows.Forms.RadioButton itRbtn;
        private System.Windows.Forms.Button printBtn;
        private agapeTaggedItemsDS agapeTaggedItemsDS;
        private agape_rfid_desktop.agapeTaggedItemsDSTableAdapters.TaggedItemsViewTableAdapter taggedItemsViewTableAdapter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

