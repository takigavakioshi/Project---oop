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
    public partial class ShopItems : Form
    {
        public ShopItems()
        {
            InitializeComponent();



            this.Refresh();

        }



        private void Load_list()
        {
            Shop shop = new Shop();
            ItemsSHP item = new ItemsSHP();
            string Item = "Files/Items.dat";
            string IDD = "Files/ID.dat";
            string Shop = "Files/Shop.dat";
            try {
                using (BinaryReader reader = new BinaryReader(File.Open(IDD, FileMode.Open)))
                {
                    using (BinaryReader reader2 = new BinaryReader(File.Open(Shop, FileMode.Open)))
                    {
                        using (BinaryReader reader3 = new BinaryReader(File.Open(Item, FileMode.Open)))
                        {
                            while (reader.PeekChar() > -1)
                            {
                                string id = reader.ReadString();



                                while (reader2.PeekChar() > -1)
                                {
                                    shop.name = reader2.ReadString();
                                    shop.type = reader2.ReadString();
                                    shop.adres = reader2.ReadString();

                                    shop.id = reader2.ReadString();
                                    shop.picture = reader2.ReadString();

                                    if (shop.id == id)
                                    {
                                        rewname.Text = shop.name;
                                        rewadress.Text = shop.adres;
                                        comboBox1.Text = shop.type;
                                        label1.Text = shop.name;
                                        shopadress.Text = shop.adres;
                                        shoptype.Text = shop.type;
                                        ID.Text = id;
                                        pictureBox1.Image = new Bitmap(shop.picture);

                                    }
                                }
                                reader2.Close();


                                while (reader3.PeekChar() > -1)
                                {





                                    item.nameIT = reader3.ReadString();
                                    item.desIT = reader3.ReadString();
                                    item.namerIT = reader3.ReadString();
                                    item.priceIT = reader3.ReadString();
                                    item.pictureName = reader3.ReadString();
                                    item.idIT = reader3.ReadString();
                                    item.shopIdIT = reader3.ReadString();

                                    if (item.shopIdIT == id)
                                    {

                                        ListViewItem list = new ListViewItem(item.nameIT);

                                        list.SubItems.Add(item.namerIT);
                                        list.SubItems.Add(item.priceIT);
                                        list.SubItems.Add(item.idIT);
                                        listView1.Items.Add(list);


                                    }


                                }
                                reader3.Close();

                            }
                        }
                        reader.Close();
                    }
                } 
            }
            catch { }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShopName_Click(object sender, EventArgs e)
        {

        }

        private void ShopItems_Load(object sender, EventArgs e)
        {
            try
            {
                Load_list();
            }
            catch { }

        }

        private void add_Click(object sender, EventArgs e)
        {
            ItemAdd form = new ItemAdd();
            
            form.ShowDialog();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ItemsSHP items = new ItemsSHP();
                string Item = "Files/IDS.dat";
                items.idIT = listView1.SelectedItems[0].SubItems[3].Text;
                using (BinaryWriter writer = new BinaryWriter(File.Open(Item, FileMode.Create)))
                {
                    writer.Write(items.idIT);
                    writer.Close();
                }

            }
            catch  { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowIT form = new ShowIT();
            this.Hide();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Load_list();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void search_shop_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Regex phone = new Regex(@"(" + search.Text + ")");
            ItemsSHP item = new ItemsSHP();
            string Item = "Files/Items.dat";
            using (BinaryReader reader = new BinaryReader(File.Open(Item, FileMode.Open)))
            {

                while (reader.PeekChar() > -1)
                {



                    item.nameIT = reader.ReadString();
                    item.desIT = reader.ReadString();
                    item.namerIT = reader.ReadString();
                    item.priceIT = reader.ReadString();
                    item.pictureName = reader.ReadString();
                    item.idIT = reader.ReadString();
                    item.shopIdIT = reader.ReadString();

                    if (phone.IsMatch(item.nameIT) || phone.IsMatch(item.desIT) || phone.IsMatch(item.namerIT) || phone.IsMatch(item.priceIT) || phone.IsMatch(item.idIT))
                    {

                        ListViewItem list = new ListViewItem(item.nameIT);
                        list.SubItems.Add(item.namerIT);
                        list.SubItems.Add(item.priceIT);
                        list.SubItems.Add(item.idIT);

                        listView1.Items.Add(list);

                    }

                }
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            rewname.Visible = true;
            rewadress.Visible = true;
            delet.Visible = true;
            saveme.Visible = true;
            comboBox1.Visible = true;
        }

        private void saveme_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            string IDD = "Files/ID.dat";
            string Shop = "Files/Shop.dat";
            string[] name = new string[100];
            string[] adres = new string[100];
            string[] type = new string[100];
            string[] idd = new string[100];
            string[] picture = new string[100];


            using (BinaryReader reader = new BinaryReader(File.Open(IDD, FileMode.Open)))
            {
                int dis = 0;
                using (BinaryReader reader2 = new BinaryReader(File.Open(Shop, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string id = reader.ReadString();



                        for (int i = 0; reader2.PeekChar() > -1; i++)
                        {
                            name[i] = reader2.ReadString();
                            type[i] = reader2.ReadString();
                            adres[i] = reader2.ReadString();
                            idd[i] = reader2.ReadString();
                            picture[i] = reader2.ReadString();

                            if (idd[i] == id)
                            {
                                
                                name[i] = rewname.Text;
                                adres[i] = rewadress.Text;
                                type[i] = comboBox1.Text;

                            }
                            dis++;
                        }
                        reader2.Close();

                    }

                }
                using (BinaryWriter writer = new BinaryWriter(File.Open(Shop, FileMode.Create)))
                {
                    for (int i = 0; i < dis; i++)
                    {


                        writer.Write(name[i]);
                        writer.Write(type[i]);
                        writer.Write(adres[i]);
                        writer.Write(idd[i]);
                        writer.Write(picture[i]);


                    }
                    writer.Close();
                }
                reader.Close();
                ShopItems form = new ShopItems();
                this.Hide();
                form.ShowDialog();
            }
        }

        private void rewadress_TextChanged(object sender, EventArgs e)
        {

        }

        private void delet_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            string IDD = "Files/ID.dat";
            string Shop = "Files/Shop.dat";
            string[] name = new string[100];
            string[] adres = new string[100];
            string[] type = new string[100];
            string[] idd = new string[100];
            string[] picture = new string[100];


            using (BinaryReader reader = new BinaryReader(File.Open(IDD, FileMode.Open)))
            {
                int dis = 0;
                using (BinaryReader reader2 = new BinaryReader(File.Open(Shop, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string id = reader.ReadString();



                        for (int i = 0; reader2.PeekChar() > -1; i++)
                        {
                            name[i] = reader2.ReadString();
                            type[i] = reader2.ReadString();
                            adres[i] = reader2.ReadString();
                            idd[i] = reader2.ReadString();
                            picture[i] = reader2.ReadString();



                            dis++;
                        }

                        for (int i = 0; i < dis; i++)
                        {
                            if (idd[i] == id)
                            {
                                try
                                {

                                    for (int j = i; j < dis; j++)
                                    {
                                        name[j] = name[j + 1];
                                        adres[j] = adres[j + 1];
                                        type[j] = type[j + 1];
                                        idd[j] = idd[j + 1];
                                        picture[j] = picture[j + 1];
                                        
                                    }
                                    dis--;
                                }
                                catch
                                {
                                    dis--;
                                }
                            }
                            reader2.Close();

                        }

                    }
                    using (BinaryWriter writer = new BinaryWriter(File.Open(Shop, FileMode.Create)))
                    {
                        for (int i = 0; i < dis; i++)
                        {


                            writer.Write(name[i]);
                            writer.Write(type[i]);
                            writer.Write(adres[i]);
                            writer.Write(idd[i]);
                            writer.Write(picture[i]);


                        }
                        writer.Close();
                    }
                    reader.Close();
                    Form1 form = new Form1();
                    this.Hide();
                    form.ShowDialog();
                }
            }
        }

        private void rewname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

