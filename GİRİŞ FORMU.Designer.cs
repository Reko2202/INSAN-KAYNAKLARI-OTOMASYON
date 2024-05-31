namespace Yapısal_Projeyi
{
    partial class GİRİŞFORMU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GİRİŞFORMU));
            panel1 = new Panel();
            frmdlbtn = new Button();
            label3 = new Label();
            iptalbtn = new Button();
            göstercheckbox = new CheckBox();
            girişbtn = new Button();
            şifretextBox = new TextBox();
            kullancıadıtextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(frmdlbtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(iptalbtn);
            panel1.Controls.Add(göstercheckbox);
            panel1.Controls.Add(girişbtn);
            panel1.Controls.Add(şifretextBox);
            panel1.Controls.Add(kullancıadıtextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 561);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // frmdlbtn
            // 
            frmdlbtn.Font = new Font("Century", 12F, FontStyle.Bold);
            frmdlbtn.Location = new Point(135, 363);
            frmdlbtn.Name = "frmdlbtn";
            frmdlbtn.Size = new Size(172, 28);
            frmdlbtn.TabIndex = 17;
            frmdlbtn.Text = "FORM DOLDUR";
            frmdlbtn.UseVisualStyleBackColor = true;
            frmdlbtn.Click += frmdlbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(153, 31);
            label3.Name = "label3";
            label3.Size = new Size(136, 33);
            label3.TabIndex = 16;
            label3.Text = "G İ R İ Ş";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // iptalbtn
            // 
            iptalbtn.Font = new Font("Century", 12F, FontStyle.Bold);
            iptalbtn.Location = new Point(224, 326);
            iptalbtn.Name = "iptalbtn";
            iptalbtn.Size = new Size(83, 31);
            iptalbtn.TabIndex = 15;
            iptalbtn.Text = "İptal";
            iptalbtn.UseVisualStyleBackColor = true;
            iptalbtn.Click += iptalbtn_Click;
            // 
            // göstercheckbox
            // 
            göstercheckbox.AutoSize = true;
            göstercheckbox.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            göstercheckbox.Location = new Point(281, 268);
            göstercheckbox.Name = "göstercheckbox";
            göstercheckbox.Size = new Size(81, 22);
            göstercheckbox.TabIndex = 14;
            göstercheckbox.Text = "Göster";
            göstercheckbox.UseVisualStyleBackColor = true;
            göstercheckbox.CheckedChanged += göstercheckbox_CheckedChanged;
            // 
            // girişbtn
            // 
            girişbtn.Font = new Font("Century", 12F, FontStyle.Bold);
            girişbtn.Location = new Point(135, 326);
            girişbtn.Name = "girişbtn";
            girişbtn.Size = new Size(83, 31);
            girişbtn.TabIndex = 13;
            girişbtn.Text = "Giriş";
            girişbtn.UseVisualStyleBackColor = true;
            girişbtn.Click += girişbtn_Click;
            // 
            // şifretextBox
            // 
            şifretextBox.Location = new Point(134, 229);
            şifretextBox.Name = "şifretextBox";
            şifretextBox.Size = new Size(231, 23);
            şifretextBox.TabIndex = 12;
            şifretextBox.TextChanged += şifretextBox_TextChanged;
            // 
            // kullancıadıtextBox
            // 
            kullancıadıtextBox.Location = new Point(134, 172);
            kullancıadıtextBox.Name = "kullancıadıtextBox";
            kullancıadıtextBox.Size = new Size(231, 23);
            kullancıadıtextBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 229);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 10;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 172);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 9;
            label1.Text = "Kullancı adı";
            // 
            // GİRİŞFORMU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 561);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GİRİŞFORMU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIGN IN";
            Resize += GirişFormu_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button frmdlbtn;
        private Label label3;
        private Button iptalbtn;
        private CheckBox göstercheckbox;
        private Button girişbtn;
        private TextBox şifretextBox;
        private TextBox kullancıadıtextBox;
        private Label label2;
        private Label label1;
    }
}
