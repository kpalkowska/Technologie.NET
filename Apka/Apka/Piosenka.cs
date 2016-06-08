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

namespace Apka
{
    public partial class Piosenka : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=eos.inf.ug.edu.pl;User ID=kpalkowska;Password=224653");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public Piosenka()
        {
            InitializeComponent();
        }

        private void Piosenka_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;

            // TODO: This line of code loads data into the 'dataSet.album' table. You can move, or remove it, as needed.
            this.albumTableAdapter.Fill(this.dataSet.album);
            // TODO: This line of code loads data into the 'dataSet.piosenka' table. You can move, or remove it, as needed.
            this.piosenkaTableAdapter.Fill(this.dataSet.piosenka);

            txtid.Clear();
            txtTytul.Clear();
            txtSlowa.Clear();

            loadList();
            radioButton2.Checked = true;
        }

        private void loadList()
        {
            try
            {
                txtid.Clear();
                txtTytul.Clear();
                txtSlowa.Clear();

                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from piosenka", cn);
                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                dg1.DataSource = dt;

                cn.Close();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Nie można wyświetlić danych!");
            }
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = dataSet.Tables["Piosenka"].NewRow();
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlCommand sql = new SqlCommand("insert into piosenka(piosenka_tytul, piosenka_slowa, piosenka_album_id) VALUES('" + txtTytul.Text + "','" + txtSlowa.Text + "','"+cmbAlbum.SelectedValue+"')", cn);
                sql.ExecuteNonQuery();
                sql.Clone();
                MessageBox.Show("Rekord został dodany!");
                cn.Close();
                txtid.Text = "";
                txtTytul.Text = "";
                txtSlowa.Text = "";

                loadList();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Dodawanie rekordu nie powiodło się");
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            piosenkaTableAdapter.Update(dataSet.piosenka);
        }

        private void btnPopraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                cmd.CommandText = "update piosenka set piosenka_tytul='" +txtTytul.Text+ "',piosenka_slowa='" +txtSlowa.Text+ "',piosenka_album_id ='" +cmbAlbum.SelectedValue+ "' where piosenka_id="+dg1.SelectedRows[0].Cells[0].Value+"";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rekord został poprawiony!");
                cn.Close();
                loadList();
                txtid.Text = "";
                txtTytul.Text = "";
                txtSlowa.Text = "";
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Poprawianie rekordu nie powiodło się");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                txtid.Text = dg1.SelectedRows[0].Cells[0].Value.ToString();
                txtTytul.Text = dg1.SelectedRows[0].Cells[1].Value.ToString();
                txtSlowa.Text = dg1.SelectedRows[0].Cells[2].Value.ToString();
                cmbAlbum.Text = dg1.SelectedRows[0].Cells[3].Value.ToString();

                cn.Close();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Klikasz złe pola!");
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlCommand sql = new SqlCommand("delete from piosenka where piosenka_id= " + dg1.SelectedRows[0].Cells[0].Value + "", cn);
                sql.ExecuteNonQuery();
                MessageBox.Show("Rekord został usunięty!");
                cn.Close();
                loadList();
                txtid.Text = "";
                txtTytul.Text = "";
                txtSlowa.Text = "";
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Usuwanie rekordu nie powiodło się");
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                cmd.CommandText = "select * from piosenka where piosenka_id=' " + txtid.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dg1.DataSource = dt;
                cn.Close();
                loadList();
                txtid.Text = "";
                txtTytul.Text = "";
                txtSlowa.Text = "";
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Wyszukiwanie rekordu nie powiodło się");
            }
        }

        private void Piosenka_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie wprowadzone zmiany?", "UWAGA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                piosenkaTableAdapter.Update(dataSet.piosenka);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg2.CurrentRow != null)
                {
                    dg2.CurrentRow.Selected = true;
                    dg2.CurrentRow.Cells[1].Value = txtTytul.Text;
                    dg2.CurrentRow.Cells[2].Value = txtSlowa.Text;
                    dg2.CurrentRow.Cells[3].Value = cmbAlbum.SelectedValue;
                    this.piosenkaTableAdapter.Update(dataSet.piosenka);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Zapisywanie rekordu nie powiodło się");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchValue = txtid.Text;

            dg2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            piosenkaBindingSource.Filter = string.Format("{0} = '{1}'", "piosenka_id", searchValue);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    this.piosenkaTableAdapter.Update(this.dataSet.piosenka);
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
                btnDodaj.Enabled = true;
                btnPokaz.Enabled = false;
                btnPopraw.Enabled = true;
                btnSzukaj.Enabled = true;
                btnUsun.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                try
                {
                    this.piosenkaTableAdapter.Update(this.dataSet.piosenka);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zapisać zmian");
                }
                this.piosenkaTableAdapter.Fill(this.dataSet.piosenka);
                dg1.Visible = false;
                dg2.Visible = true;
                dg1.Enabled = false;
                dg2.Enabled = true;
                btnDodaj.Enabled = false;
                btnPokaz.Enabled = false;
                btnPopraw.Enabled = false;
                btnSzukaj.Enabled = false;
                btnUsun.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                try
                {
                    this.piosenkaTableAdapter.Update(this.dataSet.piosenka);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zapisać zmian");
                }
                this.piosenkaTableAdapter.Fill(this.dataSet.piosenka);
                dg1.Visible = false;
                dg2.Visible = true;
                dg1.Enabled = false;
                dg2.Enabled = true;
                btnPokaz.Enabled = false;
                btnDodaj.Enabled = false;
                btnPopraw.Enabled = false;
                btnSzukaj.Enabled = false;
                btnUsun.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else if (radioButton1.Checked == true)
            {
                try
                {
                    this.piosenkaTableAdapter.Update(this.dataSet.piosenka);
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
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            loadList();
            dg1.Refresh();
            dg2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            piosenkaBindingSource.RemoveFilter();
            dg1.Refresh();
            dg2.Refresh();
        }

        private void dg2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Nieprawidłowe dane!");
        }
    }
}
