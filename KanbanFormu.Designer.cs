namespace KANBAN
{
    partial class KanbanFormu
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
            this.listBoxYapacaklarim = new System.Windows.Forms.ListBox();
            this.listBoxYapiyorum = new System.Windows.Forms.ListBox();
            this.listBoxYaptim = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxYapacaklarim
            // 
            this.listBoxYapacaklarim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxYapacaklarim.FormattingEnabled = true;
            this.listBoxYapacaklarim.ItemHeight = 25;
            this.listBoxYapacaklarim.Location = new System.Drawing.Point(12, 46);
            this.listBoxYapacaklarim.Name = "listBoxYapacaklarim";
            this.listBoxYapacaklarim.Size = new System.Drawing.Size(260, 429);
            this.listBoxYapacaklarim.TabIndex = 0;
            this.listBoxYapacaklarim.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.listBoxYapacaklarim.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.listBoxYapacaklarim.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.listBoxYapacaklarim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // listBoxYapiyorum
            // 
            this.listBoxYapiyorum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxYapiyorum.FormattingEnabled = true;
            this.listBoxYapiyorum.ItemHeight = 25;
            this.listBoxYapiyorum.Location = new System.Drawing.Point(272, 46);
            this.listBoxYapiyorum.Name = "listBoxYapiyorum";
            this.listBoxYapiyorum.Size = new System.Drawing.Size(260, 429);
            this.listBoxYapiyorum.TabIndex = 1;
            this.listBoxYapiyorum.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.listBoxYapiyorum.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.listBoxYapiyorum.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.listBoxYapiyorum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // listBoxYaptim
            // 
            this.listBoxYaptim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxYaptim.FormattingEnabled = true;
            this.listBoxYaptim.ItemHeight = 25;
            this.listBoxYaptim.Location = new System.Drawing.Point(532, 46);
            this.listBoxYaptim.Name = "listBoxYaptim";
            this.listBoxYaptim.Size = new System.Drawing.Size(260, 429);
            this.listBoxYaptim.TabIndex = 2;
            this.listBoxYaptim.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.listBoxYaptim.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.listBoxYaptim.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.listBoxYaptim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yapacaklarım";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(339, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yapıyorum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(619, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yaptım";
            // 
            // KanbanFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxYaptim);
            this.Controls.Add(this.listBoxYapiyorum);
            this.Controls.Add(this.listBoxYapacaklarim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KanbanFormu";
            this.Load += new System.EventHandler(this.KanbanFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxYapacaklarim;
        private System.Windows.Forms.ListBox listBoxYapiyorum;
        private System.Windows.Forms.ListBox listBoxYaptim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}