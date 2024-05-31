namespace Yapısal_Projeyi
{
    partial class BAŞVURULAR
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            idtxt = new TextBox();
            label2 = new Label();
            başvurulargridview = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)başvurulargridview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(idtxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(başvurulargridview);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 550);
            panel1.TabIndex = 0;
            // 
            // idtxt
            // 
            idtxt.Location = new Point(50, 150);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(174, 22);
            idtxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 150);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // başvurulargridview
            // 
            başvurulargridview.AllowUserToAddRows = false;
            başvurulargridview.AllowUserToDeleteRows = false;
            başvurulargridview.AllowUserToResizeColumns = false;
            başvurulargridview.AllowUserToResizeRows = false;
            başvurulargridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            başvurulargridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            başvurulargridview.BackgroundColor = Color.White;
            başvurulargridview.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            başvurulargridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            başvurulargridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            başvurulargridview.DefaultCellStyle = dataGridViewCellStyle2;
            başvurulargridview.Location = new Point(4, 197);
            başvurulargridview.Name = "başvurulargridview";
            başvurulargridview.Size = new Size(993, 350);
            başvurulargridview.TabIndex = 3;
            başvurulargridview.CellMouseClick += başvurulargridview_CellMouseClick;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 12F, FontStyle.Bold);
            button2.ForeColor = Color.DarkRed;
            button2.Location = new Point(370, 145);
            button2.Name = "button2";
            button2.Size = new Size(126, 31);
            button2.TabIndex = 2;
            button2.Text = "REDDET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Century", 12F, FontStyle.Bold);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(240, 145);
            button1.Name = "button1";
            button1.Size = new Size(126, 31);
            button1.TabIndex = 1;
            button1.Text = "KABUL ET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 33);
            label1.TabIndex = 0;
            label1.Text = "BAŞVURULAR";
            // 
            // BAŞVURULAR
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 550);
            Controls.Add(panel1);
            Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BAŞVURULAR";
            Text = "BAŞVURULAR";
            Load += BAŞVURULAR_Load;
            Resize += BAŞVURULAR_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)başvurulargridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private DataGridView başvurulargridview;
        private TextBox idtxt;
        private Label label2;
    }
}