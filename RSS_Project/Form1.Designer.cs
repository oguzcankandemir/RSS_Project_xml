namespace RSS_Project
{
    partial class Form1
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
            this.pic_image = new System.Windows.Forms.PictureBox();
            this.link_lbl_url = new System.Windows.Forms.LinkLabel();
            this.txt_explain = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_Get = new System.Windows.Forms.Button();
            this.lbl_Link_News = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_image
            // 
            this.pic_image.Location = new System.Drawing.Point(18, 19);
            this.pic_image.Name = "pic_image";
            this.pic_image.Size = new System.Drawing.Size(219, 151);
            this.pic_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_image.TabIndex = 16;
            this.pic_image.TabStop = false;
            // 
            // link_lbl_url
            // 
            this.link_lbl_url.AutoSize = true;
            this.link_lbl_url.BackColor = System.Drawing.Color.AliceBlue;
            this.link_lbl_url.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.link_lbl_url.LinkColor = System.Drawing.Color.Red;
            this.link_lbl_url.Location = new System.Drawing.Point(15, 187);
            this.link_lbl_url.Name = "link_lbl_url";
            this.link_lbl_url.Size = new System.Drawing.Size(103, 15);
            this.link_lbl_url.TabIndex = 11;
            this.link_lbl_url.TabStop = true;
            this.link_lbl_url.Text = "Haber Linkine Git";
            this.link_lbl_url.VisitedLinkColor = System.Drawing.Color.DeepPink;
            // 
            // txt_explain
            // 
            this.txt_explain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_explain.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_explain.Location = new System.Drawing.Point(257, 19);
            this.txt_explain.Name = "txt_explain";
            this.txt_explain.Size = new System.Drawing.Size(399, 151);
            this.txt_explain.TabIndex = 10;
            this.txt_explain.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // Btn_Get
            // 
            this.Btn_Get.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Get.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Get.Location = new System.Drawing.Point(321, 43);
            this.Btn_Get.Name = "Btn_Get";
            this.Btn_Get.Size = new System.Drawing.Size(75, 21);
            this.Btn_Get.TabIndex = 18;
            this.Btn_Get.Text = "Get";
            this.Btn_Get.UseVisualStyleBackColor = false;
            this.Btn_Get.Click += new System.EventHandler(this.Get_button2_Click);
            // 
            // lbl_Link_News
            // 
            this.lbl_Link_News.AutoSize = true;
            this.lbl_Link_News.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Link_News.LinkColor = System.Drawing.Color.Red;
            this.lbl_Link_News.Location = new System.Drawing.Point(12, 85);
            this.lbl_Link_News.Name = "lbl_Link_News";
            this.lbl_Link_News.Size = new System.Drawing.Size(122, 16);
            this.lbl_Link_News.TabIndex = 19;
            this.lbl_Link_News.TabStop = true;
            this.lbl_Link_News.Text = "Gelicek olan link";
            this.lbl_Link_News.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Haber_linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pic_image);
            this.panel1.Controls.Add(this.txt_explain);
            this.panel1.Controls.Add(this.link_lbl_url);
            this.panel1.Location = new System.Drawing.Point(406, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 436);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 436);
            this.panel2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.lbl_Link_News);
            this.Controls.Add(this.Btn_Get);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "RSS";
            this.Load += new System.EventHandler(this.RSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pic_image;
        public System.Windows.Forms.LinkLabel link_lbl_url;
        public System.Windows.Forms.RichTextBox txt_explain;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_Get;
        private System.Windows.Forms.LinkLabel lbl_Link_News;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

