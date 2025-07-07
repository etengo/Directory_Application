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

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ENES;Initial Catalog=Rehber;Integrated Security=True;");

        void listele()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from KISILER",baglanti);
            da.Fill(dt);
            dgrehber.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KISILER (AD,SOYAD,TELEFON,MAIL) values (@P1,@P2,@P3,@P4) ",baglanti);
            komut.Parameters.AddWithValue("@P1", txtad.Text);
            komut.Parameters.AddWithValue("@P2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@P3", msktel.Text);
            komut.Parameters.AddWithValue("@P4", txtmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Rehbere Kaydedildi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void dgrehber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgrehber.SelectedCells[0].RowIndex;

            txtid.Text = dgrehber.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dgrehber.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dgrehber.Rows[secilen].Cells[2].Value.ToString();
            msktel.Text = dgrehber.Rows[secilen].Cells[3].Value.ToString();
            txtmail.Text = dgrehber.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from KISILER where ID ="+ txtid.Text, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("Kişi Rehberden Silinsin mi?","Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            listele();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update KISILER set AD=@P1, SOYAD=@P2, TELEFON=@P3, MAIL=@P4 where ID=@P5", baglanti);
            komut.Parameters.AddWithValue("@P1", txtad.Text);
            komut.Parameters.AddWithValue("@P2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@P3", msktel.Text);
            komut.Parameters.AddWithValue("@P4", txtmail.Text);
            komut.Parameters.AddWithValue("@P5", txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Rehberde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
