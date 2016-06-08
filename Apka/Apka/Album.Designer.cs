namespace Apka
{
    partial class Album
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Album));
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Apka.DataSet();
            this.albumTableAdapter = new Apka.DataSetTableAdapters.albumTableAdapter();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnWybierz = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.albumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumtytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumdatawydDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumokladkaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPopraw = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.albumidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumtytulDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumdatawydDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumokladkaDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPokaz = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataMember = "album";
            this.albumBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // txtTytul
            // 
            this.txtTytul.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "album_tytul", true));
            this.txtTytul.Location = new System.Drawing.Point(787, 104);
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(173, 20);
            this.txtTytul.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "album_data_wyd", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(787, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnWybierz
            // 
            this.btnWybierz.Location = new System.Drawing.Point(844, 329);
            this.btnWybierz.Name = "btnWybierz";
            this.btnWybierz.Size = new System.Drawing.Size(115, 23);
            this.btnWybierz.TabIndex = 5;
            this.btnWybierz.Text = "Załaduj okładkę";
            this.btnWybierz.UseVisualStyleBackColor = true;
            this.btnWybierz.Click += new System.EventHandler(this.btnWybierz_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(845, 358);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(115, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj rekord";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(431, 396);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(115, 23);
            this.btnUsun.TabIndex = 7;
            this.btnUsun.Text = "Usuń rekord";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // picAlbum
            // 
            this.picAlbum.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picAlbum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAlbum.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "album_okladka", true));
            this.picAlbum.Location = new System.Drawing.Point(787, 156);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(172, 167);
            this.picAlbum.TabIndex = 8;
            this.picAlbum.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "album_id", true));
            this.txtid.Location = new System.Drawing.Point(787, 78);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(173, 20);
            this.txtid.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(763, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(749, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tytuł";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(709, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data wydania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(732, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Okładka";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(310, 396);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(115, 23);
            this.btnSzukaj.TabIndex = 14;
            this.btnSzukaj.Text = "Szukaj rekordu";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // dg2
            // 
            this.dg2.AutoGenerateColumns = false;
            this.dg2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albumidDataGridViewTextBoxColumn,
            this.albumtytulDataGridViewTextBoxColumn,
            this.albumdatawydDataGridViewTextBoxColumn,
            this.albumokladkaDataGridViewImageColumn});
            this.dg2.DataSource = this.albumBindingSource;
            this.dg2.Location = new System.Drawing.Point(12, 78);
            this.dg2.Name = "dg2";
            this.dg2.Size = new System.Drawing.Size(511, 216);
            this.dg2.TabIndex = 20;
            this.dg2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dg2_DataError);
            // 
            // albumidDataGridViewTextBoxColumn
            // 
            this.albumidDataGridViewTextBoxColumn.DataPropertyName = "album_id";
            this.albumidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.albumidDataGridViewTextBoxColumn.Name = "albumidDataGridViewTextBoxColumn";
            this.albumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumtytulDataGridViewTextBoxColumn
            // 
            this.albumtytulDataGridViewTextBoxColumn.DataPropertyName = "album_tytul";
            this.albumtytulDataGridViewTextBoxColumn.HeaderText = "Tytuł Albumu";
            this.albumtytulDataGridViewTextBoxColumn.Name = "albumtytulDataGridViewTextBoxColumn";
            // 
            // albumdatawydDataGridViewTextBoxColumn
            // 
            this.albumdatawydDataGridViewTextBoxColumn.DataPropertyName = "album_data_wyd";
            this.albumdatawydDataGridViewTextBoxColumn.HeaderText = "Data wydania";
            this.albumdatawydDataGridViewTextBoxColumn.Name = "albumdatawydDataGridViewTextBoxColumn";
            // 
            // albumokladkaDataGridViewImageColumn
            // 
            this.albumokladkaDataGridViewImageColumn.DataPropertyName = "album_okladka";
            this.albumokladkaDataGridViewImageColumn.HeaderText = "Okładka";
            this.albumokladkaDataGridViewImageColumn.Name = "albumokladkaDataGridViewImageColumn";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            // 
            // btnPopraw
            // 
            this.btnPopraw.Location = new System.Drawing.Point(311, 367);
            this.btnPopraw.Name = "btnPopraw";
            this.btnPopraw.Size = new System.Drawing.Size(114, 23);
            this.btnPopraw.TabIndex = 25;
            this.btnPopraw.Text = "Popraw rekord";
            this.btnPopraw.UseVisualStyleBackColor = true;
            this.btnPopraw.Click += new System.EventHandler(this.btnPopraw_Click);
            // 
            // dg1
            // 
            this.dg1.AutoGenerateColumns = false;
            this.dg1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albumidDataGridViewTextBoxColumn1,
            this.albumtytulDataGridViewTextBoxColumn1,
            this.albumdatawydDataGridViewTextBoxColumn1,
            this.albumokladkaDataGridViewImageColumn1});
            this.dg1.DataSource = this.albumBindingSource;
            this.dg1.Location = new System.Drawing.Point(12, 78);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(511, 216);
            this.dg1.TabIndex = 26;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellClick);
            // 
            // albumidDataGridViewTextBoxColumn1
            // 
            this.albumidDataGridViewTextBoxColumn1.DataPropertyName = "album_id";
            this.albumidDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.albumidDataGridViewTextBoxColumn1.Name = "albumidDataGridViewTextBoxColumn1";
            this.albumidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // albumtytulDataGridViewTextBoxColumn1
            // 
            this.albumtytulDataGridViewTextBoxColumn1.DataPropertyName = "album_tytul";
            this.albumtytulDataGridViewTextBoxColumn1.HeaderText = "Tytuł Albumu";
            this.albumtytulDataGridViewTextBoxColumn1.Name = "albumtytulDataGridViewTextBoxColumn1";
            // 
            // albumdatawydDataGridViewTextBoxColumn1
            // 
            this.albumdatawydDataGridViewTextBoxColumn1.DataPropertyName = "album_data_wyd";
            this.albumdatawydDataGridViewTextBoxColumn1.HeaderText = "Data wydania";
            this.albumdatawydDataGridViewTextBoxColumn1.Name = "albumdatawydDataGridViewTextBoxColumn1";
            // 
            // albumokladkaDataGridViewImageColumn1
            // 
            this.albumokladkaDataGridViewImageColumn1.DataPropertyName = "album_okladka";
            this.albumokladkaDataGridViewImageColumn1.HeaderText = "Okładka";
            this.albumokladkaDataGridViewImageColumn1.Name = "albumokladkaDataGridViewImageColumn1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Zapisz zmiany";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Szukaj rekordu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Usuń rekord";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPokaz
            // 
            this.btnPokaz.Location = new System.Drawing.Point(432, 367);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(114, 23);
            this.btnPokaz.TabIndex = 31;
            this.btnPokaz.Text = "Pokaż wszystko";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Pokaż wszystko";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(134, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 17);
            this.radioButton2.TabIndex = 46;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tryb bezpołączeniowy";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(311, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 17);
            this.radioButton1.TabIndex = 45;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tryb połączeniowy";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(971, 434);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.btnPopraw);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.picAlbum);
            this.Controls.Add(this.btnWybierz);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTytul);
            this.Name = "Album";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Album_FormClosing);
            this.Load += new System.EventHandler(this.Album_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private DataSetTableAdapters.albumTableAdapter albumTableAdapter;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnWybierz;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.PictureBox picAlbum;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumtytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumdatawydDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn albumokladkaDataGridViewImageColumn;
        private System.Windows.Forms.Button btnPopraw;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumtytulDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumdatawydDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn albumokladkaDataGridViewImageColumn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;

    }
}