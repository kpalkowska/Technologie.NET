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
    public partial class Start : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=eos.inf.ug.edu.pl;User ID=kpalkowska;Password=224653");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        DataSet dataSet;
        public Start()
        {
            InitializeComponent();
        }

        private void tabeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void artystaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Artysta artysta = new Artysta();
            artysta.MdiParent = this;
            artysta.Show();

        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            album.MdiParent = this;
            album.Show();
        }

        private void piosenkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Piosenka piosenka = new Piosenka();
            piosenka.MdiParent = this;
            piosenka.Show();
        }

        private void wytworniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wytwornia wytwornia = new Wytwornia();
            wytwornia.MdiParent = this;
            wytwornia.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void albumyartystowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Albumy_artystow albumy_artystow = new Albumy_artystow();
            albumy_artystow.MdiParent = this;
            albumy_artystow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DataColumn parentCol = dataSet.Tables["Album"].Columns["album_id"];
            DataColumn chindCol = dataSet.Tables["Piosenka"].Columns["piosenka_album_id"];
            DataRelation rel = new DataRelation("Album", parentCol, chindCol);
            dataSet.Relations.Add(rel);
            dataSet.Tables["Album"].Rows[0].GetChildRows(rel);
            dataSet.Tables["Piosenka"].Rows[0].GetParentRow(rel);
             * */
            da.Fill(dt);
            try
            {
                da.Update(dataSet.albumy_artystow);
                MessageBox.Show("Synchronizacja tabeli albumy_artystów powiodła się");
            }
            catch (Exception)
            {
                MessageBox.Show("Synchronizacja tabeli albumy_artystów nie powiodła się");
            }
            try
            {
                da.Update(dataSet.piosenka);
                MessageBox.Show("Synchronizacja tabeli piosenka powiodła się");
            }
            catch (Exception)
            {
                MessageBox.Show("Synchronizacja tabeli piosenka nie powiodła się");
            }
            try
            {
                da.Update(dataSet.artysta);
                MessageBox.Show("Synchronizacja tabeli artysta powiodła się");
            }
            catch (Exception)
            {
                MessageBox.Show("Synchronizacja tabeli artysta nie powiodła się");
            }
            try
            {
                da.Update(dataSet.wytwornia);
                MessageBox.Show("Synchronizacja tabeli wytwórnia powiodła się");
            }
            catch (Exception)
            {
                MessageBox.Show("Synchronizacja tabeli wytwórnia nie powiodła się");
            }
            try
            {
                da.Update(dataSet.album);
                MessageBox.Show("Synchronizacja tabeli album powiodła się");
            }
            catch (Exception)
            {
                MessageBox.Show("Synchronizacja tabeli album nie powiodła się");
            }




        }

    }
}
