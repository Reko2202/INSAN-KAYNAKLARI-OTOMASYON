namespace Yapısal_Projeyi
{
    partial class İŞÇİFORMU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İŞÇİFORMU));
            lbladsoyad = new Label();
            lbltelefon = new Label();
            lblcinsiyet = new Label();
            lblbolum = new Label();
            lbldogumtarihi = new Label();
            lblemail = new Label();
            mtadsoyad = new MaskedTextBox();
            mtdogumtarihi = new MaskedTextBox();
            mttelefon = new MaskedTextBox();
            mtemail = new MaskedTextBox();
            cbbolum = new ComboBox();
            resizepanel = new Panel();
            label2 = new Label();
            redchecklbl = new Label();
            label1 = new Label();
            emailwrnlbl = new Label();
            adsoyadwrnlbl = new Label();
            kaydetbtn = new Button();
            rberkek = new RadioButton();
            rbkadın = new RadioButton();
            resizepanel.SuspendLayout();
            SuspendLayout();
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Font = new Font("Century", 12F, FontStyle.Bold);
            lbladsoyad.Location = new Point(31, 97);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(103, 20);
            lbladsoyad.TabIndex = 1;
            lbladsoyad.Text = "AD-SOYAD";
            // 
            // lbltelefon
            // 
            lbltelefon.AutoSize = true;
            lbltelefon.Font = new Font("Century", 12F, FontStyle.Bold);
            lbltelefon.Location = new Point(31, 289);
            lbltelefon.Name = "lbltelefon";
            lbltelefon.Size = new Size(130, 20);
            lbltelefon.TabIndex = 2;
            lbltelefon.Text = "TELEFON NO";
            // 
            // lblcinsiyet
            // 
            lblcinsiyet.AutoSize = true;
            lblcinsiyet.Font = new Font("Century", 12F, FontStyle.Bold);
            lblcinsiyet.Location = new Point(31, 225);
            lblcinsiyet.Name = "lblcinsiyet";
            lblcinsiyet.Size = new Size(100, 20);
            lblcinsiyet.TabIndex = 3;
            lblcinsiyet.Text = "CİNSİYET";
            // 
            // lblbolum
            // 
            lblbolum.AutoSize = true;
            lblbolum.Font = new Font("Century", 12F, FontStyle.Bold);
            lblbolum.Location = new Point(31, 417);
            lblbolum.Name = "lblbolum";
            lblbolum.Size = new Size(77, 20);
            lblbolum.TabIndex = 4;
            lblbolum.Text = "BÖLÜM";
            // 
            // lbldogumtarihi
            // 
            lbldogumtarihi.AutoSize = true;
            lbldogumtarihi.Font = new Font("Century", 12F, FontStyle.Bold);
            lbldogumtarihi.Location = new Point(31, 161);
            lbldogumtarihi.Name = "lbldogumtarihi";
            lbldogumtarihi.Size = new Size(151, 20);
            lbldogumtarihi.TabIndex = 5;
            lbldogumtarihi.Text = "DOĞUM TARİHİ";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Century", 12F, FontStyle.Bold);
            lblemail.Location = new Point(31, 353);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(77, 20);
            lblemail.TabIndex = 6;
            lblemail.Text = "E-MAİL";
            // 
            // mtadsoyad
            // 
            mtadsoyad.Font = new Font("Century", 12F, FontStyle.Bold);
            mtadsoyad.Location = new Point(223, 90);
            mtadsoyad.Name = "mtadsoyad";
            mtadsoyad.Size = new Size(280, 27);
            mtadsoyad.TabIndex = 7;
            // 
            // mtdogumtarihi
            // 
            mtdogumtarihi.Font = new Font("Century", 12F, FontStyle.Bold);
            mtdogumtarihi.Location = new Point(223, 154);
            mtdogumtarihi.Mask = "00/00/0000";
            mtdogumtarihi.Name = "mtdogumtarihi";
            mtdogumtarihi.Size = new Size(280, 27);
            mtdogumtarihi.TabIndex = 8;
            // 
            // mttelefon
            // 
            mttelefon.Font = new Font("Century", 12F, FontStyle.Bold);
            mttelefon.Location = new Point(223, 282);
            mttelefon.Mask = "(999) 000-0000";
            mttelefon.Name = "mttelefon";
            mttelefon.Size = new Size(280, 27);
            mttelefon.TabIndex = 10;
            // 
            // mtemail
            // 
            mtemail.Font = new Font("Century", 12F, FontStyle.Bold);
            mtemail.Location = new Point(223, 346);
            mtemail.Name = "mtemail";
            mtemail.Size = new Size(280, 27);
            mtemail.TabIndex = 11;
            // 
            // cbbolum
            // 
            cbbolum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbolum.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbolum.Font = new Font("Century", 12F, FontStyle.Bold);
            cbbolum.FormattingEnabled = true;
            cbbolum.Items.AddRange(new object[] { "Finans ve Muhasebe", "İnsan Kaynakları", "Satış ve Pazarlama", "Üretim ve Operasyon", "Bilgi Teknolojileri", "AR-GE (Araştırma Geliştirme)", "Müşteri Hizmetleri", "Hukuk ve Uyum" });
            cbbolum.Location = new Point(223, 414);
            cbbolum.Name = "cbbolum";
            cbbolum.Size = new Size(280, 28);
            cbbolum.TabIndex = 12;
            // 
            // resizepanel
            // 
            resizepanel.BackColor = Color.Transparent;
            resizepanel.Controls.Add(label2);
            resizepanel.Controls.Add(redchecklbl);
            resizepanel.Controls.Add(label1);
            resizepanel.Controls.Add(emailwrnlbl);
            resizepanel.Controls.Add(adsoyadwrnlbl);
            resizepanel.Controls.Add(kaydetbtn);
            resizepanel.Controls.Add(rberkek);
            resizepanel.Controls.Add(rbkadın);
            resizepanel.Controls.Add(cbbolum);
            resizepanel.Controls.Add(mtemail);
            resizepanel.Controls.Add(mttelefon);
            resizepanel.Controls.Add(mtdogumtarihi);
            resizepanel.Controls.Add(mtadsoyad);
            resizepanel.Controls.Add(lblemail);
            resizepanel.Controls.Add(lbldogumtarihi);
            resizepanel.Controls.Add(lblbolum);
            resizepanel.Controls.Add(lblcinsiyet);
            resizepanel.Controls.Add(lbltelefon);
            resizepanel.Controls.Add(lbladsoyad);
            resizepanel.Location = new Point(0, 0);
            resizepanel.Name = "resizepanel";
            resizepanel.Size = new Size(1084, 601);
            resizepanel.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = Properties.Resources.Aniket_Suvarna_Box_Regular_Bx_arrow_back_32;
            label2.Location = new Point(11, 11);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 14;
            label2.Text = "        ";
            label2.Click += label2_Click;
            // 
            // redchecklbl
            // 
            redchecklbl.AutoSize = true;
            redchecklbl.ForeColor = Color.Black;
            redchecklbl.Location = new Point(1, 584);
            redchecklbl.Name = "redchecklbl";
            redchecklbl.Size = new Size(48, 16);
            redchecklbl.TabIndex = 18;
            redchecklbl.Text = "label3";
            redchecklbl.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 23);
            label1.Name = "label1";
            label1.Size = new Size(264, 33);
            label1.TabIndex = 14;
            label1.Text = "FORMU DOLDUR";
            // 
            // emailwrnlbl
            // 
            emailwrnlbl.AutoSize = true;
            emailwrnlbl.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailwrnlbl.Location = new Point(223, 381);
            emailwrnlbl.Name = "emailwrnlbl";
            emailwrnlbl.Size = new Size(210, 18);
            emailwrnlbl.TabIndex = 17;
            emailwrnlbl.Text = "( örenk.123 @ gmail.com )";
            emailwrnlbl.Visible = false;
            // 
            // adsoyadwrnlbl
            // 
            adsoyadwrnlbl.AutoSize = true;
            adsoyadwrnlbl.Location = new Point(223, 120);
            adsoyadwrnlbl.Name = "adsoyadwrnlbl";
            adsoyadwrnlbl.Size = new Size(264, 16);
            adsoyadwrnlbl.TabIndex = 16;
            adsoyadwrnlbl.Text = "( KİMLİKTE YAZILDIĞI GİBİ YAZINIZ )";
            adsoyadwrnlbl.Visible = false;
            // 
            // kaydetbtn
            // 
            kaydetbtn.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kaydetbtn.Location = new Point(397, 498);
            kaydetbtn.Name = "kaydetbtn";
            kaydetbtn.Size = new Size(287, 43);
            kaydetbtn.TabIndex = 15;
            kaydetbtn.Text = "KAYDET";
            kaydetbtn.UseVisualStyleBackColor = true;
            kaydetbtn.Click += button1_Click;
            // 
            // rberkek
            // 
            rberkek.AutoSize = true;
            rberkek.Font = new Font("Century", 12F, FontStyle.Bold);
            rberkek.Location = new Point(223, 221);
            rberkek.Name = "rberkek";
            rberkek.Size = new Size(92, 24);
            rberkek.TabIndex = 14;
            rberkek.TabStop = true;
            rberkek.Text = "ERKEK";
            rberkek.UseVisualStyleBackColor = true;
            rberkek.CheckedChanged += rberkek_CheckedChanged;
            // 
            // rbkadın
            // 
            rbkadın.AutoSize = true;
            rbkadın.Font = new Font("Century", 12F, FontStyle.Bold);
            rbkadın.Location = new Point(368, 221);
            rbkadın.Name = "rbkadın";
            rbkadın.Size = new Size(88, 24);
            rbkadın.TabIndex = 13;
            rbkadın.TabStop = true;
            rbkadın.Text = "KADIN";
            rbkadın.UseVisualStyleBackColor = true;
            rbkadın.CheckedChanged += rbkadın_CheckedChanged;
            // 
            // İŞÇİFORMU
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 601);
            Controls.Add(resizepanel);
            Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "İŞÇİFORMU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İŞÇİ BAŞVUR FORMU";
            Resize += İÇŞİFORMU_Resize;
            resizepanel.ResumeLayout(false);
            resizepanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbladsoyad;
        private Label lbltelefon;
        private Label lblcinsiyet;
        private Label lblbolum;
        private Label lbldogumtarihi;
        private Label lblemail;
        private MaskedTextBox mtadsoyad;
        private MaskedTextBox mtdogumtarihi;
        private MaskedTextBox mttelefon;
        private MaskedTextBox mtemail;
        private ComboBox cbbolum;
        private Panel resizepanel;
        private RadioButton rberkek;
        private RadioButton rbkadın;
        private Button kaydetbtn;
        private Label emailwrnlbl;
        private Label adsoyadwrnlbl;
        private Label label1;
        private Label label2;
        private Label redchecklbl;
    }
}