using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;
using System.Text.RegularExpressions;

namespace курсач_v0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Load_SHOP()
        {
            try
            {
                Shop shop = new Shop();
                string Item = "Files/Shop.dat";
                using (BinaryReader reader = new BinaryReader(File.Open(Item, FileMode.Open)))
                {

                    while (reader.PeekChar() > -1)
                    {
                        shop.name = reader.ReadString();
                        shop.adres = reader.ReadString();
                        shop.type = reader.ReadString();
                        shop.id = reader.ReadString();
                        shop.picture = reader.ReadString();

                        ListViewItem list = new ListViewItem(shop.name);
                        list.SubItems.Add(shop.adres);
                        list.SubItems.Add(shop.type);
                        list.SubItems.Add(Convert.ToString(shop.id));

                        listShop.Items.Add(list);

                    }
                    reader.Close();
                }
            }
            catch { }
        }

        private void add_Click(object sender, EventArgs e)
        {
            addShop form = new addShop();
            this.Hide();
            form.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listShop.Items.Clear();
            Shop shop = new Shop();
            string Item = "Files/Shop.dat";
            using (BinaryReader reader = new BinaryReader(File.Open(Item, FileMode.Open)))
            {

                while (reader.PeekChar() > -1)
                {



                    shop.name = reader.ReadString();
                    shop.type = reader.ReadString();
                    shop.adres = reader.ReadString();

                    shop.id = reader.ReadString();
                    shop.picture = reader.ReadString();
                    if (combotype.Text == shop.type)
                    {

                        ListViewItem list = new ListViewItem(shop.name);
                        list.SubItems.Add(shop.type);
                        list.SubItems.Add(shop.adres);
                        list.SubItems.Add(Convert.ToString(shop.id));

                        listShop.Items.Add(list);

                    }
                    if (combotype.Text == "інше" && shop.type != "Побутова Хімія" && shop.type != "Електрона техніка " && shop.type != "Медецина " && shop.type != "Канцтовари" && shop.type != "Продукти" && shop.type != "Меблі" && shop.type != "Господарські товари" && shop.type != "Одяг" && shop.type != "Взуття" && shop.type != "Книги")
                    {
                        ListViewItem list = new ListViewItem(shop.name);
                        list.SubItems.Add(shop.type);
                        list.SubItems.Add(shop.adres);
                        list.SubItems.Add(Convert.ToString(shop.id));

                        listShop.Items.Add(list);

                    }


                }
                reader.Close();
            }

        }

        private void listShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Shop shop = new Shop();
                string Item = "Files/ID.dat";
                shop.id = listShop.SelectedItems[0].SubItems[3].Text;
                using (BinaryWriter writer = new BinaryWriter(File.Open(Item, FileMode.Create)))
                {
                    writer.Write(shop.id);
                    writer.Close();
                }


            }
            catch { }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            ShopItems form = new ShopItems();
            this.Hide();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_SHOP();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            listShop.Items.Clear();
            Load_SHOP();
        }

        private void search_Click(object sender, EventArgs e)
        {
            listShop.Items.Clear();
            Regex phone = new Regex(@"(" + search.Text + ")");
            Shop shop = new Shop();
            string Item = "Files/Shop.dat";
            using (BinaryReader reader = new BinaryReader(File.Open(Item, FileMode.Open)))
            {

                while (reader.PeekChar() > -1)
                {



                    shop.name = reader.ReadString();
                    shop.type = reader.ReadString();
                    shop.adres = reader.ReadString();
                    shop.id = reader.ReadString();
                    shop.picture = reader.ReadString();
                    if (phone.IsMatch(shop.name)|| phone.IsMatch(shop.adres)|| phone.IsMatch(shop.type)|| phone.IsMatch(shop.id))
                    {

                        ListViewItem list = new ListViewItem(shop.name);
                        list.SubItems.Add(shop.type);
                        list.SubItems.Add(shop.adres);
                        list.SubItems.Add(shop.id);

                        listShop.Items.Add(list);

                    }

                }
                reader.Close();
            }
        }

       

        private void Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}