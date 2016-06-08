namespace Apka
{
    partial class Albumy_artystow
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.btnPopraw = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAlbum = new System.Windows.Forms.ComboBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Apka.DataSet();
            this.cmbArtysta = new System.Windows.Forms.ComboBox();
            this.artystaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.albumyartystowalbumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumyartystowartystaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumyartystowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumy_artystowTableAdapter = new Apka.DataSetTableAdapters.albumy_artystowTableAdapter();
            this.albumTableAdapter = new Apka.DataSetTableAdapters.albumTableAdapter();
            this.artystaTableAdapter = new Apka.DataSetTableAdapters.artystaTableAdapter();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPokaz = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.albumyartystowalbumidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.albumyartystowartystaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artystaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumyartystowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(773, 310);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(107, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj rekord";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(773, 252);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(107, 23);
            this.btnSzukaj.TabIndex = 1;
            this.btnSzukaj.Text = "Szukaj rekordu";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // btnPopraw
            // 
            this.btnPopraw.Location = new System.Drawing.Point(773, 281);
            this.btnPopraw.Name = "btnPopraw";
            this.btnPopraw.Size = new System.Drawing.Size(107, 23);
            this.btnPopraw.TabIndex = 3;
            this.btnPopraw.Text = "Popraw rekord";
            this.btnPopraw.UseVisualStyleBackColor = true;
            this.btnPopraw.Click += new System.EventHandler(this.btnPopraw_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(773, 339);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(107, 23);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usuń rekord";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(655, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(652, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Artysta";
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.DataSource = this.albumBindingSource;
            this.cmbAlbum.DisplayMember = "album_tytul";
            this.cmbAlbum.FormattingEnabled = true;
            this.cmbAlbum.Location = new System.Drawing.Point(708, 70);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.Size = new System.Drawing.Size(172, 21);
            this.cmbAlbum.TabIndex = 9;
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
            // cmbArtysta
            // 
            this.cmbArtysta.DataSource = this.artystaBindingSource;
            this.cmbArtysta.DisplayMember = "artysta_pseudonim";
            this.cmbArtysta.FormattingEnabled = true;
            this.cmbArtysta.Location = new System.Drawing.Point(709, 108);
            this.cmbArtysta.Name = "cmbArtysta";
            this.cmbArtysta.Size = new System.Drawing.Size(172, 21);
            this.cmbArtysta.TabIndex = 10;
            this.cmbArtysta.ValueMember = "artysta_id";
            // 
            // artystaBindingSource
            // 
            this.artystaBindingSource.DataMember = "artysta";
            this.artystaBindingSource.DataSource = this.dataSet;
            // 
            // dg1
            // 
            this.dg1.AutoGenerateColumns = false;
            this.dg1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albumyartystowalbumidDataGridViewTextBoxColumn,
            this.albumyartystowartystaidDataGridViewTextBoxColumn});
            this.dg1.DataSource = this.albumyartystowBindingSource;
            this.dg1.Location = new System.Drawing.Point(56, 86);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(260, 150);
            this.dg1.TabIndex = 11;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // albumyartystowalbumidDataGridViewTextBoxColumn
            // 
            this.albumyartystowalbumidDataGridViewTextBoxColumn.DataPropertyName = "albumy_artystow_album_id";
            this.albumyartystowalbumidDataGridViewTextBoxColumn.HeaderText = "ID Album";
            this.albumyartystowalbumidDataGridViewTextBoxColumn.Name = "albumyartystowalbumidDataGridViewTextBoxColumn";
            // 
            // albumyartystowartystaidDataGridViewTextBoxColumn
            // 
            this.albumyartystowartystaidDataGridViewTextBoxColumn.DataPropertyName = "albumy_artystow_artysta_id";
            this.albumyartystowartystaidDataGridViewTextBoxColumn.HeaderText = "ID Artysta";
            this.albumyartystowartystaidDataGridViewTextBoxColumn.Name = "albumyartystowartystaidDataGridViewTextBoxColumn";
            // 
            // albumyartystowBindingSource
            // 
            this.albumyartystowBindingSource.DataMember = "albumy_artystow";
            this.albumyartystowBindingSource.DataSource = this.dataSet;
            // 
            // albumy_artystowTableAdapter
            // 
            this.albumy_artystowTableAdapter.ClearBeforeFill = true;
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // artystaTableAdapter
            // 
            this.artystaTableAdapter.ClearBeforeFill = true;
            // 
            // dg2
            // 
            this.dg2.AutoGenerateColumns = false;
            this.dg2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albumyartystowalbumidDataGridViewTextBoxColumn1,
            this.albumyartystowartystaidDataGridViewTextBoxColumn1});
            this.dg2.DataSource = this.albumyartystowBindingSource;
            this.dg2.Location = new System.Drawing.Point(56, 86);
            this.dg2.Name = "dg2";
            this.dg2.Size = new System.Drawing.Size(260, 150);
            this.dg2.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Zapisz zmiany";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Szukaj rekordu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(655, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Usuń rekord";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pokaż wszystko";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPokaz
            // 
            this.btnPokaz.Location = new System.Drawing.Point(774, 223);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(107, 23);
            this.btnPokaz.TabIndex = 15;
            this.btnPokaz.Text = "Pokaż wszystko";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(174, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 17);
            this.radioButton2.TabIndex = 44;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tryb bezpołączeniowy";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(351, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 17);
            this.radioButton1.TabIndex = 43;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tryb połączeniowy";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // albumyartystowalbumidDataGridViewTextBoxColumn1
            // 
            this.albumyartystowalbumidDataGridViewTextBoxColumn1.DataPropertyName = "albumy_artystow_album_id";
            this.albumyartystowalbumidDataGridViewTextBoxColumn1.DataSource = this.albumBindingSource;
            this.albumyartystowalbumidDataGridViewTextBoxColumn1.DisplayMember = "album_tytul";
            this.albumyartystowalbumidDataGridViewTextBoxColumn1.HeaderText = "ID Album";
            this.albumyartystowalbumidDataGridViewTextBoxColumn1.Name = "albumyartystowalbumidDataGridViewTextBoxColumn1";
            this.albumyartystowalbumidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.albumyartystowalbumidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.albumyartystowalbumidDataGridViewTextBoxColumn1.ValueMember = "album_id";
            // 
            // albumyartystowartystaidDataGridViewTextBoxColumn1
            // 
            this.albumyartystowartystaidDataGridViewTextBoxColumn1.DataPropertyName = "albumy_artystow_artysta_id";
            this.albumyartystowartystaidDataGridViewTextBoxColumn1.DataSource = this.artystaBindingSource;
            this.albumyartystowartystaidDataGridViewTextBoxColumn1.DisplayMember = "artysta_pseudonim";
            this.albumyartystowartystaidDataGridViewTextBoxColumn1.HeaderText = "ID Artysta";
            this.albumyartystowartystaidDataGridViewTextBoxColumn1.Name = "albumyartystowartystaidDataGridViewTextBoxColumn1";
            this.albumyartystowartystaidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.albumyartystowartystaidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.albumyartystowartystaidDataGridViewTextBoxColumn1.ValueMember = "artysta_id";
            // 
            // Albumy_artystow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apka.Properties.Resources.gwiazdki1;
            this.ClientSize = new System.Drawing.Size(893, 379);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPopraw);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.cmbArtysta);
            this.Controls.Add(this.cmbAlbum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Albumy_artystow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albumy_artystow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Albumy_artystow_FormClosing);
            this.Load += new System.EventHandler(this.Albumy_artystow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artystaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumyartystowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnPopraw;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAlbum;
        private System.Windows.Forms.ComboBox cmbArtysta;
        private System.Windows.Forms.DataGridView dg1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource albumyartystowBindingSource;
        private DataSetTableAdapters.albumy_artystowTableAdapter albumy_artystowTableAdapter;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private DataSetTableAdapters.albumTableAdapter albumTableAdapter;
        private System.Windows.Forms.BindingSource artystaBindingSource;
        private DataSetTableAdapters.artystaTableAdapter artystaTableAdapter;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumyartystowalbumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumyartystowartystaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewComboBoxColumn albumyartystowalbumidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn albumyartystowartystaidDataGridViewTextBoxColumn1;
    }
}