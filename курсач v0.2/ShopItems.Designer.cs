namespace курсач_v0._2
{
    partial class ShopItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopItems));
            this.shopadress = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameIT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumIT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceIT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idIT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.search_shop = new System.Windows.Forms.Button();
            this.rew = new System.Windows.Forms.Button();
            this.rewname = new System.Windows.Forms.TextBox();
            this.rewadress = new System.Windows.Forms.TextBox();
            this.delet = new System.Windows.Forms.Button();
            this.saveme = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shoptype = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shopadress
            // 
            this.shopadress.AutoSize = true;
            this.shopadress.Location = new System.Drawing.Point(347, 103);
            this.shopadress.Name = "shopadress";
            this.shopadress.Size = new System.Drawing.Size(35, 13);
            this.shopadress.TabIndex = 1;
            this.shopadress.Text = "label1";
            this.shopadress.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(347, 132);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(35, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "label2";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(564, 525);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 23);
            this.add.TabIndex = 4;
            this.add.Text = "Добавити ";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameIT,
            this.NumIT,
            this.PriceIT,
            this.idIT});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(10, 327);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(644, 192);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nameIT
            // 
            this.nameIT.Text = "Назва";
            this.nameIT.Width = 347;
            // 
            // NumIT
            // 
            this.NumIT.Text = "кількість";
            this.NumIT.Width = 79;
            // 
            // PriceIT
            // 
            this.PriceIT.Text = "ціна";
            this.PriceIT.Width = 78;
            // 
            // idIT
            // 
            this.idIT.Text = "ID";
            this.idIT.Width = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Відкрити ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refresh.Location = new System.Drawing.Point(608, 302);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(24, 20);
            this.refresh.TabIndex = 9;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back.Location = new System.Drawing.Point(10, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(32, 23);
            this.back.TabIndex = 11;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button3_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(10, 302);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(561, 20);
            this.search.TabIndex = 12;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // search_shop
            // 
            this.search_shop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_shop.BackgroundImage")));
            this.search_shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_shop.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_shop.Location = new System.Drawing.Point(577, 302);
            this.search_shop.Name = "search_shop";
            this.search_shop.Size = new System.Drawing.Size(25, 20);
            this.search_shop.TabIndex = 13;
            this.search_shop.UseVisualStyleBackColor = true;
            this.search_shop.Click += new System.EventHandler(this.search_shop_Click);
            // 
            // rew
            // 
            this.rew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rew.BackgroundImage")));
            this.rew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rew.Location = new System.Drawing.Point(603, 4);
            this.rew.Name = "rew";
            this.rew.Size = new System.Drawing.Size(27, 23);
            this.rew.TabIndex = 18;
            this.rew.UseVisualStyleBackColor = true;
            this.rew.Click += new System.EventHandler(this.button4_Click);
            // 
            // rewname
            // 
            this.rewname.Location = new System.Drawing.Point(344, 50);
            this.rewname.Name = "rewname";
            this.rewname.Size = new System.Drawing.Size(310, 20);
            this.rewname.TabIndex = 19;
            this.rewname.Visible = false;
            this.rewname.TextChanged += new System.EventHandler(this.rewname_TextChanged);
            // 
            // rewadress
            // 
            this.rewadress.Location = new System.Drawing.Point(344, 100);
            this.rewadress.Name = "rewadress";
            this.rewadress.Size = new System.Drawing.Size(310, 20);
            this.rewadress.TabIndex = 20;
            this.rewadress.Visible = false;
            this.rewadress.TextChanged += new System.EventHandler(this.rewadress_TextChanged);
            // 
            // delet
            // 
            this.delet.Location = new System.Drawing.Point(277, 244);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(121, 34);
            this.delet.TabIndex = 21;
            this.delet.Text = "Видалити";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Visible = false;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // saveme
            // 
            this.saveme.Location = new System.Drawing.Point(533, 244);
            this.saveme.Name = "saveme";
            this.saveme.Size = new System.Drawing.Size(121, 34);
            this.saveme.TabIndex = 22;
            this.saveme.Text = "Зберегти";
            this.saveme.UseVisualStyleBackColor = true;
            this.saveme.Visible = false;
            this.saveme.Click += new System.EventHandler(this.saveme_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Побутова Хімія",
            "Електрона техніка ",
            "Медецина ",
            "Канцтовари ",
            "Продукти",
            "Меблі",
            "Господарські товари",
            "Одяг",
            "Взуття",
            "Книги",
            "інше"});
            this.comboBox1.Location = new System.Drawing.Point(344, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Назва:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Адреса:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Спеціалізація:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "ID:";
            // 
            // shoptype
            // 
            this.shoptype.AutoSize = true;
            this.shoptype.Location = new System.Drawing.Point(347, 79);
            this.shoptype.Name = "shoptype";
            this.shoptype.Size = new System.Drawing.Size(35, 13);
            this.shoptype.TabIndex = 28;
            this.shoptype.Text = "label1";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(636, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ShopItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 558);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.saveme);
            this.Controls.Add(this.delet);
            this.Controls.Add(this.rewadress);
            this.Controls.Add(this.rewname);
            this.Controls.Add(this.rew);
            this.Controls.Add(this.search_shop);
            this.Controls.Add(this.search);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.shopadress);
            this.Controls.Add(this.shoptype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopItems";
            this.Load += new System.EventHandler(this.ShopItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label shopadress;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameIT;
        private System.Windows.Forms.ColumnHeader NumIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader PriceIT;
        private System.Windows.Forms.ColumnHeader idIT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button search_shop;
        private System.Windows.Forms.Button rew;
        private System.Windows.Forms.TextBox rewname;
        private System.Windows.Forms.TextBox rewadress;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Button saveme;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label shoptype;
        private System.Windows.Forms.Button button2;
    }
}