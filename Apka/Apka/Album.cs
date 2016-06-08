using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Apka
{
    public partial class Album : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=eos.inf.ug.edu.pl;User ID=kpalkowska;Password=224653");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public Album()
        {
            InitializeComponent();
        }

        private void Album_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;

            // TODO: This line of code loads data into the 'dataSet.album' table. You can move, or remove it, as needed.
            this.albumTableAdapter.Fill(this.dataSet.album);

            txtid.Clear();
            txtTytul.Clear();
            picAlbum.Image = null;

            loadList();
            radioButton2.Checked = true;

        }

        private void loadList()
        {
            try
            {
                txtid.Clear();
                txtTytul.Clear();
                picAlbum.Image = null;

                if (cn.State != ConnectionState.Open)
                    cn.Open();
                dg1.RowTemplate.Height = 100;
                SqlCommand cmd = new SqlCommand("Select * from album", cn);
                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                dg1.DataSource = dt;
                dg1.Columns[3].Width = 150;
                for (int i = 0; i < dg1.Columns.Count; i++)
                    if (dg1.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dg1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }
                cn.Close();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Nie można wyświetlić danych!");
            }
        }

        private void btnWybierz_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "jpg|*.jpg";
                dlg.Title = "Wybierz okładkę albumu";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picAlbum.Image = Image.FromFile(dlg.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się załadować okładki");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = dataSet.Tables["Album"].NewRow();
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlCommand sql = new SqlCommand("insert into album(album_tytul, album_data_wyd, album_okladka) VALUES('" + txtTytul.Text + "','"+dateTimePicker1.Text+"', @img)", cn);
                MemoryStream stream = new MemoryStream();
                picAlbum.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] img = stream.ToArray();
                sql.Parameters.AddWithValue("@img", img);
                sql.ExecuteNonQuery();
                MessageBox.Show("Rekord został dodany!");
                cn.Close();
                txtid.Text = "";
                txtTytul.Text = "";

                loadList();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Dodawanie rekordu nie powiodło się");
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlCommand sql = new SqlCommand("delete from album where album_id= "+dg1.SelectedRows[0].Cells[0].Value+"", cn);
                sql.ExecuteNonQuery();
                MessageBox.Show("Rekord został usunięty!");
                cn.Close();
                loadList();
                txtid.Text = "";
                txtTytul.Text = "";
                picAlbum.Image = null;
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Usuwanie rekordu nie powiodło się (do albumu jest przypisana piosenka)");
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                dg1.RowTemplate.Height =  100;
                cmd.CommandText = "select * from album where album_id=' " + txtid.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dg1.DataSource = dt;
                dg1.Columns[3].Width = 150;
                cn.Close();
                loadList();
                txtid.Text = "";
                txtTytul.Text = "";
                picAlbum.Image = null;
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Wyszukiwanie rekordu nie powiodło się");
            }
        }

        private void btnPopraw_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = dataSet.Tables["Album"].NewRow();
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlCommand sql = new SqlCommand("Update album set album_tytul = '"+txtTytul.Text+"', album_data_wyd = '"+dateTimePicker1.Text+"', album_okladka = @img where album_id = "+dg1.SelectedRows[0].Cells[0].Value+"", cn);
                MemoryStream stream = new MemoryStream();
                picAlbum.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] img = stream.ToArray();
                sql.Parameters.AddWithValue("@img", img);
                sql.ExecuteNonQuery();
                MessageBox.Show("Rekord został poprawiony!");
                cn.Close();
                txtid.Text = "";
                txtTytul.Text = "";

                loadList();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Poprawianie rekordu nie powiodło się");
            }
       }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                txtid.Text = dg1.SelectedRows[0].Cells[0].Value.ToString();
                txtTytul.Text = dg1.SelectedRows[0].Cells[1].Value.ToString();
                dateTimePicker1.Text = dg1.SelectedRows[0].Cells[2].Value.ToString();

                SqlCommand cmd = new SqlCommand("Select album_okladka FROM album where album_id = " + dg1.SelectedRows[0].Cells[0].Value.ToString() + "", cn);
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                byte[] mydata = new byte[0];
                da.Fill(ds, "Album");
                DataRow myrow;
                myrow = ds.Tables["Album"].Rows[0];
                mydata = (byte[])myrow["album_okladka"];
                MemoryStream stream = new MemoryStream(mydata);
                picAlbum.Image = Image.FromStream(stream);

                cn.Close();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Klikasz złe pola!");
            }

        }

        private void Album_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie wprowadzone zmiany?", "UWAGA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                albumTableAdapter.Update(dataSet.album);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg2.CurrentRow != null)
                {
                    dg2.CurrentRow.Selected = true;
                    dg2.CurrentRow.Cells[1].Value = txtTytul.Text;
                    dg2.CurrentRow.Cells[2].Value = dateTimePicker1.Text;
                    this.albumTableAdapter.Update(dataSet.album);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Poprawianie rekordu nie powiodło się");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg2.CurrentRow != null)
                {
                    dg2.CurrentRow.Selected = true;
                    dg2.Rows.Remove(dg2.SelectedRows[0]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuwanie rekordu nie powiodło się");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchValue = txtid.Text;

            dg2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            albumBindingSource.Filter = string.Format("{0} = '{1}'", "album_id", searchValue);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                try
                {
                    this.albumTableAdapter.Update(this.dataSet.album);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zapisać zmian");
                }
                this.albumTableAdapter.Fill(this.dataSet.album);
                dg1.Visible = false;
                dg2.Visible = true;
                dg2.Columns[3].Width = 150;
                dg2.RowTemplate.Height = 100;

                for (int i = 0; i < dg1.Columns.Count; i++)
                    if (dg2.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dg1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }

                dg1.Enabled = false;
                dg2.Enabled = true;
                btnPokaz.Enabled = false;
                btnDodaj.Enabled = false;
                btnPopraw.Enabled = false;
                btnSzukaj.Enabled = false;
                btnUsun.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
            else if (radioButton1.Checked == true)
            {
                try
                {
                    this.albumTableAdapter.Update(this.dataSet.album);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zapisać zmian");
                }
                loadList();
                dg1.Visible = true;
                dg2.Visible = false;
                dg1.Enabled = true;
                dg2.Enabled = false;
                btnPokaz.Enabled = true;
                btnDodaj.Enabled = true;
                btnPopraw.Enabled = true;
                btnSzukaj.Enabled = true;
                btnUsun.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    this.albumTableAdapter.Update(this.dataSet.album);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zapisać zmian");
                }
                loadList();
                dg1.Visible = true;
                dg2.Visible = false;
                dg1.Enabled = true;
                dg2.Enabled = false;
                btnPokaz.Enabled = true;
                btnDodaj.Enabled = true;
                btnPopraw.Enabled = true;
                btnSzukaj.Enabled = true;
                btnUsun.Enabled = true;
                button4.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
            }
            else
            {
                try
                {
                    this.albumTableAdapter.Update(this.dataSet.album);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zapisać zmian");
                }
                this.albumTableAdapter.Fill(this.dataSet.album);
                dg1.Visible = false;
                dg2.Visible = true;
                dg2.Columns[3].Width = 150;
                dg2.RowTemplate.Height = 100;

                for (int i = 0; i < dg1.Columns.Count; i++)
                    if (dg2.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dg1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }

                dg1.Enabled = false;
                dg2.Enabled = true;
                btnPokaz.Enabled = false;
                btnDodaj.Enabled = false;
                btnPopraw.Enabled = false;
                btnSzukaj.Enabled = false;
                btnUsun.Enabled = false;
                button4.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            loadList();
            dg1.Refresh();
            dg2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            albumBindingSource.RemoveFilter();
            dg1.Refresh();
            dg2.Refresh();
        }

        private void dg2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Błędne dane!");
        }
        }
    }
