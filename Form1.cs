using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KANBAN
{
    public partial class Form1 : Form
    {
        private DataBaseKontrol dataBaseKontrol;
        public DataBaseKontrol DataBaseKontrol { get => dataBaseKontrol; set => dataBaseKontrol = value; }

        public Form1()
        {
            InitializeComponent();
        }

        int formBorderWidthOffset;
        int formBorderandCaptionHeightOffset;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBaseKontrol = new DataBaseKontrol();
            DataBaseKontrol.MenuleriDoldur();

            formBorderWidthOffset = (SystemInformation.Border3DSize.Width * 2);
            formBorderandCaptionHeightOffset = (SystemInformation.CaptionHeight + SystemInformation.Border3DSize.Height * 2 + SystemInformation.BorderSize.Width);

            foreach (string kanban in dataBaseKontrol.Kanbanlar)
            {
                System.Windows.Forms.ToolStripMenuItem kanbanTahtasi = new System.Windows.Forms.ToolStripMenuItem();
                kanbanTahtasi.Text = kanban;
                kanbanlarToolStripMenuItem.DropDownItems.Add(kanbanTahtasi);
                kanbanTahtasi.Click += new EventHandler(MenuItemClickHandler);
            }

            notOlusturToolStripMenuItem.Enabled = false;

        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {

            AcikFormlariKapat();

            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            KanbanFormu kanbanFormu = new KanbanFormu();
            kanbanFormu.MdiParent = this;
            this.SetClientSizeCore(kanbanFormu.Width + formBorderWidthOffset, kanbanFormu.Height + formBorderandCaptionHeightOffset);
            kanbanFormu.Name = clickedItem.Text;
            kanbanFormu.Dock = DockStyle.Fill;
            kanbanFormu.Show();

        }


        private void notOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
                NotEkle notEkle = new NotEkle(this.ActiveMdiChild.Name, this.ActiveMdiChild.Width, this.ActiveMdiChild.Height);
                AcikFormlariKapat();
                notEkle.MdiParent = this;
                this.SetClientSizeCore(notEkle.Width + formBorderWidthOffset, notEkle.Height + formBorderandCaptionHeightOffset);
                notEkle.Dock = DockStyle.Fill;
                notEkle.Show();
        }

        private void kanbanOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcikFormlariKapat();

            KanbanAdi kanbanAdi = new KanbanAdi(this);
            kanbanAdi.ShowDialog();

            kanbanlarToolStripMenuItem.DropDownItems.Clear();

            foreach (string kanban in dataBaseKontrol.Kanbanlar)
            {
                System.Windows.Forms.ToolStripMenuItem kanbanTahtasi = new System.Windows.Forms.ToolStripMenuItem();
                kanbanTahtasi.Text = kanban;
                kanbanlarToolStripMenuItem.DropDownItems.Add(kanbanTahtasi);
            
                kanbanTahtasi.Click += new EventHandler(MenuItemClickHandler);
            }

        }

        private void AcikFormlariKapat()
        {
            notOlusturToolStripMenuItem.Enabled = false;
            Form[] formArray = this.MdiChildren;
            foreach (Form form in formArray)
            {
                form.Close();
            }
        }


    }
}
