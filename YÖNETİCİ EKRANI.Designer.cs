namespace Yapısal_Projeyi
{
    partial class YÖNETİCİEKRANI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YÖNETİCİEKRANI));
            toolStrip1 = new ToolStrip();
            btnyöneticiekle = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnişçiler = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnbaşvurular = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnçıkış = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnyöneticiekle, toolStripSeparator1, btnişçiler, toolStripSeparator2, btnbaşvurular, toolStripSeparator3, btnçıkış, toolStripSeparator4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1282, 55);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnyöneticiekle
            // 
            btnyöneticiekle.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnyöneticiekle.Image = (Image)resources.GetObject("btnyöneticiekle.Image");
            btnyöneticiekle.ImageScaling = ToolStripItemImageScaling.None;
            btnyöneticiekle.ImageTransparentColor = Color.Magenta;
            btnyöneticiekle.Name = "btnyöneticiekle";
            btnyöneticiekle.Size = new Size(200, 52);
            btnyöneticiekle.Text = "YÖNETİCİ EKLE";
            btnyöneticiekle.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 55);
            // 
            // btnişçiler
            // 
            btnişçiler.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnişçiler.Image = (Image)resources.GetObject("btnişçiler.Image");
            btnişçiler.ImageScaling = ToolStripItemImageScaling.None;
            btnişçiler.ImageTransparentColor = Color.Magenta;
            btnişçiler.Name = "btnişçiler";
            btnişçiler.Size = new Size(170, 52);
            btnişçiler.Text = "ÇALIŞANLAR";
            btnişçiler.Click += btnişçiler_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 55);
            // 
            // btnbaşvurular
            // 
            btnbaşvurular.Font = new Font("Century", 9.75F, FontStyle.Bold);
            btnbaşvurular.Image = (Image)resources.GetObject("btnbaşvurular.Image");
            btnbaşvurular.ImageScaling = ToolStripItemImageScaling.None;
            btnbaşvurular.ImageTransparentColor = Color.Magenta;
            btnbaşvurular.Name = "btnbaşvurular";
            btnbaşvurular.Size = new Size(178, 52);
            btnbaşvurular.Text = "BAŞVURULAR";
            btnbaşvurular.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 55);
            // 
            // btnçıkış
            // 
            btnçıkış.Font = new Font("Century", 9.75F, FontStyle.Bold);
            btnçıkış.Image = (Image)resources.GetObject("btnçıkış.Image");
            btnçıkış.ImageScaling = ToolStripItemImageScaling.None;
            btnçıkış.ImageTransparentColor = Color.Magenta;
            btnçıkış.Name = "btnçıkış";
            btnçıkış.Size = new Size(131, 52);
            btnçıkış.Text = "  ÇIKIŞ   ";
            btnçıkış.Click += btnçıkış_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 55);
            // 
            // toolStripButton5
            // 
            toolStripButton5.Alignment = ToolStripItemAlignment.Right;
            toolStripButton5.Font = new Font("Century", 9.75F, FontStyle.Bold);
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(52, 52);
            toolStripButton5.TextDirection = ToolStripTextDirection.Horizontal;
            toolStripButton5.TextImageRelation = TextImageRelation.TextBeforeImage;
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // YÖNETİCİEKRANI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1282, 853);
            Controls.Add(toolStrip1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "YÖNETİCİEKRANI";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            TransparencyKey = Color.Black;
            Load += YÖNETİCİEKRANI_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnyöneticiekle;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnişçiler;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnçıkış;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton btnbaşvurular;
    }
}