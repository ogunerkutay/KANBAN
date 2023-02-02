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
    public partial class NotEkle : Form
    {
        private DataBaseKontrol dataBaseKontrol;
        Form1 form1;
        string formName;
        int width;
        int height;
        public NotEkle(string formName,int width,int height)
        {
            InitializeComponent();
            this.formName = formName;
            this.width = width;
            this.height = height;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = (150 - textBox1.Text.Length).ToString();

        }

        private void NotEkle_Load(object sender, EventArgs e)
        {
            form1 = (Form1)this.MdiParent;
            this.dataBaseKontrol = form1.DataBaseKontrol;
            this.Name = "Not Oluştur";
            this.MdiParent.Text = this.Name;
            textBox1.MaxLength = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    dataBaseKontrol.KanbanKayitlari.ElementAt(dataBaseKontrol.Kanbanlar.IndexOf(formName)).Yapilacaklar.Add(textBox1.Text);
                }
                catch (Exception)
                {
                    KanbanTahtasi kanban = new KanbanTahtasi();
                    int index = 0;
                    foreach (var kanbanListeleri in kanban.GetType().GetProperties())
                    {
                        kanbanListeleri.SetValue(kanban, new List<string>());
                        index++;
                    }
                    kanban.Yapilacaklar.Add(textBox1.Text);
                    kanban.Yapiyorum.Add("");
                    kanban.Yaptim.Add("");
                    dataBaseKontrol.KanbanKayitlari.Add(kanban);
                }

                KanbanFormu kanbanFormu = new KanbanFormu();
                kanbanFormu.MdiParent = form1;
                kanbanFormu.Width = width;
                kanbanFormu.Height = height;
                kanbanFormu.Name = formName;
                kanbanFormu.Dock = DockStyle.Fill;
                kanbanFormu.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Bir not giriniz!");
            }
        }
    }
}
