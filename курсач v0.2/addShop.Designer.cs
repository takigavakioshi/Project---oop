namespace курсач_v0._2
{
    partial class addShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addShop));
            this.nameshp = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.comboBoxclass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.anotherclass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameshp
            // 
            this.nameshp.Location = new System.Drawing.Point(392, 12);
            this.nameshp.Name = "nameshp";
            this.nameshp.Size = new System.Drawing.Size(212, 20);
            this.nameshp.TabIndex = 0;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(392, 38);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(212, 20);
            this.adres.TabIndex = 1;
            // 
            // comboBoxclass
            // 
            this.comboBoxclass.FormattingEnabled = true;
            this.comboBoxclass.Items.AddRange(new object[] {
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
            this.comboBoxclass.Location = new System.Drawing.Point(392, 64);
            this.comboBoxclass.Name = "comboBoxclass";
            this.comboBoxclass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxclass.TabIndex = 2;
            this.comboBoxclass.SelectedIndexChanged += new System.EventHandler(this.comboBoxclass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адреса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "спеціалізація";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(509, 284);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(95, 37);
            this.Create.TabIndex = 6;
            this.Create.Text = "Створити";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 284);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(95, 37);
            this.exit.TabIndex = 7;
            this.exit.Text = "Відміна";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // anotherclass
            // 
            this.anotherclass.Location = new System.Drawing.Point(312, 91);
            this.anotherclass.Name = "anotherclass";
            this.anotherclass.Size = new System.Drawing.Size(201, 20);
            this.anotherclass.TabIndex = 8;
            this.anotherclass.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вибрати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Choose_Click);
            // 
            // addShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.anotherclass);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxclass);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.nameshp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addShop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameshp;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.ComboBox comboBoxclass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox anotherclass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}