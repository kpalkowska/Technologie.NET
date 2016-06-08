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
    public partial class Albumy_artystow : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=eos.inf.ug.edu.pl;User ID=kpalkowska;Password=224653");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public Albumy_artystow()
        {
            InitializeComponent();
        }

        private void Albumy_artystow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.artysta' table. You can move, or remove it, as needed.
            this.artystaTableAdapter.Fill(this.dataSet.artysta);
            // TODO: This line of code loads data into the 'dataSet.album' table. You can move, or remove it, as needed.
            this.albumTableAdapter.Fill(this.dataSet.album);
            cmd.Connection = cn;

            // TODO: This line of code loads data into the 'dataSet.albumy_artystow' table. You can move, or remove it, as needed.
            this.albumy_artystowTableAdapter.Fill(this.dataSet.albumy_artystow);

           
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.cmbAlbum, "Jeśli poprawiasz/wyszukujesz rekord nie zmieniaj wartości tego pola");

            loadList();
            radioButton2.Checked = true;

        }

        private void loadList()
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from albumy_artystow", cn);
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
                DataRow row = dataSet.Tables["Albumy_artystow"].NewRow();
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlCommand sql = new SqlCommand("insert into albumy_artystow(albumy_artystow_album_id, albumy_artystow_artysta_id) VALUES('" + cmbAlbum.SelectedValue + "', '"+cmbArtysta.SelectedValue+ "')", cn);
                sql.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("Rekord został dodany!");
                cn.Close();

                loadList();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Dodawanie rekordu nie powiodło się");
            }
        }

        private void btnPopraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg1.SelectedRows[0].Cells[0] != null)
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();
                    SqlCommand sql = new SqlCommand("Update albumy_artystow set albumy_artystow_artysta_id = '" + cmbArtysta.SelectedValue + "' where albumy_artystow_album_id = '"+dg1.SelectedRows[0].Cells[0].Value+"'", cn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Rekord został poprawiony!");
                    cn.Close();

                    loadList();
                }
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Poprawianie nie powiodło się");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                cmbAlbum.Text = dg1.SelectedRows[0].Cells[0].Value.ToString();
                cmbArtysta.Text = dg1.SelectedRows[0].Cells[1].Value.ToString();
                cn.Close();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Klikasz złe pola!");
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                        cn.Open();
                    cmd.CommandText = "select * from albumy_artystow where albumy_artystow_artysta_id=' "+cmbArtysta.SelectedValue+"'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dg2.DataSource = dt;
                    cn.Close();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Wyszukiwanie nie powiodło się");
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlCommand sql = new SqlCommand("delete from albumy_artystow where albumy_artystow_album_id= " + dg1.SelectedRows[0].Cells[0].Value + " and albumy_artystow_artysta_id = "+dg1.SelectedRows[0].Cells[1].Value+"", cn);
                sql.ExecuteNonQuery();
                MessageBox.Show("Rekord został usunięty!");
                cn.Close();
                loadList();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Usuwanie rekordu nie powiodło się");
            }
        }

        private void Albumy_artystow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie wprowadzone zmiany?", "UWAGA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                albumy_artystowTableAdapter.Update(dataSet.albumy_artystow);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchValue = cmbArtysta.SelectedValue.ToString();

            dg2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            albumyartystowBindingSource.Filter = string.Format("{0} = '{1}'", "albumy_artystow_artysta_id", searchValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg2.CurrentRow != null)
                {
                    dg2.CurrentRow.Selected = true;
                    dg2.CurrentRow.Cells[0].Value = cmbAlbum.SelectedValue;
                    dg2.CurrentRow.Cells[1].Value = cmbArtysta.SelectedValue;
                    this.albumy_artystowTableAdapter.Update(this.dataSet.albumy_artystow);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Poprawianie rekordu nie powiodło się");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            albumyartystowBindingSource.RemoveFilter();
            dg1.Refresh();
            dg2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg2.CurrentRow != null)
                {
                    dg2.CurrentRow.Selected = true;
                    dg2.Rows.Remove(dg1.SelectedRows[0]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuwanie rekordu nie powiodło się");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                try
                {
                    this.artystaTableAdapter.Update(this.dataSet.artysta);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zapisać zmian");
                }
                this.artystaTableAdapter.Fill(this.dataSet.artysta);
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
                    this.artystaTableAdapter.Update(this.dataSet.artysta);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    this.artystaTableAdapter.Update(this.dataSet.artysta);
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
                    this.artystaTableAdapter.Update(this.dataSet.artysta);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zapisać zmian");
                }
                this.artystaTableAdapter.Fill(this.dataSet.artysta);
                dg1.Visible = false;
                dg2.Visible = true;
                dg1.Enabled = false;
                dg2.Enabled = true;
                btnDodaj.Enabled = false;
                btnPopraw.Enabled = false;
                btnSzukaj.Enabled = false;
                btnUsun.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            loadList();
            dg1.Refresh();
            dg2.Refresh();
        }
    }
}
