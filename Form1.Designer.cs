﻿namespace tobb_bkk
{
    partial class frmfo
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
            menuStrip1 = new MenuStrip();
            buszjegyÉsBérletToolStripMenuItem = new ToolStripMenuItem();
            vásárlásToolStripMenuItem = new ToolStripMenuItem();
            statisztikaToolStripMenuItem = new ToolStripMenuItem();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { buszjegyÉsBérletToolStripMenuItem, kilépésToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // buszjegyÉsBérletToolStripMenuItem
            // 
            buszjegyÉsBérletToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vásárlásToolStripMenuItem, statisztikaToolStripMenuItem });
            buszjegyÉsBérletToolStripMenuItem.Name = "buszjegyÉsBérletToolStripMenuItem";
            buszjegyÉsBérletToolStripMenuItem.Size = new Size(112, 20);
            buszjegyÉsBérletToolStripMenuItem.Text = "Buszjegy és bérlet";
            // 
            // vásárlásToolStripMenuItem
            // 
            vásárlásToolStripMenuItem.Name = "vásárlásToolStripMenuItem";
            vásárlásToolStripMenuItem.Size = new Size(126, 22);
            vásárlásToolStripMenuItem.Text = "Vásárlás";
            // 
            // statisztikaToolStripMenuItem
            // 
            statisztikaToolStripMenuItem.Name = "statisztikaToolStripMenuItem";
            statisztikaToolStripMenuItem.Size = new Size(126, 22);
            statisztikaToolStripMenuItem.Text = "Statisztika";
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(56, 20);
            kilépésToolStripMenuItem.Text = "Kilépés";
            kilépésToolStripMenuItem.Click += kilépésToolStripMenuItem_Click;
            // 
            // frmfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Főform";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem buszjegyÉsBérletToolStripMenuItem;
        private ToolStripMenuItem vásárlásToolStripMenuItem;
        private ToolStripMenuItem statisztikaToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
    }
}
