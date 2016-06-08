namespace Apka
{
    partial class Piosenka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Piosenka));
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.cmbAlbum = new System.Windows.Forms.ComboBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Apka.DataSet();
            this.txtSlowa = new System.Windows.Forms.TextBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPopraw = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.piosenkaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piosenkatytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piosenkaslowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piosenkaalbumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piosenkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piosenkaTableAdapter = new Apka.DataSetTableAdapters.piosenkaTableAdapter();
            this.albumTableAdapter = new Apka.DataSetTableAdapters.albumTableAdapter();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.piosenkaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piosenkatytulDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piosenkaslowaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piosenkaalbumidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPokaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piosenkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(719, 77);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(173, 20);
            this.txtid.TabIndex = 0;
            // 
            // txtTytul
            // 
            this.txtTytul.Location = new System.Drawing.Point(719, 103);
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(173, 20);
            this.txtTytul.TabIndex = 2;
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.DataSource = this.albumBindingSource;
            this.cmbAlbum.DisplayMember = "album_tytul";
            this.cmbAlbum.FormattingEnabled = true;
            this.cmbAlbum.Location = new System.Drawing.Point(719, 156);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.Size = new System.Drawing.Size(173, 21);
            this.cmbAlbum.TabIndex = 3;
            this.cmbAlbum.ValueMember = "album_id";
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
            // txtSlowa
            // 
            this.txtSlowa.Location = new System.Drawing.Point(719, 130);
            this.txtSlowa.Name = "txtSlowa";
            this.txtSlowa.Size = new System.Drawing.Size(173, 20);
            this.txtSlowa.TabIndex = 4;
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(777, 337);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(102, 23);
            this.btnUsun.TabIndex = 6;
            this.btnUsun.Text = "Usuń rekord";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(777, 250);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(102, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj rekord";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPopraw
            // 
            this.btnPopraw.Location = new System.Drawing.Point(777, 308);
            this.btnPopraw.Name = "btnPopraw";
            this.btnPopraw.Size = new System.Drawing.Size(102, 23);
            this.btnPopraw.TabIndex = 8;
            this.btnPopraw.Text = "Popraw rekord";
            this.btnPopraw.UseVisualStyleBackColor = true;
            this.btnPopraw.Click += new System.EventHandler(this.btnPopraw_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(777, 279);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(102, 23);
            this.btnSzukaj.TabIndex = 9;
            this.btnSzukaj.Text = "Szukaj rekordu";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(695, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(681, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tytuł";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(675, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Słowa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(663, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID Album";
            // 
            // dg1
            // 
            this.dg1.AutoGenerateColumns = false;
            this.dg1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.piosenkaidDataGridViewTextBoxColumn,
            this.piosenkatytulDataGridViewTextBoxColumn,
            this.piosenkaslowaDataGridViewTextBoxColumn,
            this.piosenkaalbumidDataGridViewTextBoxColumn});
            this.dg1.DataSource = this.piosenkaBindingSource;
            this.dg1.Location = new System.Drawing.Point(28, 85);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(444, 150);
            this.dg1.TabIndex = 14;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // piosenkaidDataGridViewTextBoxColumn
            // 
            this.piosenkaidDataGridViewTextBoxColumn.DataPropertyName = "piosenka_id";
            this.piosenkaidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.piosenkaidDataGridViewTextBoxColumn.Name = "piosenkaidDataGridViewTextBoxColumn";
            this.piosenkaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // piosenkatytulDataGridViewTextBoxColumn
            // 
            this.piosenkatytulDataGridViewTextBoxColumn.DataPropertyName = "piosenka_tytul";
            this.piosenkatytulDataGridViewTextBoxColumn.HeaderText = "Tytuł";
            this.piosenkatytulDataGridViewTextBoxColumn.Name = "piosenkatytulDataGridViewTextBoxColumn";
            // 
            // piosenkaslowaDataGridViewTextBoxColumn
            // 
            this.piosenkaslowaDataGridViewTextBoxColumn.DataPropertyName = "piosenka_slowa";
            this.piosenkaslowaDataGridViewTextBoxColumn.HeaderText = "Słowa";
            this.piosenkaslowaDataGridViewTextBoxColumn.Name = "piosenkaslowaDataGridViewTextBoxColumn";
            // 
            // piosenkaalbumidDataGridViewTextBoxColumn
            // 
            this.piosenkaalbumidDataGridViewTextBoxColumn.DataPropertyName = "piosenka_album_id";
            this.piosenkaalbumidDataGridViewTextBoxColumn.HeaderText = "ID Album";
            this.piosenkaalbumidDataGridViewTextBoxColumn.Name = "piosenkaalbumidDataGridViewTextBoxColumn";
            // 
            // piosenkaBindingSource
            // 
            this.piosenkaBindingSource.DataMember = "piosenka";
            this.piosenkaBindingSource.DataSource = this.dataSet;
            // 
            // piosenkaTableAdapter
            // 
            this.piosenkaTableAdapter.ClearBeforeFill = true;
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // dg2
            // 
            this.dg2.AutoGenerateColumns = false;
            this.dg2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.piosenkaidDataGridViewTextBoxColumn1,
            this.piosenkatytulDataGridViewTextBoxColumn1,
            this.piosenkaslowaDataGridViewTextBoxColumn1,
            this.piosenkaalbumidDataGridViewTextBoxColumn1});
            this.dg2.DataSource = this.piosenkaBindingSource;
            this.dg2.Location = new System.Drawing.Point(28, 85);
            this.dg2.Name = "dg2";
            this.dg2.Size = new System.Drawing.Size(444, 150);
            this.dg2.TabIndex = 15;
            this.dg2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dg2_DataError);
            // 
            // piosenkaidDataGridViewTextBoxColumn1
            // 
            this.piosenkaidDataGridViewTextBoxColumn1.DataPropertyName = "piosenka_id";
            this.piosenkaidDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.piosenkaidDataGridViewTextBoxColumn1.Name = "piosenkaidDataGridViewTextBoxColumn1";
            this.piosenkaidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // piosenkatytulDataGridViewTextBoxColumn1
            // 
            this.piosenkatytulDataGridViewTextBoxColumn1.DataPropertyName = "piosenka_tytul";
            this.piosenkatytulDataGridViewTextBoxColumn1.HeaderText = "Tytuł";
            this.piosenkatytulDataGridViewTextBoxColumn1.Name = "piosenkatytulDataGridViewTextBoxColumn1";
            // 
            // piosenkaslowaDataGridViewTextBoxColumn1
            // 
            this.piosenkaslowaDataGridViewTextBoxColumn1.DataPropertyName = "piosenka_slowa";
            this.piosenkaslowaDataGridViewTextBoxColumn1.HeaderText = "Słowa";
            this.piosenkaslowaDataGridViewTextBoxColumn1.Name = "piosenkaslowaDataGridViewTextBoxColumn1";
            // 
            // piosenkaalbumidDataGridViewTextBoxColumn1
            // 
            this.piosenkaalbumidDataGridViewTextBoxColumn1.DataPropertyName = "piosenka_album_id";
            this.piosenkaalbumidDataGridViewTextBoxColumn1.DataSource = this.albumBindingSource;
            this.piosenkaalbumidDataGridViewTextBoxColumn1.DisplayMember = "album_tytul";
            this.piosenkaalbumidDataGridViewTextBoxColumn1.HeaderText = "ID Album";
            this.piosenkaalbumidDataGridViewTextBoxColumn1.Name = "piosenkaalbumidDataGridViewTextBoxColumn1";
            this.piosenkaalbumidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.piosenkaalbumidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.piosenkaalbumidDataGridViewTextBoxColumn1.ValueMember = "album_id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Usuń rekord";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Szukaj rekordu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(655, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Zapisz zmiany";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(119, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 17);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tryb bezpołączeniowy";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(296, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 17);
            this.radioButton1.TabIndex = 41;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tryb połączeniowy";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Pokaż wszystko";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPokaz
            // 
            this.btnPokaz.Location = new System.Drawing.Point(778, 221);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(101, 23);
            this.btnPokaz.TabIndex = 44;
            this.btnPokaz.Text = "Pokaż wszystko";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // Piosenka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(904, 386);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPopraw);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSlowa);
            this.Controls.Add(this.cmbAlbum);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.txtid);
            this.Name = "Piosenka";
            this.Text = "Piosenka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Piosenka_FormClosing);
            this.Load += new System.EventHandler(this.Piosenka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piosenkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.ComboBox cmbAlbum;
        private System.Windows.Forms.TextBox txtSlowa;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPopraw;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource piosenkaBindingSource;
        private DataSetTableAdapters.piosenkaTableAdapter piosenkaTableAdapter;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private DataSetTableAdapters.albumTableAdapter albumTableAdapter;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.DataGridViewTextBoxColumn piosenkaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piosenkatytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piosenkaslowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piosenkaalbumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn piosenkaidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn piosenkatytulDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn piosenkaslowaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn piosenkaalbumidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPokaz;
    }
}