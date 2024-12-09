using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Resturant
{
    public partial class ResturantForm : Form
    {
        private int saat;
        private int dakika;
        public ResturantForm()
        {
            InitializeComponent();
        }      
        int toplamtutar = 0;
        int[] fiyatsalata = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int[] içecekfiyatlari = { 1, 2, 3, 4, 5, 6, 7, 8 };
        string[] içecekler = { "Kola", "Ayran", "Çay", "Su", "Meyve Suyu", "Fanta", "Şalgam", "link" };
        string[] secilenyemekler = new string[100];
        int comboindex;
        int toplami;
        public void Ekle(string buttonAdi,int toplamtutari,int saat,int dakika)
        {
            toplami = toplamtutari;
            SqlCommand cmd = new SqlCommand("Insert into Masalar(MasaAdi,Tutar,Tarih,saat,dakika) values(@MasaAdi,@toplamtutari,@Tarih,@saat,@dakika)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@MasaAdi", buttonAdi);
            cmd.Parameters.AddWithValue("@toplamtutari", toplamtutari);
            cmd.Parameters.AddWithValue("@Tarih", dateTimePicker.Text);
            cmd.Parameters.AddWithValue("@saat", saat);
            cmd.Parameters.AddWithValue("@dakika", dakika);
            int affect=cmd.ExecuteNonQuery();
            if (affect > 0)
            {
                Txttutar.Text = toplamtutari + "₺";
                MessageBox.Show("Satış Raporuna Başarıyla Kaydedildi", "Resturant Siparis Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);             
                con.Close();
              
            }
        }

        private void ComboDoldur()
        {
            cmbMasalar.Items.Clear();
            SqlConnection con = new SqlConnection("Server=DESKTOP-68KIO66\\SQLEXPRESS;Database=Resturant;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * FROM Masalar  ", con); ;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cmbMasalar.Items.Add(rd[1]);
            }
            rd.Close();
            con.Close();
        }
        string butonadi;
        private void Button3_Click_1(object sender, EventArgs e)
        {
            for (int i = ResturantForm.Tiklandi; i < 21; i++)
            {
                if (i == ResturantForm.Tiklandi)
                {
                    butonadi="masa"+i;
                    Ekle(butonadi, toplamtutar, saat, dakika);                    
                    Txttutar.Text = toplamtutar + "₺";                    
                    break;
                }
            }
            lstView.Items.Clear();
            Listgetir();
              ComboDoldur();

        }
        bool durum = false;
        private void button1_Click(object sender, EventArgs e)
        {
             saat = DateTime.Now.Hour;
             dakika = DateTime.Now.Minute;
        
            if (ResturantForm.Tiklandi != 0)
            {
            
               comboindex = Cmbİcecekler.SelectedIndex;
                if (comboindex >= 0)
                {

                    toplamtutar += int.Parse(içecekfiyatlari[comboindex].ToString());
                    lstBoxSiparis.Items.Add("" + Cmbİcecekler.SelectedItem.ToString());
                    Cmbİcecekler.SelectedItem = null;
                    durum = true;
                }
                //secilen yemekler
                foreach (Control item in grpBoxYemekler.Controls)
                {
                    if (item is CheckBox)
                    {
                        if (((CheckBox)item).Checked == true)
                        {

                            toplamtutar += Convert.ToInt32(item.Tag);
                            // secilenyemekler[x]=((CheckBox)item).Text.ToString();
                            lstBoxSiparis.Items.Add("" + ((CheckBox)item).Text.ToString());
                            durum = true;
                            ((CheckBox)item).Checked = false;
                        }
                    }
                  
                }

                int i;           
                for (i = 0; i <= (salataa.Items.Count - 1); i++)
                {
                    if (salataa.GetItemChecked(i))
                    {
                        toplamtutar += int.Parse(fiyatsalata[i].ToString());
                        lstBoxSiparis.Items.Add("" + salataa.Items[i].ToString());
                        salataa.SetItemChecked(i, false);
                        durum = true;
                    }
                }
                //Secilen tatlılardan
                foreach (Control item1 in groupBox2.Controls)
                {
                    if (item1 is RadioButton)
                    {
                        if (((RadioButton)item1).Checked == true)
                        {
                            toplamtutar += Convert.ToInt32(item1.Tag);
                            lstBoxSiparis.Items.Add("" + item1.Text.ToString());
                            durum = true;

                        }

                        ((RadioButton)item1).Checked = false;
                    }

                }
                Txttutar.Text = toplami.ToString();

                if (durum == true)
                {
                                      
                    MessageBox.Show("Siparisiniz eklendi", "Resturant Siparis Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                  
                }
                else
                {
                  
                    MessageBox.Show("Siparis eklemek için menülerden seçim yapınız",
                   "Resturant Siparis Sistemi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning 
                    );
                }
            }
            else
            {
                
                MessageBox.Show("Sipariş Eklenmeden Önce Masa Açınız",
                  "Resturant siparis sistemi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning 
  );

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
                    
            for (int i = 0; i < içecekler.Length; i++)
            {

                Cmbİcecekler.Items.Add(içecekler[i].ToString());
            }
            Listgetir();

            SqlConnection con = new SqlConnection("Server=DESKTOP-68KIO66\\SQLEXPRESS;Database=Resturant;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * FROM Masalar  ", con); ;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cmbMasalar.Items.Add(rd[1]);
            }
            rd.Close();
            con.Close();


        }   
        private void Temizle_Click(object sender, EventArgs e)
        {
            lstBoxSiparis.Items.Clear();
            toplamtutar = 0;
            if (lstBoxSiparis.Items.Count == 0)
            {
                MessageBox.Show("Ekran Temizlendi", "Resturant Siparis Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }      
        private void button4_Click(object sender, EventArgs e)
            {
            if (Application.OpenForms["ResturantForm"] != null)
            {
                if (lstBoxSiparis.Items.Count> 0)
                {
                    DialogResult result1 = MessageBox.Show("Siparisi İptal Etmek İstediğinizden Eminmisiniz.", "Siparis İptal", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        int list = lstBoxSiparis.SelectedIndex;
                        string ad = lstBoxSiparis.SelectedItem.ToString();
                        for (int j = 0; j < içecekler.Length; j++)
                        {
                            if (ad == içecekler[j].ToString())
                                toplamtutar -= içecekfiyatlari[j];
                        }
                        foreach (Control item in grpBoxYemekler.Controls)
                        {
                            if (ad == item.Text.ToString())
                            {
                                toplamtutar -= Convert.ToInt32(item.Tag);
                            }
                        }
                        for (int i = 0; i < salataa.Items.Count; i++)
                        {
                            if (ad == salataa.Items[i].ToString())
                            {
                                toplamtutar -= fiyatsalata[i];
                            }
                        }
                        switch (ad.ToString())
                        {
                            case "Kadayıf":
                                toplamtutar -= 10;
                                break;
                            case "Baklava":
                                toplamtutar -= 20;
                                break;
                            case "İrmik":
                                toplamtutar -= 30;
                                break;
                            case "Tulumba":
                                toplamtutar -= 40;
                                break;
                            case "Künefe":
                                toplamtutar -= 50;
                                break;
                            case "Sütlaç":
                                toplamtutar -= 60;
                                break;
                            default:
                                break;

                        }
                        lstBoxSiparis.Items.RemoveAt(list);                       
                        MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti", "Resturant Siparis Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("liste boş");
                }
            }
            else
            {
                MessageBox.Show("Sipariş Eklenmeden Önce Masa Açınız");
                MessageBox.Show("Sipariş Eklenmeden Önce Masa Açınız",
                 "Resturant siparis sistemi",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                                );
            }

            }
         SqlConnection con = new SqlConnection("Server=DESKTOP-68KIO66\\SQLEXPRESS;Database=Resturant;Integrated Security=true");
        public static int Tiklandi = 0;   
       
        private void button5_Click_1(object sender, EventArgs e)
        {
            for (int i = ResturantForm.Tiklandi; i<21 ; i++)
            {
                if (i == ResturantForm.Tiklandi)
                {
                    MessageBox.Show("Masa " + i + "\tTutar=" + toplamtutar + "₺ \t" + dateTimePicker.Text + "" + saat + ":" + dakika);
                    break;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> data = new List<int>();
                foreach (ListViewItem item in lstView.Items)
                {
                    if (item.Checked)
                    {
                        data.Add(Convert.ToInt32(item.Text));
                    }
                }
                if (data.Count > 0)
                {
                    SqlConnection con = new SqlConnection("Server=DESKTOP-68KIO66\\SQLEXPRESS;Database=Resturant;Integrated Security=true;");
                    if (con.State == System.Data.ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    int affect = 0;
                    for (int i = 0; i < data.Count; i++)
                    {
           SqlCommand cmd = new SqlCommand($"Delete from Masalar where MasaID={data[i]}", con);
                        affect += cmd.ExecuteNonQuery();
                    }
                    if (affect > 0)
                    {
                        MessageBox.Show("Silme Başarılıyla Gerçekleşti", "Resturant Siparis Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listgetir();
                    }
                }
                else
                {
                    MessageBox.Show("Silmek için Masa Seçiniz",
                  "Resturant siparis sistemi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning 
                                   );
                 
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("" + dateTimePicker1.Text);
        }

       private void Listgetir()
        {
            lstView.Items.Clear();
            SqlConnection con = new SqlConnection("Server=DESKTOP-68KIO66\\SQLEXPRESS;Database=Resturant;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * FROM Masalar  ", con);
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
                lstView.Items.Add(li);
            }
            rd.Close();
            con.Close();


        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstView.Items.Clear();
            SqlConnection con = new SqlConnection("Server=DESKTOP-68KIO66\\SQLEXPRESS;Database=Resturant;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * FROM Masalar WHERE MasaAdi='" + cmbMasalar.Text + "' and Tarih='" + dateTimePicker.Text + "' ", con);
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
                lstView.Items.Add(li);
             
            }
         
            rd.Close();
            con.Close();
        }
        private void button6_Click_1(object sender, EventArgs e)
        {

           
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            MasaRaporları frm = new MasaRaporları();            
            frm.ShowDialog();
        }
        private void btn1_Click(object sender, EventArgs e)
        {           
                Tiklandi = 1;
                ResturantForm frm = new ResturantForm();
                frm.ShowDialog();
        }
        private void button6_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2_Click(object ResturantFormr, EventArgs e)
        {
            Tiklandi = 2;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Tiklandi = 3;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Tiklandi = 4;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Tiklandi = 5;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Tiklandi = 6;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Tiklandi = 7;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Tiklandi = 8;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Tiklandi = 9;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Tiklandi = 10;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            Tiklandi = 11;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            Tiklandi = 12;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();

        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Tiklandi = 13;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            Tiklandi = 14;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Tiklandi = 15;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            Tiklandi = 16;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            Tiklandi = 17;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            Tiklandi = 18;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            Tiklandi = 19;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Tiklandi = 20;
            ResturantForm frm = new ResturantForm();
            frm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }

