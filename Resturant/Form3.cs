using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int sol = 1; //formun sol tarafından atanan değer
        int alt = 50; // formun üst tarafından atanan değer
        int bol; // bolme işlemindeki amaç formun boyutuna göre butonları sıralı bir şekilde görebilmek için
        
        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)  // girilen buton sayısına göre döngü şartı sağlanana kadar oluşturmakta
            {
                Button btn = new Button();
                btn.Name = i.ToString();

                btn.AutoSize = false;

                //btn.Size = new Size(this.Width / bol, this.Height / (bol * 2));
                btn.Text = "Buton " + i.ToString();
                btn.Font = new Font(btn.Font.FontFamily.Name, 18);
                btn.Location = new Point(sol, alt);
                this.Controls.Add(btn);
                sol += btn.Width + 10;
            }
        }
        protected void dinamikMetod(object sender, EventArgs e)
        {
            Button dinamikButon = (sender as Button);
            MessageBox.Show(dinamikButon.Text + " isimli butona tıkladınız");
           // Ekle(dinamikButon.Text, top, saat, dakika);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(dinamikMetod);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click += new EventHandler(dinamikMetod);
        }
    }
}
