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

namespace курсач_v0._2
{
    public partial class ShowIT : Form
    {
        public ShowIT()
        {
            InitializeComponent();
            
        }

        private void ShowIT_Load(object sender, EventArgs e)
        {
            Load_IT();
        }
        private void Load_IT()
        {
              ItemsSHP it = new ItemsSHP();

                string Item = "Files/IDS.dat";
                string Items = "Files/Items.dat";
                using (BinaryReader reader = new BinaryReader(File.Open(Item, FileMode.Open)))
                {
                    using (BinaryReader reader2 = new BinaryReader(File.Open(Items, FileMode.Open)))
                    {
                        while (reader.PeekChar() > -1)
                        {
                            string id = reader.ReadString();



                            while (reader2.PeekChar() > -1)
                            {
                                it.nameIT = reader2.ReadString();
                                it.desIT = reader2.ReadString();
                                it.namerIT = reader2.ReadString();
                                it.priceIT = reader2.ReadString();
                                it.pictureName = reader2.ReadString();
                                it.idIT = reader2.ReadString();
                                it.shopIdIT = reader2.ReadString();

                                if (it.idIT == id)
                                {
                                    label1.Text = it.nameIT;
                                    richTextBox1.Text = it.desIT;
                                    label3.Text = it.namerIT;
                                    label2.Text = it.priceIT;
                                    label4.Text = it.idIT;
                                    pictureBox1.Image = new Bitmap(it.pictureName);
                               rewname.Text= it.nameIT;
                                rewprice.Text = it.priceIT;

                                numeric.Text = it.namerIT; 
                            }
                            }
                            reader2.Close();

                        }
                    }
                    reader.Close();
                }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rewname.Visible = true;
            rewprice.Visible = true;
           
            delate.Visible = true;
            numeric.Visible = true;
            saveIt.Visible = true;
            richTextBox1.ReadOnly = false;
        }

        private void saveIt_Click(object sender, EventArgs e)
        {

            ItemsSHP[] it = new ItemsSHP[1];

            string Item = "Files/IDS.dat";
            string Items = "Files/Items.dat";
            string[] nameIT = new string[100];
            string[] namerIT = new string[100];
            string[] desIT = new string[100];
            string[] priceIT = new string[100];
            string[] pictureName = new string[100];
            string[] idIT = new string[100];
            string[] shopIdIT = new string[100];

            using (BinaryReader reader = new BinaryReader(File.Open(Item, FileMode.Open)))
            {
                int dis = 0;
                using (BinaryReader reader2 = new BinaryReader(File.Open(Items, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string id = reader.ReadString();

                        

                        for (int i = 0;  reader2.PeekChar() > -1; i++)
                        {
                            nameIT[i] = reader2.ReadString();
                            desIT[i] = reader2.ReadString();
                            namerIT[i] = reader2.ReadString();
                            priceIT[i] = reader2.ReadString();
                            pictureName[i] = reader2.ReadString();
                            idIT[i] = reader2.ReadString();
                            shopIdIT[i] = reader2.ReadString();

                            if (idIT[i] == id)
                            {
                                 nameIT[i] = rewname.Text;
                                priceIT[i] =   rewprice.Text;
                                desIT[i] =  richTextBox1.Text;
                                namerIT[i] =  numeric.Text;
                            }
                            dis++;
                        }
                        reader2.Close();
                       
                    }
                   
                }
                using (BinaryWriter writer = new BinaryWriter(File.Open(Items, FileMode.Create)))
                {
                    for (int i = 0; i < dis; i++)
                    {


                        writer.Write(nameIT[i]);
                        writer.Write(desIT[i]);
                        writer.Write(namerIT[i]);
                        writer.Write(priceIT[i]);
                        writer.Write(pictureName[i]);
                        writer.Write(idIT[i]);
                        writer.Write(shopIdIT[i]);
                       
                    }
                       writer.Close();
                }
                reader.Close();
                ShopItems form = new ShopItems();
                this.Hide();
                form.ShowDialog();
            }

           
           
            
        }

        private void delate_Click(object sender, EventArgs e)
        {
            ItemsSHP[] it = new ItemsSHP[1];

            string Item = "Files/IDS.dat";
            string Items = "Files/Items.dat";
            string[] nameIT = new string[100];
            string[] namerIT = new string[100];
            string[] desIT = new string[100];
            string[] priceIT = new string[100];
            string[] pictureName = new string[100];
            string[] idIT = new string[100];
            string[] shopIdIT = new string[100];

            using (BinaryReader reader = new BinaryReader(File.Open(Item, FileMode.Open)))
            {
                int dis = 0;
                using (BinaryReader reader2 = new BinaryReader(File.Open(Items, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string id = reader.ReadString();



                        for (int i = 0; reader2.PeekChar() > -1; i++)
                        {
                            nameIT[i] = reader2.ReadString();
                            desIT[i] = reader2.ReadString();
                            namerIT[i] = reader2.ReadString();
                            priceIT[i] = reader2.ReadString();
                            pictureName[i] = reader2.ReadString();
                            idIT[i] = reader2.ReadString();
                            shopIdIT[i] = reader2.ReadString();

                           
                            dis++;
                        }
                        {
                            for (int i = 0; i < dis; i++)
                            {
                                if (idIT[i] == id)
                                {
                                    
                                    try
                                    {  for (int j = i; j < dis; j++)
                                        {
                                            nameIT[j ] = nameIT[j+1];
                                            priceIT[j ] = priceIT[j+1];
                                            desIT[j ] = desIT[j+1];
                                            namerIT[j ] = namerIT[j+1];
                                            pictureName[j ] = pictureName[j+1] ;
                                            idIT[j] = idIT[j+1];
                                            shopIdIT[j] = shopIdIT[j+1];
                                            
                                        }
                                        dis--;
                                    }
                                    catch { dis--; }
                                    
                                }
                            }
                        }
                        reader2.Close();

                    }

                }
                using (BinaryWriter writer = new BinaryWriter(File.Open(Items, FileMode.Create)))
                {
                    for (int i = 0; i < dis; i++)
                    {


                        writer.Write(nameIT[i]);
                        writer.Write(desIT[i]);
                        writer.Write(namerIT[i]);
                        writer.Write(priceIT[i]);
                        writer.Write(pictureName[i]);
                        writer.Write(idIT[i]);
                        writer.Write(shopIdIT[i]);

                    }
                    writer.Close();
                }
                reader.Close();
                ShopItems form = new ShopItems();
                this.Hide();
                form.ShowDialog();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShopItems form = new ShopItems();
            this.Hide();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
