namespace tobb_bkk
{
    partial class frmvasarlas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvasarlas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txvondb = new TextBox();
            txteljdb = new TextBox();
            txdiakdb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            lbfizetendo = new Label();
            lbvonossz = new Label();
            lbteljossz = new Label();
            lbdiakossz = new Label();
            btfiz = new Button();
            btelv = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Vonaljegy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Tejlesárú bérlet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 117);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Diák bérlet";
            // 
            // txvondb
            // 
            txvondb.Location = new Point(83, 29);
            txvondb.Name = "txvondb";
            txvondb.Size = new Size(100, 23);
            txvondb.TabIndex = 3;
            // 
            // txteljdb
            // 
            txteljdb.Location = new Point(111, 71);
            txteljdb.Name = "txteljdb";
            txteljdb.Size = new Size(100, 23);
            txteljdb.TabIndex = 4;
            // 
            // txdiakdb
            // 
            txdiakdb.Location = new Point(92, 114);
            txdiakdb.Name = "txdiakdb";
            txdiakdb.Size = new Size(100, 23);
            txdiakdb.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 32);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 6;
            label4.Text = "db";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 74);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 7;
            label5.Text = "db";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 117);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 8;
            label6.Text = "db";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbdiakossz);
            panel1.Controls.Add(lbteljossz);
            panel1.Controls.Add(lbvonossz);
            panel1.Controls.Add(lbfizetendo);
            panel1.Location = new Point(26, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 136);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // lbfizetendo
            // 
            lbfizetendo.AutoSize = true;
            lbfizetendo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbfizetendo.ForeColor = Color.Red;
            lbfizetendo.Location = new Point(6, 12);
            lbfizetendo.Name = "lbfizetendo";
            lbfizetendo.Size = new Size(57, 21);
            lbfizetendo.TabIndex = 0;
            lbfizetendo.Text = "label7";
            // 
            // lbvonossz
            // 
            lbvonossz.AutoSize = true;
            lbvonossz.Location = new Point(23, 44);
            lbvonossz.Name = "lbvonossz";
            lbvonossz.Size = new Size(40, 15);
            lbvonossz.TabIndex = 1;
            lbvonossz.Text = "label8";
            // 
            // lbteljossz
            // 
            lbteljossz.AutoSize = true;
            lbteljossz.Location = new Point(23, 76);
            lbteljossz.Name = "lbteljossz";
            lbteljossz.Size = new Size(40, 15);
            lbteljossz.TabIndex = 2;
            lbteljossz.Text = "label9";
            // 
            // lbdiakossz
            // 
            lbdiakossz.AutoSize = true;
            lbdiakossz.Location = new Point(23, 109);
            lbdiakossz.Name = "lbdiakossz";
            lbdiakossz.Size = new Size(47, 15);
            lbdiakossz.TabIndex = 3;
            lbdiakossz.Text = "label10";
            // 
            // btfiz
            // 
            btfiz.Image = (Image)resources.GetObject("btfiz.Image");
            btfiz.ImageAlign = ContentAlignment.MiddleRight;
            btfiz.Location = new Point(7, 353);
            btfiz.Name = "btfiz";
            btfiz.Size = new Size(123, 28);
            btfiz.TabIndex = 10;
            btfiz.Text = "Fizetés";
            btfiz.UseVisualStyleBackColor = true;
            // 
            // btelv
            // 
            btelv.Image = Properties.Resources.elvet;
            btelv.ImageAlign = ContentAlignment.MiddleRight;
            btelv.Location = new Point(136, 353);
            btelv.Name = "btelv";
            btelv.Size = new Size(123, 28);
            btelv.TabIndex = 11;
            btelv.Text = "Elvet";
            btelv.UseVisualStyleBackColor = true;
            // 
            // frmvasarlas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 394);
            Controls.Add(btelv);
            Controls.Add(btfiz);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txdiakdb);
            Controls.Add(txteljdb);
            Controls.Add(txvondb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "frmvasarlas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Jegy és Bérlet vásárlás";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txvondb;
        private TextBox txteljdb;
        private TextBox txdiakdb;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label lbdiakossz;
        private Label lbteljossz;
        private Label lbvonossz;
        private Label lbfizetendo;
        private Button btfiz;
        private Button btelv;
    }
}