namespace Yapısal_Projeyi
{
    partial class YÖNETİCİEKLEMEFORMU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YÖNETİCİEKLEMEFORMU));
            deletbtn = new Button();
            editbtn = new Button();
            addbtn = new Button();
            namelbl = new Label();
            usernamelbl = new Label();
            passwordlbl = new Label();
            Userinfo = new DataGridView();
            nametxt = new TextBox();
            usernametxt = new TextBox();
            passtxt = new TextBox();
            resizepanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Userinfo).BeginInit();
            resizepanel.SuspendLayout();
            SuspendLayout();
            // 
            // deletbtn
            // 
            deletbtn.Font = new Font("Century", 12F, FontStyle.Bold);
            deletbtn.Location = new Point(346, 359);
            deletbtn.Name = "deletbtn";
            deletbtn.Size = new Size(112, 28);
            deletbtn.TabIndex = 0;
            deletbtn.Text = "SİL";
            deletbtn.UseVisualStyleBackColor = true;
            deletbtn.Click += deletbtn_Click;
            // 
            // editbtn
            // 
            editbtn.Font = new Font("Century", 12F, FontStyle.Bold);
            editbtn.Location = new Point(228, 359);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(112, 28);
            editbtn.TabIndex = 1;
            editbtn.Text = "DÜZENLE";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // addbtn
            // 
            addbtn.Font = new Font("Century", 12F, FontStyle.Bold);
            addbtn.Location = new Point(110, 359);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(112, 28);
            addbtn.TabIndex = 2;
            addbtn.Text = "EKLE";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Century", 12F, FontStyle.Bold);
            namelbl.Location = new Point(186, 129);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(35, 20);
            namelbl.TabIndex = 4;
            namelbl.Text = "AD";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Century", 12F, FontStyle.Bold);
            usernamelbl.Location = new Point(74, 199);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(147, 20);
            usernamelbl.TabIndex = 5;
            usernamelbl.Text = "KULLANCI ADI";
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Font = new Font("Century", 12F, FontStyle.Bold);
            passwordlbl.Location = new Point(155, 269);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(66, 20);
            passwordlbl.TabIndex = 6;
            passwordlbl.Text = "ŞİFRE";
            // 
            // Userinfo
            // 
            Userinfo.AllowUserToAddRows = false;
            Userinfo.AllowUserToDeleteRows = false;
            Userinfo.AllowUserToResizeColumns = false;
            Userinfo.AllowUserToResizeRows = false;
            Userinfo.BackgroundColor = Color.White;
            Userinfo.BorderStyle = BorderStyle.None;
            Userinfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Userinfo.Location = new Point(513, 129);
            Userinfo.Name = "Userinfo";
            Userinfo.ReadOnly = true;
            Userinfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Userinfo.Size = new Size(414, 294);
            Userinfo.TabIndex = 7;
            Userinfo.CellContentClick += Userinfo_CellContentClick;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(227, 127);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(231, 22);
            nametxt.TabIndex = 8;
            nametxt.TextChanged += nametxt_TextChanged;
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(227, 197);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(231, 22);
            usernametxt.TabIndex = 9;
            // 
            // passtxt
            // 
            passtxt.Location = new Point(227, 267);
            passtxt.Name = "passtxt";
            passtxt.Size = new Size(231, 22);
            passtxt.TabIndex = 10;
            // 
            // resizepanel
            // 
            resizepanel.Controls.Add(label2);
            resizepanel.Controls.Add(label1);
            resizepanel.Controls.Add(passtxt);
            resizepanel.Controls.Add(usernametxt);
            resizepanel.Controls.Add(nametxt);
            resizepanel.Controls.Add(Userinfo);
            resizepanel.Controls.Add(passwordlbl);
            resizepanel.Controls.Add(usernamelbl);
            resizepanel.Controls.Add(namelbl);
            resizepanel.Controls.Add(addbtn);
            resizepanel.Controls.Add(editbtn);
            resizepanel.Controls.Add(deletbtn);
            resizepanel.Location = new Point(0, 0);
            resizepanel.Name = "resizepanel";
            resizepanel.Size = new Size(1000, 550);
            resizepanel.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(424, 33);
            label1.TabIndex = 12;
            label1.Text = "YÖNETİCİ EKLEME FORMU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(513, 87);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 13;
            label2.Text = "Yöneticiler";
            // 
            // YÖNETİCİEKLEMEFORMU
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 550);
            Controls.Add(resizepanel);
            Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YÖNETİCİEKLEMEFORMU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YÖNETİCİLER";
            Load += YÖNETİCİFORMU_Load;
            Resize += YÖNETİCİFORMU_Resize;
            ((System.ComponentModel.ISupportInitialize)Userinfo).EndInit();
            resizepanel.ResumeLayout(false);
            resizepanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button deletbtn;
        private Button editbtn;
        private Button addbtn;
        private Label namelbl;
        private Label usernamelbl;
        private Label passwordlbl;
        private DataGridView Userinfo;
        private TextBox nametxt;
        private TextBox usernametxt;
        private TextBox passtxt;
        private Panel resizepanel;
        private Label label1;
        private Label label2;
    }
}