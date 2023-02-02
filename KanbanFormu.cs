using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KANBAN
{
    public partial class KanbanFormu : Form
    {

        private DataBaseKontrol dataBaseKontrol;

        Form1 form1;

        KanbanTahtasi kanban;
        public KanbanFormu()
        {
            InitializeComponent();
        }

        private void KanbanFormu_Load(object sender, EventArgs e)
        {
            form1 = (Form1)this.MdiParent;
            this.dataBaseKontrol = form1.DataBaseKontrol;
            form1.notOlusturToolStripMenuItem.Enabled = true;
            

            this.MdiParent.Text = this.Name;

            try
            {
                 kanban = dataBaseKontrol.KanbanKayitlari[dataBaseKontrol.Kanbanlar.IndexOf(this.Name)];
            }
            catch (Exception)
            {
                kanban = new KanbanTahtasi();
                kanban.Yapilacaklar = new List<string>();
                kanban.Yapiyorum = new List<string>();
                kanban.Yaptim = new List<string>();
                dataBaseKontrol.KanbanKayitlari.Add(kanban);
            }

            listBoxYapacaklarim.DataSource = kanban.Yapilacaklar;
            listBoxYapiyorum.DataSource = kanban.Yapiyorum;
            listBoxYaptim.DataSource = kanban.Yaptim;

            listBoxYapacaklarim.AllowDrop = true;
            listBoxYapiyorum.AllowDrop = true;
            listBoxYaptim.AllowDrop = true;

            listBoxYapacaklarim.ClearSelected();
            listBoxYapiyorum.ClearSelected();
            listBoxYaptim.ClearSelected();


        }
        ListBox listbox_Item_Alinan;
        ListBox lstbox_Item_Birakilan;
        int Listbox_Index = 0;
        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            lstbox_Item_Birakilan = sender as ListBox;
            switch (lstbox_Item_Birakilan.Name)
            {
                case "listBoxYapacaklarim":
                    kanban.Yapilacaklar.Add(listbox_Item_Alinan.Items[Listbox_Index].ToString());
                    listBoxYapacaklarim.DataSource = null;
                    listBoxYapacaklarim.Items.Clear();
                    listBoxYapacaklarim.DataSource = kanban.Yapilacaklar;
                    break;
                case "listBoxYapiyorum":
                    kanban.Yapiyorum.Add(listbox_Item_Alinan.Items[Listbox_Index].ToString());
                    listBoxYapiyorum.DataSource = null;
                    listBoxYapiyorum.Items.Clear();
                    listBoxYapiyorum.DataSource = kanban.Yapiyorum;
                    break;
                case "listBoxYaptim":
                    kanban.Yaptim.Add(listbox_Item_Alinan.Items[Listbox_Index].ToString());
                    listBoxYaptim.DataSource = null;
                    listBoxYaptim.Items.Clear();
                    listBoxYaptim.DataSource = kanban.Yaptim;
                    break;
                default:
                    break;
            }

            switch (listbox_Item_Alinan.Name)
            {
                case "listBoxYapacaklarim":
                    kanban.Yapilacaklar.Remove(listbox_Item_Alinan.Items[Listbox_Index].ToString());
                    listBoxYapacaklarim.DataSource = null;
                    listBoxYapacaklarim.Items.Clear();
                    listBoxYapacaklarim.DataSource = kanban.Yapilacaklar;
                    break;
                case "listBoxYapiyorum":
                    kanban.Yapiyorum.Remove(listbox_Item_Alinan.Items[Listbox_Index].ToString());
                    listBoxYapiyorum.DataSource = null;
                    listBoxYapiyorum.Items.Clear();
                    listBoxYapiyorum.DataSource = kanban.Yapiyorum;
                    break;
                case "listBoxYaptim":
                    kanban.Yaptim.Remove(listbox_Item_Alinan.Items[Listbox_Index].ToString());
                    listBoxYaptim.DataSource = null;
                    listBoxYaptim.Items.Clear();
                    listBoxYaptim.DataSource = kanban.Yaptim;
                    break;
                default:
                    break;
            }
            dataBaseKontrol.KANBANLARIKAYDET();
            //lstbox_Item_Birakilan.Items.Add(listbox_Item_Alinan.Items[Listbox_Index]);
            //listbox_Item_Alinan.Items.Remove(listbox_Item_Alinan.Items[Listbox_Index]);
        }

        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.Move;
        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.All;
        }

        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            listbox_Item_Alinan = sender as ListBox;

            Point kor_nokta = new Point(e.X, e.Y);
            Listbox_Index = listbox_Item_Alinan.IndexFromPoint(kor_nokta);
                if (Listbox_Index == -1)
                {
                    listbox_Item_Alinan.ClearSelected();
                    return;
                }
            if (e.Button == MouseButtons.Left)
            listbox_Item_Alinan.DoDragDrop(listbox_Item_Alinan.Items[Listbox_Index].ToString(), DragDropEffects.All);
        }
    }
}
