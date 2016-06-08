using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Apka
{
    public partial class Artysta : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=eos.inf.ug.edu.pl;User ID=kpalkowska;Password=224653");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public Artysta()
        {
            InitializeComponent();
        }

        private void Artysta_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;

            // TODO: This line of code loads data into the 'dataSet.wytwornia' table. You can move, or remove it, as needed.
            this.wytworniaTableAdapter.Fill(this.dataSet.wytwornia);
            // TODO: This line of code loads data into the 'dataSet.artysta' table. You can move, or remove it, as needed.
            this.artystaTableAdapter.Fill(this.dataSet.artysta);

            txtid.Clear();
            txtImie.Clear();
            txtNazwisko.Clear();
            txtpseudo.Clear();

            loadList();
            radioButton2.Checked = true;

        }

        private void Artysta_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie wprowadzone zmiany?", "UWAGA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.artystaTableAdapter.Update(this.dataSet.artysta);
            }
        }

        private void txtImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet.Tables["Artysta"].NewRow();

            if (txtImie.Text != "" & txtNazwisko.Text != "" & txtpseudo.Text != "" & dateTimePicker1.Text != null & cmbWytw.SelectedValue != null)
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                cmd.CommandText = "insert into artysta (artysta_imie, artysta_nazwisko, artysta_pseudonim, artysta_data_ur, artysta_wytwornia_id) values (' " + txtImie.Text + " ',' " + txtNazwisko.Text + " ',' " + txtpseudo.Text + " ',' " + dateTimePicker1.Text + " ',' " + cmbWytw.SelectedValue + " ')";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("Rekord został dodany!");
                cn.Close();
                txtid.Text = "";
                txtImie.Text = "";
                txtNazwisko.Text = "";
                txtpseudo.Text = "";

                loadList();
            }
            else MessageBox.Show("Wypełnij pola!");
        }

        private void loadList()
        {
            try
            {
                txtid.Text = "";
                txtImie.Text = "";
                txtNazwisko.Text = "";
                txtpseudo.Text = "";

                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from artysta", cn);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.wytworniaTableAdapter.Fill(this.dataSet.wytwornia);
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                txtid.Text = dg1.SelectedRows[0].Cells[0].Value.ToString();
                txtImie.Text = dg1.SelectedRows[0].Cells[1].Value.ToString();
                txtNazwisko.Text = dg1.SelectedRows[0].Cells[2].Value.ToString();
                txtpseudo.Text = dg1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker1.Text = dg1.SelectedRows[0].Cells[4].Value.ToString();
                cmbWytw.SelectedValue = dg1.SelectedRows[0].Cells[5].Value.ToString();

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
            if (txtImie.Text != "" & txtNazwisko.Text != "" & txtpseudo.Text != "" & dateTimePicker1.Text != null & cmbWytw.SelectedValue != null)
            {
                try
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();
                    SqlCommand sql = new SqlCommand("delete from artysta where artysta_id= @artysta_id", cn);
                    sql.Parameters.AddWithValue("@artysta_id", dg1.SelectedRows[0].Cells[0].Value);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Rekord został usunięty!");
                    cn.Close();
                    loadList();
                    txtid.Text = "";
                    txtImie.Text = "";
                    txtNazwisko.Text = "";
                    txtpseudo.Text = "";
                }
                catch (Exception)
                {
                    cn.Close();
                    MessageBox.Show("Usuwanie rekordu nie powiodło się");
                }
            }

        }

        private void btnPopraw_Click(object sender, EventArgs e)
        {
            if (txtImie.Text != "" & txtNazwisko.Text != "" & txtpseudo.Text != "" & dateTimePicker1.Text != null & cmbWytw.SelectedValue != null)
            {
                try
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();
                    cmd.CommandText = "update artysta set artysta_imie='"+txtImie.Text+"',artysta_nazwisko='"+txtNazwisko.Text+"',artysta_pseudonim='"+txtpseudo.Text+"',artysta_data_ur='"+dateTimePicker1.Text+"',artysta_wytwornia_id='"+cmbWytw.SelectedValue+"' where artysta_id = "+dg1.SelectedRows[0].Cells[0].Value+"";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rekord został poprawiony!");
                    cn.Close();
                    loadList();
                }
                catch (Exception)
                {
                    cn.Close();
                    MessageBox.Show("Poprawianie rekordu nie powiodło się");
                }
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                cmd.CommandText = "select * from artysta where artysta_id=' "+txtid.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dg1.DataSource = dt;
                cn.Close();
            }
            catch (Exception)
            {
                cn.Close();
                MessageBox.Show("Wyszukiwanie rekordu nie powiodło się");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = txtid.Text;

            dg2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            artystaBindingSource.Filter = string.Format("{0} = '{1}'", "artysta_id", searchValue);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg1.CurrentRow != null)
                {
                    dg2.CurrentRow.Selected = true;
                    dg2.CurrentRow.Cells[1].Value = txtImie.Text;
                    dg2.CurrentRow.Cells[2].Value = txtNazwisko.Text;
                    dg2.CurrentRow.Cells[3].Value = txtpseudo.Text;
                    dg2.CurrentRow.Cells[4].Value = dateTimePicker1.Text;
                    dg2.CurrentRow.Cells[5].Value = cmbWytw.SelectedValue;
                    this.wytworniaTableAdapter.Update(this.dataSet.wytwornia);
                    this.artystaTableAdapter.Update(this.dataSet.artysta);
                    dg2.Refresh();
                }
                else dg2.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Zapisywanie rekordu nie powiodło się");
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
                button5.Enabled = true;
            }
            else if(radioButton1.Checked == true)
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
                button5.Enabled = false;
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
                btnPokaz.Enabled = true;
                btnDodaj.Enabled = true;
                btnPopraw.Enabled = true;
                btnSzukaj.Enabled = true;
                btnUsun.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
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
                btnPokaz.Enabled = false;
                btnDodaj.Enabled = false;
                btnPopraw.Enabled = false;
                btnSzukaj.Enabled = false;
                btnUsun.Enabled = false;
                button1.Enabled = true;
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
            artystaBindingSource.RemoveFilter();
            dg1.Refresh();
            dg2.Refresh();
        }

        private void dg2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Nieprawidłowe dane!");
        }


    }
 
}
