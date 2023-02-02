namespace KANBAN
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanbanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanbanOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kanbanlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kanbanOlusturToolStripMenuItem,
            this.notOlusturToolStripMenuItem
            });
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 24);
            this.toolStripMenuItem1.Text = "Menü";
            // 
            // notOluşturToolStripMenuItem
            // 
            this.notOlusturToolStripMenuItem.Name = "notOlusturToolStripMenuItem";
            this.notOlusturToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.notOlusturToolStripMenuItem.Text = "Not Oluştur";
            this.notOlusturToolStripMenuItem.Click += new System.EventHandler(this.notOluşturToolStripMenuItem_Click);
            // 
            // kanbanlarToolStripMenuItem
            // 
            this.kanbanlarToolStripMenuItem.Name = "kanbanlarToolStripMenuItem";
            this.kanbanlarToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.kanbanlarToolStripMenuItem.Text = "Kanbanlar";
            // 
            // kanbanOluşturToolStripMenuItem
            // 
            this.kanbanOlusturToolStripMenuItem.Name = "kanbanOluşturToolStripMenuItem";
            this.kanbanOlusturToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kanbanOlusturToolStripMenuItem.Text = "Kanban Oluştur";
            this.kanbanOlusturToolStripMenuItem.Click += new System.EventHandler(this.kanbanOluşturToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem notOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanbanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanbanOlusturToolStripMenuItem;
    }
}

