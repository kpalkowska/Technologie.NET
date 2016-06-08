namespace Apka
{
    partial class Wytwornia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wytwornia));
            this.btnPopraw = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.wytworniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Apka.DataSet();
            this.txtnazwa = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.wytworniaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wytwornianazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wytworniaTableAdapter = new Apka.DataSetTableAdapters.wytworniaTableAdapter();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnPokaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wytworniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPopraw
            // 
            this.btnPopraw.Location = new System.Drawing.Point(755, 299);
            this.btnPopraw.Name = "btnPopraw";
            this.btnPopraw.Size = new System.Drawing.Size(115, 23);
            this.btnPopraw.TabIndex = 0;
            this.btnPopraw.Text = "Popraw rekord";
            this.btnPopraw.UseVisualStyleBackColor = true;
            this.btnPopraw.Click += new System.EventHandler(this.btnPopraw_Click);
            // 
            // txtid
            // 
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wytworniaBindingSource, "wytwornia_id", true));
            this.txtid.Location = new System.Drawing.Point(697, 60);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(173, 20);
            this.txtid.TabIndex = 1;
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
            // txtnazwa
            // 
            this.txtnazwa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wytworniaBindingSource, "wytwornia_nazwa", true));
            this.txtnazwa.Location = new System.Drawing.Point(697, 86);
            this.txtnazwa.Name = "txtnazwa";
            this.txtnazwa.Size = new System.Drawing.Size(173, 20);
            this.txtnazwa.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(755, 241);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(115, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj rekord";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(755, 270);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(115, 23);
            this.btnSzukaj.TabIndex = 4;
            this.btnSzukaj.Text = "Szukaj rekordu";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(755, 328);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(115, 23);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usuń rekord";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // dg1
            // 
            this.dg1.AutoGenerateColumns = false;
            this.dg1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wytworniaidDataGridViewTextBoxColumn,
            this.wytwornianazwaDataGridViewTextBoxColumn});
            this.dg1.DataSource = this.wytworniaBindingSource;
            this.dg1.Location = new System.Drawing.Point(43, 67);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(293, 154);
            this.dg1.TabIndex = 7;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // wytworniaidDataGridViewTextBoxColumn
            // 
            this.wytworniaidDataGridViewTextBoxColumn.DataPropertyName = "wytwornia_id";
            this.wytworniaidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.wytworniaidDataGridViewTextBoxColumn.Name = "wytworniaidDataGridViewTextBoxColumn";
            this.wytworniaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wytwornianazwaDataGridViewTextBoxColumn
            // 
            this.wytwornianazwaDataGridViewTextBoxColumn.DataPropertyName = "wytwornia_nazwa";
            this.wytwornianazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.wytwornianazwaDataGridViewTextBoxColumn.Name = "wytwornianazwaDataGridViewTextBoxColumn";
            // 
            // wytworniaTableAdapter
            // 
            this.wytworniaTableAdapter.ClearBeforeFill = true;
            // 
            // dg2
            // 
            this.dg2.AutoGenerateColumns = false;
            this.dg2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dg2.DataSource = this.wytworniaBindingSource;
            this.dg2.Location = new System.Drawing.Point(43, 67);
            this.dg2.Name = "dg2";
            this.dg2.Size = new System.Drawing.Size(293, 154);
            this.dg2.TabIndex = 8;
            this.dg2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dg2_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "wytwornia_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "wytwornia_nazwa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Usuń rekord";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Szukaj rekordu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Pokaż wszystko";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(623, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Zapisz zmiany";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(153, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 17);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tryb bezpołączeniowy";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(330, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 17);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tryb połączeniowy";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnPokaz
            // 
            this.btnPokaz.Location = new System.Drawing.Point(755, 212);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(115, 23);
            this.btnPokaz.TabIndex = 41;
            this.btnPokaz.Text = "Pokaż wszystko";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // Wytwornia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(893, 379);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPopraw);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.txtnazwa);
            this.Controls.Add(this.txtid);
            this.Name = "Wytwornia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wytwórnia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wytwornia_FormClosing);
            this.Load += new System.EventHandler(this.Wytwornia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wytworniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPopraw;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnazwa;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.DataGridView dg1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource wytworniaBindingSource;
        private DataSetTableAdapters.wytworniaTableAdapter wytworniaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wytworniaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wytwornianazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnPokaz;
    }
}