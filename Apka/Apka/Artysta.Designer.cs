namespace Apka
{
    partial class Artysta
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
            this.wytworniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Apka.DataSet();
            this.artystaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artystaTableAdapter = new Apka.DataSetTableAdapters.artystaTableAdapter();
            this.wytworniaTableAdapter = new Apka.DataSetTableAdapters.wytworniaTableAdapter();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.cmbWytw = new System.Windows.Forms.ComboBox();
            this.imie = new System.Windows.Forms.Label();
            this.txtpseudo = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.Label();
            this.pseudo = new System.Windows.Forms.Label();
            this.dataur = new System.Windows.Forms.Label();
            this.idwytw = new System.Windows.Forms.Label();
            this.fKartystaartysta56E8E7ABBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.btnPopraw = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.artystaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artystaimieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artystanazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artystapseudonimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artystadataurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artystawytworniaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.artystaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artystaimieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artystanazwiskoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artystapseudonimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artystadataurDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artystawytworniaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.btnPokaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wytworniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artystaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKartystaartysta56E8E7ABBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // wytworniaBindingSource
            // 
            this.wytworniaBindingSource.DataMember = "wytwornia";
            this.wytworniaBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artystaBindingSource
            // 
            this.artystaBindingSource.DataMember = "artysta";
            this.artystaBindingSource.DataSource = this.dataSet;
            // 
            // artystaTableAdapter
            // 
            this.artystaTableAdapter.ClearBeforeFill = true;
            // 
            // wytworniaTableAdapter
            // 
            this.wytworniaTableAdapter.ClearBeforeFill = true;
            // 
            // txtImie
            // 
            this.txtImie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artystaBindingSource, "artysta_imie", true));
            this.txtImie.Location = new System.Drawing.Point(788, 82);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(139, 20);
            this.txtImie.TabIndex = 4;
            this.txtImie.TextChanged += new System.EventHandler(this.txtImie_TextChanged);
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artystaBindingSource, "artysta_nazwisko", true));
            this.txtNazwisko.Location = new System.Drawing.Point(788, 108);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(139, 20);
            this.txtNazwisko.TabIndex = 5;
            // 
            // cmbWytw
            // 
            this.cmbWytw.DataSource = this.wytworniaBindingSource;
            this.cmbWytw.DisplayMember = "wytwornia_nazwa";
            this.cmbWytw.FormattingEnabled = true;
            this.cmbWytw.Location = new System.Drawing.Point(788, 186);
            this.cmbWytw.Name = "cmbWytw";
            this.cmbWytw.Size = new System.Drawing.Size(139, 21);
            this.cmbWytw.TabIndex = 6;
            this.cmbWytw.ValueMember = "wytwornia_id";
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Location = new System.Drawing.Point(756, 85);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(26, 13);
            this.imie.TabIndex = 8;
            this.imie.Text = "Imię";
            // 
            // txtpseudo
            // 
            this.txtpseudo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artystaBindingSource, "artysta_pseudonim", true));
            this.txtpseudo.Location = new System.Drawing.Point(788, 134);
            this.txtpseudo.Name = "txtpseudo";
            this.txtpseudo.Size = new System.Drawing.Size(139, 20);
            this.txtpseudo.TabIndex = 9;
            // 
            // nazwisko
            // 
            this.nazwisko.AutoSize = true;
            this.nazwisko.Location = new System.Drawing.Point(729, 111);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(53, 13);
            this.nazwisko.TabIndex = 11;
            this.nazwisko.Text = "Nazwisko";
            // 
            // pseudo
            // 
            this.pseudo.AutoSize = true;
            this.pseudo.Location = new System.Drawing.Point(723, 137);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(59, 13);
            this.pseudo.TabIndex = 12;
            this.pseudo.Text = "Pseudonim";
            // 
            // dataur
            // 
            this.dataur.AutoSize = true;
            this.dataur.Location = new System.Drawing.Point(703, 163);
            this.dataur.Name = "dataur";
            this.dataur.Size = new System.Drawing.Size(79, 13);
            this.dataur.TabIndex = 13;
            this.dataur.Text = "Data urodzenia";
            // 
            // idwytw
            // 
            this.idwytw.AutoSize = true;
            this.idwytw.Location = new System.Drawing.Point(711, 189);
            this.idwytw.Name = "idwytw";
            this.idwytw.Size = new System.Drawing.Size(71, 13);
            this.idwytw.TabIndex = 14;
            this.idwytw.Text = "ID Wytwórnia";
            // 
            // fKartystaartysta56E8E7ABBindingSource
            // 
            this.fKartystaartysta56E8E7ABBindingSource.DataMember = "FK__artysta__artysta__56E8E7AB";
            this.fKartystaartysta56E8E7ABBindingSource.DataSource = this.wytworniaBindingSource;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(826, 300);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(102, 23);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj rekord";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artystaBindingSource, "artysta_data_ur", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(788, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(826, 329);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(102, 23);
            this.btnSzukaj.TabIndex = 22;
            this.btnSzukaj.Text = "Szukaj rekordu";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // btnPopraw
            // 
            this.btnPopraw.Location = new System.Drawing.Point(826, 358);
            this.btnPopraw.Name = "btnPopraw";
            this.btnPopraw.Size = new System.Drawing.Size(102, 23);
            this.btnPopraw.TabIndex = 21;
            this.btnPopraw.Text = "Popraw rekord";
            this.btnPopraw.UseVisualStyleBackColor = true;
            this.btnPopraw.Click += new System.EventHandler(this.btnPopraw_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(826, 387);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(101, 23);
            this.btnUsun.TabIndex = 18;
            this.btnUsun.Text = "Usuń rekord";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artystaBindingSource, "artysta_id", true));
            this.txtid.Location = new System.Drawing.Point(788, 56);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(138, 20);
            this.txtid.TabIndex = 19;
            // 
            // dg2
            // 
            this.dg2.AutoGenerateColumns = false;
            this.dg2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artystaidDataGridViewTextBoxColumn,
            this.artystaimieDataGridViewTextBoxColumn,
            this.artystanazwiskoDataGridViewTextBoxColumn,
            this.artystapseudonimDataGridViewTextBoxColumn,
            this.artystadataurDataGridViewTextBoxColumn,
            this.artystawytworniaidDataGridViewTextBoxColumn});
            this.dg2.DataSource = this.artystaBindingSource;
            this.dg2.Location = new System.Drawing.Point(25, 93);
            this.dg2.Name = "dg2";
            this.dg2.Size = new System.Drawing.Size(645, 317);
            this.dg2.TabIndex = 26;
            this.dg2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dg2_DataError);
            // 
            // artystaidDataGridViewTextBoxColumn
            // 
            this.artystaidDataGridViewTextBoxColumn.DataPropertyName = "artysta_id";
            this.artystaidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.artystaidDataGridViewTextBoxColumn.Name = "artystaidDataGridViewTextBoxColumn";
            this.artystaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.artystaidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // artystaimieDataGridViewTextBoxColumn
            // 
            this.artystaimieDataGridViewTextBoxColumn.DataPropertyName = "artysta_imie";
            this.artystaimieDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.artystaimieDataGridViewTextBoxColumn.Name = "artystaimieDataGridViewTextBoxColumn";
            // 
            // artystanazwiskoDataGridViewTextBoxColumn
            // 
            this.artystanazwiskoDataGridViewTextBoxColumn.DataPropertyName = "artysta_nazwisko";
            this.artystanazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.artystanazwiskoDataGridViewTextBoxColumn.Name = "artystanazwiskoDataGridViewTextBoxColumn";
            // 
            // artystapseudonimDataGridViewTextBoxColumn
            // 
            this.artystapseudonimDataGridViewTextBoxColumn.DataPropertyName = "artysta_pseudonim";
            this.artystapseudonimDataGridViewTextBoxColumn.HeaderText = "Pseudonim";
            this.artystapseudonimDataGridViewTextBoxColumn.Name = "artystapseudonimDataGridViewTextBoxColumn";
            // 
            // artystadataurDataGridViewTextBoxColumn
            // 
            this.artystadataurDataGridViewTextBoxColumn.DataPropertyName = "artysta_data_ur";
            this.artystadataurDataGridViewTextBoxColumn.HeaderText = "Data ur";
            this.artystadataurDataGridViewTextBoxColumn.Name = "artystadataurDataGridViewTextBoxColumn";
            // 
            // artystawytworniaidDataGridViewTextBoxColumn
            // 
            this.artystawytworniaidDataGridViewTextBoxColumn.DataPropertyName = "artysta_wytwornia_id";
            this.artystawytworniaidDataGridViewTextBoxColumn.DataSource = this.wytworniaBindingSource;
            this.artystawytworniaidDataGridViewTextBoxColumn.DisplayMember = "wytwornia_nazwa";
            this.artystawytworniaidDataGridViewTextBoxColumn.HeaderText = "ID Wytwórnia";
            this.artystawytworniaidDataGridViewTextBoxColumn.Name = "artystawytworniaidDataGridViewTextBoxColumn";
            this.artystawytworniaidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.artystawytworniaidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.artystawytworniaidDataGridViewTextBoxColumn.ValueMember = "wytwornia_id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Szukaj rekordu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(705, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Zapisz zmiany";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(705, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Usuń rekord";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dg1
            // 
            this.dg1.AutoGenerateColumns = false;
            this.dg1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artystaidDataGridViewTextBoxColumn1,
            this.artystaimieDataGridViewTextBoxColumn1,
            this.artystanazwiskoDataGridViewTextBoxColumn1,
            this.artystapseudonimDataGridViewTextBoxColumn1,
            this.artystadataurDataGridViewTextBoxColumn1,
            this.artystawytworniaidDataGridViewTextBoxColumn1});
            this.dg1.DataSource = this.artystaBindingSource;
            this.dg1.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dg1.Location = new System.Drawing.Point(25, 93);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(645, 317);
            this.dg1.TabIndex = 35;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // artystaidDataGridViewTextBoxColumn1
            // 
            this.artystaidDataGridViewTextBoxColumn1.DataPropertyName = "artysta_id";
            this.artystaidDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.artystaidDataGridViewTextBoxColumn1.Name = "artystaidDataGridViewTextBoxColumn1";
            this.artystaidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // artystaimieDataGridViewTextBoxColumn1
            // 
            this.artystaimieDataGridViewTextBoxColumn1.DataPropertyName = "artysta_imie";
            this.artystaimieDataGridViewTextBoxColumn1.HeaderText = "Imię";
            this.artystaimieDataGridViewTextBoxColumn1.Name = "artystaimieDataGridViewTextBoxColumn1";
            // 
            // artystanazwiskoDataGridViewTextBoxColumn1
            // 
            this.artystanazwiskoDataGridViewTextBoxColumn1.DataPropertyName = "artysta_nazwisko";
            this.artystanazwiskoDataGridViewTextBoxColumn1.HeaderText = "Nazwisko";
            this.artystanazwiskoDataGridViewTextBoxColumn1.Name = "artystanazwiskoDataGridViewTextBoxColumn1";
            // 
            // artystapseudonimDataGridViewTextBoxColumn1
            // 
            this.artystapseudonimDataGridViewTextBoxColumn1.DataPropertyName = "artysta_pseudonim";
            this.artystapseudonimDataGridViewTextBoxColumn1.HeaderText = "Pseudonim";
            this.artystapseudonimDataGridViewTextBoxColumn1.Name = "artystapseudonimDataGridViewTextBoxColumn1";
            // 
            // artystadataurDataGridViewTextBoxColumn1
            // 
            this.artystadataurDataGridViewTextBoxColumn1.DataPropertyName = "artysta_data_ur";
            this.artystadataurDataGridViewTextBoxColumn1.HeaderText = "Data ur";
            this.artystadataurDataGridViewTextBoxColumn1.Name = "artystadataurDataGridViewTextBoxColumn1";
            this.artystadataurDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // artystawytworniaidDataGridViewTextBoxColumn1
            // 
            this.artystawytworniaidDataGridViewTextBoxColumn1.DataPropertyName = "artysta_wytwornia_id";
            this.artystawytworniaidDataGridViewTextBoxColumn1.HeaderText = "ID Wytwornia";
            this.artystawytworniaidDataGridViewTextBoxColumn1.Name = "artystawytworniaidDataGridViewTextBoxColumn1";
            this.artystawytworniaidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(376, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 17);
            this.radioButton1.TabIndex = 37;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tryb połączeniowy";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(199, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 17);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tryb bezpołączeniowy";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(706, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 39;
            this.button5.Text = "Pokaż wszystko";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPokaz
            // 
            this.btnPokaz.Location = new System.Drawing.Point(827, 271);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(100, 23);
            this.btnPokaz.TabIndex = 40;
            this.btnPokaz.Text = "Pokaż wszystko";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // Artysta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Apka.Properties.Resources.gwiazdki1;
            this.ClientSize = new System.Drawing.Size(952, 436);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPopraw);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.idwytw);
            this.Controls.Add(this.dataur);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.pseudo);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtpseudo);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.cmbWytw);
            this.Name = "Artysta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artysta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Artysta_FormClosing);
            this.Load += new System.EventHandler(this.Artysta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wytworniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artystaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKartystaartysta56E8E7ABBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource artystaBindingSource;
        private DataSetTableAdapters.artystaTableAdapter artystaTableAdapter;
        private System.Windows.Forms.BindingSource wytworniaBindingSource;
        private DataSetTableAdapters.wytworniaTableAdapter wytworniaTableAdapter;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.ComboBox cmbWytw;
        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.TextBox txtpseudo;
        private System.Windows.Forms.Label nazwisko;
        private System.Windows.Forms.Label pseudo;
        private System.Windows.Forms.Label dataur;
        private System.Windows.Forms.Label idwytw;
        private System.Windows.Forms.BindingSource fKartystaartysta56E8E7ABBindingSource;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnPopraw;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystaidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystaimieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystanazwiskoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystapseudonimDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystadataurDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystawytworniaidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystaimieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystanazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystapseudonimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artystadataurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn artystawytworniaidDataGridViewTextBoxColumn;
    }
}