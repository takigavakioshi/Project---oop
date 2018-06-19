using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.IO;


namespace курсач_v0._2
{
    public partial class addShop : Form
    {
        public addShop()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.name = nameshp.Text;
            shop.adres = adres.Text;
            shop.picture = "Pictures/" + shop.id + ".bmp";
            if (comboBoxclass.SelectedIndex == 10)
            {
                anotherclass.Visible = true;
                shop.type = anotherclass.Text;
            }
           else { shop.type = comboBoxclass.Text; }
            string shops = "Files/Shop.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(shops, FileMode.Append)))
            {
                try {
                    pictureBox1.Image.Save(shop.picture);
                    if (shop.name == "" || shop.adres == "" || shop.picture == "") MessageBox.Show("Не всі поля заповнені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        writer.Write(shop.name);
                        writer.Write(shop.type);
                        writer.Write(shop.adres);

                        writer.Write(shop.id);
                        writer.Write(shop.picture);
                        writer.Close();
                    }
                   
                }
                catch
                {
                    MessageBox.Show("Зоображення не було вибране", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Form1 form = new Form1();
            form.Hide();
            form.Show();
            this.Hide();
                this.Close();
              
           
            
            
        }

        private void comboBoxclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxclass.SelectedIndex == 10)
            {
                anotherclass.Visible = true;
            }
            }

      

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void Choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Неможливо відкрити вибраний файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
