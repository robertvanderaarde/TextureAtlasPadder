namespace TextureAtlasPadder
{
    partial class TextureAtlasPadder
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
            this.list_images = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_texid = new System.Windows.Forms.NumericUpDown();
            this.picbox_image = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_imgysize = new System.Windows.Forms.NumericUpDown();
            this.num_imgxsize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_xsize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.num_ysize = new System.Windows.Forms.NumericUpDown();
            this.num_padding = new System.Windows.Forms.NumericUpDown();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_addimage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_texid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_image)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_imgysize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_imgxsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_xsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ysize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_padding)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_images
            // 
            this.list_images.Location = new System.Drawing.Point(12, 56);
            this.list_images.Name = "list_images";
            this.list_images.Size = new System.Drawing.Size(121, 274);
            this.list_images.TabIndex = 0;
            this.list_images.UseCompatibleStateImageBehavior = false;
            this.list_images.SelectedIndexChanged += new System.EventHandler(this.list_images_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.num_texid);
            this.groupBox1.Controls.Add(this.picbox_image);
            this.groupBox1.Location = new System.Drawing.Point(151, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Properties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texture ID";
            // 
            // num_texid
            // 
            this.num_texid.Location = new System.Drawing.Point(87, 74);
            this.num_texid.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_texid.Name = "num_texid";
            this.num_texid.Size = new System.Drawing.Size(143, 20);
            this.num_texid.TabIndex = 1;
            this.num_texid.ValueChanged += new System.EventHandler(this.num_texid_ValueChanged);
            // 
            // picbox_image
            // 
            this.picbox_image.Location = new System.Drawing.Point(6, 20);
            this.picbox_image.Name = "picbox_image";
            this.picbox_image.Size = new System.Drawing.Size(75, 74);
            this.picbox_image.TabIndex = 0;
            this.picbox_image.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_imgysize);
            this.groupBox2.Controls.Add(this.num_imgxsize);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.num_xsize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.num_ysize);
            this.groupBox2.Controls.Add(this.num_padding);
            this.groupBox2.Location = new System.Drawing.Point(151, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texture Atlas Properties";
            // 
            // num_imgysize
            // 
            this.num_imgysize.Location = new System.Drawing.Point(87, 110);
            this.num_imgysize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_imgysize.Name = "num_imgysize";
            this.num_imgysize.Size = new System.Drawing.Size(69, 20);
            this.num_imgysize.TabIndex = 12;
            this.num_imgysize.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.num_imgysize.ValueChanged += new System.EventHandler(this.num_imgysize_ValueChanged);
            // 
            // num_imgxsize
            // 
            this.num_imgxsize.Location = new System.Drawing.Point(6, 110);
            this.num_imgxsize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_imgxsize.Name = "num_imgxsize";
            this.num_imgxsize.Size = new System.Drawing.Size(69, 20);
            this.num_imgxsize.TabIndex = 11;
            this.num_imgxsize.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.num_imgxsize.ValueChanged += new System.EventHandler(this.num_imgxsize_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Image Size Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Image Size X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rows";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Columns";
            // 
            // num_xsize
            // 
            this.num_xsize.Location = new System.Drawing.Point(66, 71);
            this.num_xsize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_xsize.Name = "num_xsize";
            this.num_xsize.Size = new System.Drawing.Size(45, 20);
            this.num_xsize.TabIndex = 5;
            this.num_xsize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_xsize.ValueChanged += new System.EventHandler(this.num_xsize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Padding";
            // 
            // num_ysize
            // 
            this.num_ysize.Location = new System.Drawing.Point(6, 71);
            this.num_ysize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_ysize.Name = "num_ysize";
            this.num_ysize.Size = new System.Drawing.Size(45, 20);
            this.num_ysize.TabIndex = 4;
            this.num_ysize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_ysize.ValueChanged += new System.EventHandler(this.num_ysize_ValueChanged);
            // 
            // num_padding
            // 
            this.num_padding.Location = new System.Drawing.Point(6, 32);
            this.num_padding.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_padding.Name = "num_padding";
            this.num_padding.Size = new System.Drawing.Size(105, 20);
            this.num_padding.TabIndex = 3;
            this.num_padding.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_padding.ValueChanged += new System.EventHandler(this.num_padding_ValueChanged);
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(151, 288);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(236, 42);
            this.btn_generate.TabIndex = 3;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_addimage
            // 
            this.btn_addimage.Location = new System.Drawing.Point(12, 27);
            this.btn_addimage.Name = "btn_addimage";
            this.btn_addimage.Size = new System.Drawing.Size(121, 23);
            this.btn_addimage.TabIndex = 4;
            this.btn_addimage.Text = "Add Image";
            this.btn_addimage.UseVisualStyleBackColor = true;
            this.btn_addimage.Click += new System.EventHandler(this.btn_addimage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click_1);
            // 
            // TextureAtlasPadder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 343);
            this.Controls.Add(this.btn_addimage);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.list_images);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextureAtlasPadder";
            this.Text = "Texture Atlas Padder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_texid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_image)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_imgysize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_imgxsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_xsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ysize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_padding)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_images;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.PictureBox picbox_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_texid;
        private System.Windows.Forms.NumericUpDown num_xsize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_ysize;
        private System.Windows.Forms.NumericUpDown num_padding;
        private System.Windows.Forms.Button btn_addimage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_imgysize;
        private System.Windows.Forms.NumericUpDown num_imgxsize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

