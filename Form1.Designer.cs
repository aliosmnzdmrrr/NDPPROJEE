﻿namespace NDPPROJE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labeldogru = new System.Windows.Forms.Label();
            this.labelyanlis = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.butonlar);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 81);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.butonlar);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 66);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.butonlar);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 66);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.butonlar);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(103, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 52);
            this.button5.TabIndex = 6;
            this.button5.Text = "İLERİ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labeldogru
            // 
            this.labeldogru.AutoSize = true;
            this.labeldogru.Location = new System.Drawing.Point(596, 326);
            this.labeldogru.Name = "labeldogru";
            this.labeldogru.Size = new System.Drawing.Size(106, 17);
            this.labeldogru.TabIndex = 7;
            this.labeldogru.Text = "DOĞRU SAYISI";
            // 
            // labelyanlis
            // 
            this.labelyanlis.AutoSize = true;
            this.labelyanlis.Location = new System.Drawing.Point(600, 363);
            this.labelyanlis.Name = "labelyanlis";
            this.labelyanlis.Size = new System.Drawing.Size(102, 17);
            this.labelyanlis.TabIndex = 8;
            this.labelyanlis.Text = "YANLIŞ SAYISI";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(317, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 52);
            this.button6.TabIndex = 9;
            this.button6.Text = "BİTİR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.labelyanlis);
            this.Controls.Add(this.labeldogru);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labeldogru;
        private System.Windows.Forms.Label labelyanlis;
        private System.Windows.Forms.Button button6;
    }
}

