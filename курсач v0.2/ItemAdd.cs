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
    public partial class ItemAdd : Form
    {
        public ItemAdd()
        {
            InitializeComponent();
        }

        private void dowlandpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";
            if (ofd.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    pictureItem.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Неможливо відкрити вибраний файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void create_Click(object sender, EventArgs e)
        {

            string Item = "Files/ID.dat";

            using (BinaryReader reader = new BinaryReader(File.Open(Item, FileMode.Open)))
            {
                ItemsSHP item = new ItemsSHP();
                while (reader.PeekChar() > -1)
                {
                    string ids = reader.ReadString();
                    item.shopIdIT = ids;
                }
                reader.Close();

                string id = item.idIT;
                item.nameIT = nameItem.Text;
                item.desIT = descriptionItem.Text;
                item.namerIT = numeric.Text;
                try
                {
                    item.priceIT = Convert.ToString(int.Parse(price.Text));
                }
                catch { MessageBox.Show("Для ціни можна використовувати лише цифри", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                item.pictureName = "Pictures/" + id + ".bmp";

                string shops = "Files/Items.dat";
                try
                {
                    using (BinaryWriter writer = new BinaryWriter(File.Open(shops, FileMode.Append)))
                    {

                        if (item.pictureName == "" || item.nameIT == "" || item.desIT == "" || item.namerIT == "" || item.priceIT == "" || item.pictureName == "" || item.idIT == "" || item.shopIdIT == "") MessageBox.Show("Не всі поля заповнені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            pictureItem.Image.Save(item.pictureName);
                            writer.Write(item.nameIT);
                            writer.Write(item.desIT);
                            writer.Write(item.namerIT);
                            writer.Write(item.priceIT);
                            writer.Write(item.pictureName);
                            writer.Write(item.idIT);
                            writer.Write(item.shopIdIT);
                            writer.Close();
                            this.Hide();
                            ShopItems form = new ShopItems();
                            form.Show();
                        }

                    }
                }
                catch { }

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

 }


