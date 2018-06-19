namespace курсач_v0._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listShop = new System.Windows.Forms.ListView();
            this.Nameshop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.add = new System.Windows.Forms.Button();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.search_shop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listShop
            // 
            this.listShop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nameshop,
            this.classs,
            this.Adress,
            this.ID});
            this.listShop.FullRowSelect = true;
            this.listShop.GridLines = true;
            this.listShop.Location = new System.Drawing.Point(23, 82);
            this.listShop.MultiSelect = false;
            this.listShop.Name = "listShop";
            this.listShop.Size = new System.Drawing.Size(765, 330);
            this.listShop.TabIndex = 0;
            this.listShop.UseCompatibleStateImageBehavior = false;
            this.listShop.View = System.Windows.Forms.View.Details;
            this.listShop.SelectedIndexChanged += new System.EventHandler(this.listShop_SelectedIndexChanged);
            // 
            // Nameshop
            // 
            this.Nameshop.Text = "Назва";
            this.Nameshop.Width = 139;
            // 
            // classs
            // 
            this.classs.Text = "Спеціалізація";
            this.classs.Width = 94;
            // 
            // Adress
            // 
            this.Adress.Text = "Адреса";
            this.Adress.Width = 430;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 98;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(713, 418);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Добавити";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // combotype
            // 
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
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
            this.combotype.Location = new System.Drawing.Point(23, 41);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(121, 21);
            this.combotype.TabIndex = 2;
            this.combotype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Відкрити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Open_Click);
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.refresh.Location = new System.Drawing.Point(625, 41);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(26, 21);
            this.refresh.TabIndex = 4;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(171, 42);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(418, 20);
            this.search.TabIndex = 5;
            // 
            // search_shop
            // 
            this.search_shop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_shop.BackgroundImage")));
            this.search_shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_shop.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_shop.Location = new System.Drawing.Point(595, 41);
            this.search_shop.Name = "search_shop";
            this.search_shop.Size = new System.Drawing.Size(24, 21);
            this.search_shop.TabIndex = 6;
            this.search_shop.UseVisualStyleBackColor = true;
            this.search_shop.Click += new System.EventHandler(this.search_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(767, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 30);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.search_shop);
            this.Controls.Add(this.search);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listShop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listShop;
        private System.Windows.Forms.ColumnHeader Nameshop;
        private System.Windows.Forms.ColumnHeader classs;
        private System.Windows.Forms.ColumnHeader Adress;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button search_shop;
        private System.Windows.Forms.Button button2;
    }
}

