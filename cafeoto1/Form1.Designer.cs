namespace cafeoto1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kullanici = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GİRİŞ = new System.Windows.Forms.Button();
            this.ÇIKIŞ = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kullanici
            // 
            this.kullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kullanici.FormattingEnabled = true;
            this.kullanici.Location = new System.Drawing.Point(481, 200);
            this.kullanici.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(226, 25);
            this.kullanici.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(481, 231);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GİRİŞ
            // 
            this.GİRİŞ.BackColor = System.Drawing.Color.White;
            this.GİRİŞ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GİRİŞ.BackgroundImage")));
            this.GİRİŞ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GİRİŞ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GİRİŞ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GİRİŞ.Location = new System.Drawing.Point(481, 287);
            this.GİRİŞ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GİRİŞ.Name = "GİRİŞ";
            this.GİRİŞ.Size = new System.Drawing.Size(142, 79);
            this.GİRİŞ.TabIndex = 3;
            this.GİRİŞ.UseVisualStyleBackColor = false;
            this.GİRİŞ.Click += new System.EventHandler(this.frm1_Click);
            // 
            // ÇIKIŞ
            // 
            this.ÇIKIŞ.BackColor = System.Drawing.Color.White;
            this.ÇIKIŞ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ÇIKIŞ.BackgroundImage")));
            this.ÇIKIŞ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ÇIKIŞ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ÇIKIŞ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ÇIKIŞ.Location = new System.Drawing.Point(631, 287);
            this.ÇIKIŞ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ÇIKIŞ.Name = "ÇIKIŞ";
            this.ÇIKIŞ.Size = new System.Drawing.Size(76, 79);
            this.ÇIKIŞ.TabIndex = 3;
            this.ÇIKIŞ.UseVisualStyleBackColor = false;
            this.ÇIKIŞ.Click += new System.EventHandler(this.frm1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(481, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 126);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.frm1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ÇIKIŞ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GİRİŞ);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kullanici);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garson Girişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox kullanici;
        private TextBox textBox1;
        private Button GİRİŞ;
        private Button ÇIKIŞ;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}