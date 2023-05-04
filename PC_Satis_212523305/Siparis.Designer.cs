
namespace PC_Satis_212523305
{
    partial class Siparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparis));
            this.label1 = new System.Windows.Forms.Label();
            this.txtsiparismustid = new System.Windows.Forms.TextBox();
            this.txtsiparisurunid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsiparisfiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsiparisadet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnmstekle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri ID";
            // 
            // txtsiparismustid
            // 
            this.txtsiparismustid.Location = new System.Drawing.Point(162, 27);
            this.txtsiparismustid.Name = "txtsiparismustid";
            this.txtsiparismustid.ReadOnly = true;
            this.txtsiparismustid.Size = new System.Drawing.Size(216, 26);
            this.txtsiparismustid.TabIndex = 1;
            this.txtsiparismustid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsiparisurunid
            // 
            this.txtsiparisurunid.Location = new System.Drawing.Point(162, 89);
            this.txtsiparisurunid.Name = "txtsiparisurunid";
            this.txtsiparisurunid.Size = new System.Drawing.Size(216, 26);
            this.txtsiparisurunid.TabIndex = 3;
            this.txtsiparisurunid.TextChanged += new System.EventHandler(this.txtsiparisurunid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün ID";
            // 
            // txtsiparisfiyat
            // 
            this.txtsiparisfiyat.Location = new System.Drawing.Point(162, 151);
            this.txtsiparisfiyat.Name = "txtsiparisfiyat";
            this.txtsiparisfiyat.Size = new System.Drawing.Size(216, 26);
            this.txtsiparisfiyat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sipariş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teslim Tarihi";
            // 
            // txtsiparisadet
            // 
            this.txtsiparisadet.Location = new System.Drawing.Point(162, 337);
            this.txtsiparisadet.Name = "txtsiparisadet";
            this.txtsiparisadet.Size = new System.Drawing.Size(216, 26);
            this.txtsiparisadet.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sipariş Adeti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ürün Puanı";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(162, 274);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(216, 26);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // btnmstekle
            // 
            this.btnmstekle.BackColor = System.Drawing.Color.Lavender;
            this.btnmstekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmstekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmstekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmstekle.ForeColor = System.Drawing.Color.Green;
            this.btnmstekle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnmstekle.Location = new System.Drawing.Point(119, 442);
            this.btnmstekle.Name = "btnmstekle";
            this.btnmstekle.Size = new System.Drawing.Size(169, 46);
            this.btnmstekle.TabIndex = 16;
            this.btnmstekle.Text = "Siparişi Kaydet";
            this.btnmstekle.UseVisualStyleBackColor = false;
            this.btnmstekle.Click += new System.EventHandler(this.btnmstekle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-6, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(10, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(401, -1);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(13, 26);
            this.textBox3.TabIndex = 20;
            this.textBox3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(162, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 26);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(409, 517);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnmstekle);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsiparisadet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsiparisfiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsiparisurunid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsiparismustid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Siparis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis Kayıt Ekranı";
            this.Load += new System.EventHandler(this.Siparis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsiparisfiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsiparisadet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnmstekle;
        public System.Windows.Forms.TextBox txtsiparismustid;
        public System.Windows.Forms.TextBox txtsiparisurunid;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}