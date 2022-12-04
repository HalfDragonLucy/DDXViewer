using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DDXViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MaxCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.PoorCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayBox = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.DisplayBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1512, 1061);
            this.MainPanel.TabIndex = 0;
            // 
            // MaxCompression
            // 
            this.MaxCompression.Name = "MaxCompression";
            this.MaxCompression.Size = new System.Drawing.Size(32, 19);
            // 
            // GoodCompression
            // 
            this.GoodCompression.Name = "GoodCompression";
            this.GoodCompression.Size = new System.Drawing.Size(32, 19);
            // 
            // MediumCompression
            // 
            this.MediumCompression.Name = "MediumCompression";
            this.MediumCompression.Size = new System.Drawing.Size(32, 19);
            // 
            // PoorCompression
            // 
            this.PoorCompression.Name = "PoorCompression";
            this.PoorCompression.Size = new System.Drawing.Size(32, 19);
            // 
            // DisplayBox
            // 
            this.DisplayBox.BackColor = System.Drawing.Color.Transparent;
            this.DisplayBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DisplayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayBox.Location = new System.Drawing.Point(0, 0);
            this.DisplayBox.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(1512, 1061);
            this.DisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayBox.TabIndex = 0;
            this.DisplayBox.TabStop = false;
            this.DisplayBox.WaitOnLoad = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1512, 1061);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox DisplayBox;
        private System.Windows.Forms.ToolStripMenuItem MaxCompression;
        private System.Windows.Forms.ToolStripMenuItem GoodCompression;
        private System.Windows.Forms.ToolStripMenuItem MediumCompression;
        private System.Windows.Forms.ToolStripMenuItem PoorCompression;
    }
}

