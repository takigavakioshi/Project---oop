namespace курсач_v0._2
{
    partial class ItemAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemAdd));
            this.nameItem = new System.Windows.Forms.TextBox();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.price = new System.Windows.Forms.TextBox();
            this.pictureItem = new System.Windows.Forms.PictureBox();
            this.dowlandpicture = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.descriptionItem = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).BeginInit();
            this.SuspendLayout();
            // 
            // nameItem
            // 
            this.nameItem.Location = new System.Drawing.Point(258, 41);
            this.nameItem.Name = "nameItem";
            this.nameItem.Size = new System.Drawing.Size(250, 20);
            this.nameItem.TabIndex = 0;
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(388, 216);
            this.numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(120, 20);
            this.numeric.TabIndex = 2;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(388, 242);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(120, 20);
            this.price.TabIndex = 3;
            // 
            // pictureItem
            // 
            this.pictureItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureItem.BackgroundImage")));
            this.pictureItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureItem.Location = new System.Drawing.Point(13, 41);
            this.pictureItem.Name = "pictureItem";
            this.pictureItem.Size = new System.Drawing.Size(193, 216);
            this.pictureItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureItem.TabIndex = 4;
            this.pictureItem.TabStop = false;
            // 
            // dowlandpicture
            // 
            this.dowlandpicture.Location = new System.Drawing.Point(131, 263);
            this.dowlandpicture.Name = "dowlandpicture";
            this.dowlandpicture.Size = new System.Drawing.Size(75, 23);
            this.dowlandpicture.TabIndex = 5;
            this.dowlandpicture.Text = "Вибрати";
            this.dowlandpicture.UseVisualStyleBackColor = true;
            this.dowlandpicture.Click += new System.EventHandler(this.dowlandpicture_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(13, 302);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 31);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Відміна";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(462, 302);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 31);
            this.create.TabIndex = 7;
            this.create.Text = "Створити";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // descriptionItem
            // 
            this.descriptionItem.Location = new System.Drawing.Point(258, 67);
            this.descriptionItem.Name = "descriptionItem";
            this.descriptionItem.Size = new System.Drawing.Size(250, 143);
            this.descriptionItem.TabIndex = 8;
            this.descriptionItem.Text = "";
            // 
            // ItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 335);
            this.Controls.Add(this.descriptionItem);
            this.Controls.Add(this.create);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.dowlandpicture);
            this.Controls.Add(this.pictureItem);
            this.Controls.Add(this.price);
            this.Controls.Add(this.numeric);
            this.Controls.Add(this.nameItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameItem;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button dowlandpicture;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        internal System.Windows.Forms.PictureBox pictureItem;
        private System.Windows.Forms.RichTextBox descriptionItem;
    }
}