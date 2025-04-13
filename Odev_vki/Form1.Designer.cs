namespace Odev_vki
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ad_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.soyad_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kilo_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boy_textbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ekle_button = new System.Windows.Forms.Button();
            this.goster_button = new System.Windows.Forms.Button();
            this.sil_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.soyadsil_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adsil_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.vkiyorumsil_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vkisil_textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.burcsil_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 618);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ad_textbox
            // 
            this.ad_textbox.Location = new System.Drawing.Point(117, 24);
            this.ad_textbox.Name = "ad_textbox";
            this.ad_textbox.Size = new System.Drawing.Size(189, 22);
            this.ad_textbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Soyad";
            // 
            // soyad_textbox
            // 
            this.soyad_textbox.Location = new System.Drawing.Point(117, 67);
            this.soyad_textbox.Name = "soyad_textbox";
            this.soyad_textbox.Size = new System.Drawing.Size(189, 22);
            this.soyad_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kilo";
            // 
            // kilo_textbox
            // 
            this.kilo_textbox.Location = new System.Drawing.Point(117, 203);
            this.kilo_textbox.Name = "kilo_textbox";
            this.kilo_textbox.Size = new System.Drawing.Size(189, 22);
            this.kilo_textbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boy";
            // 
            // boy_textbox
            // 
            this.boy_textbox.Location = new System.Drawing.Point(117, 160);
            this.boy_textbox.Name = "boy_textbox";
            this.boy_textbox.Size = new System.Drawing.Size(189, 22);
            this.boy_textbox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2025, 4, 13, 2, 48, 9, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Doğum Tarihi";
            // 
            // ekle_button
            // 
            this.ekle_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ekle_button.Location = new System.Drawing.Point(19, 257);
            this.ekle_button.Name = "ekle_button";
            this.ekle_button.Size = new System.Drawing.Size(116, 48);
            this.ekle_button.TabIndex = 11;
            this.ekle_button.Text = "Ekle";
            this.ekle_button.UseVisualStyleBackColor = false;
            this.ekle_button.Click += new System.EventHandler(this.ekle_button_Click);
            // 
            // goster_button
            // 
            this.goster_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goster_button.Location = new System.Drawing.Point(190, 257);
            this.goster_button.Name = "goster_button";
            this.goster_button.Size = new System.Drawing.Size(116, 48);
            this.goster_button.TabIndex = 12;
            this.goster_button.Text = "Göster";
            this.goster_button.UseVisualStyleBackColor = false;
            this.goster_button.Click += new System.EventHandler(this.goster_button_Click);
            // 
            // sil_button
            // 
            this.sil_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sil_button.Location = new System.Drawing.Point(19, 579);
            this.sil_button.Name = "sil_button";
            this.sil_button.Size = new System.Drawing.Size(287, 48);
            this.sil_button.TabIndex = 13;
            this.sil_button.Text = "Sil";
            this.sil_button.UseVisualStyleBackColor = false;
            this.sil_button.Click += new System.EventHandler(this.sil_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Soyad";
            // 
            // soyadsil_textbox
            // 
            this.soyadsil_textbox.Location = new System.Drawing.Point(117, 371);
            this.soyadsil_textbox.Name = "soyadsil_textbox";
            this.soyadsil_textbox.Size = new System.Drawing.Size(189, 22);
            this.soyadsil_textbox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ad";
            // 
            // adsil_textbox
            // 
            this.adsil_textbox.Location = new System.Drawing.Point(117, 328);
            this.adsil_textbox.Name = "adsil_textbox";
            this.adsil_textbox.Size = new System.Drawing.Size(189, 22);
            this.adsil_textbox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Doğum Tarihi";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(117, 410);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.Value = new System.DateTime(2025, 4, 13, 2, 47, 50, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "VKI Yorum";
            // 
            // vkiyorumsil_textbox
            // 
            this.vkiyorumsil_textbox.Location = new System.Drawing.Point(117, 496);
            this.vkiyorumsil_textbox.Name = "vkiyorumsil_textbox";
            this.vkiyorumsil_textbox.Size = new System.Drawing.Size(189, 22);
            this.vkiyorumsil_textbox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "VKI";
            // 
            // vkisil_textbox
            // 
            this.vkisil_textbox.Location = new System.Drawing.Point(117, 453);
            this.vkisil_textbox.Name = "vkisil_textbox";
            this.vkisil_textbox.Size = new System.Drawing.Size(189, 22);
            this.vkisil_textbox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 539);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Burç";
            // 
            // burcsil_textbox
            // 
            this.burcsil_textbox.Location = new System.Drawing.Point(117, 539);
            this.burcsil_textbox.Name = "burcsil_textbox";
            this.burcsil_textbox.Size = new System.Drawing.Size(189, 22);
            this.burcsil_textbox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 642);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.burcsil_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vkiyorumsil_textbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.vkisil_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soyadsil_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adsil_textbox);
            this.Controls.Add(this.sil_button);
            this.Controls.Add(this.goster_button);
            this.Controls.Add(this.ekle_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kilo_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boy_textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.soyad_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ad_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ad_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox soyad_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kilo_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boy_textbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ekle_button;
        private System.Windows.Forms.Button goster_button;
        private System.Windows.Forms.Button sil_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soyadsil_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adsil_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vkiyorumsil_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vkisil_textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox burcsil_textbox;
    }
}

