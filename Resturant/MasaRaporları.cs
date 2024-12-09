using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class MasaRaporları : Form
    {
        public MasaRaporları()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-68KIO66\\SQLEXPRESS;Database=Resturant;Integrated Security=true;");
            con.Open();
            LstMasalar.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT MasaAdi,Tutar,Tarih,saat,dakika FROM Masalar where Tarih ='" + dateTimePicker1.Text + "' and MasaAdi like '" + comboBox1.SelectedValue.ToString() + "' ", con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = rdr[0].ToString();
                    li.SubItems.Add(rdr["Tutar"].ToString());
                    li.SubItems.Add(rdr["Tarih"].ToString());
                    li.SubItems.Add(rdr["saat"].ToString());
                    li.SubItems.Add(rdr["dakika"].ToString());
                    LstMasalar.Items.Add(li);


                }
            }

            rdr.Close();
            con.Close();
        }

        private void Listgetir()
        {
            LstMasalar.Items.Clear();
            SqlConnection con = new SqlConnection("Server=DESKTOP-68KIO66\\SQLEXPRESS;Database=Resturant;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * FROM Masalar  ", con); ;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem li = new ListViewItem();
                li.Text = rd["MasaID"].ToString();
                li.SubItems.Add(rd["MasaAdi"].ToString());
                li.SubItems.Add(rd["Tutar"].ToString());
                li.SubItems.Add(rd["Tarih"].ToString());
                li.SubItems.Add(rd["saat"].ToString());
                li.SubItems.Add(rd["dakika"].ToString());
                LstMasalar.Items.Add(li);
            }
            rd.Close();
            con.Close();


        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Listgetir();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection("Server=DESKTOP-68KIO66\\SQLEXPRESS;Database=Resturant;Integrated Security=true;");
            con.Open();
            LstMasalar.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT  * from Masalar ", con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = rdr[0].ToString();
                    li.SubItems.Add(rdr["Tutar"].ToString());
                    li.SubItems.Add(rdr["Tarih"].ToString());
                    li.SubItems.Add(rdr["saat"].ToString());
                    li.SubItems.Add(rdr["dakika"].ToString());
                    LstMasalar.Items.Add(li);


                }
            }

            rdr.Close();
            con.Close();
        }

        private void LstMasalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
