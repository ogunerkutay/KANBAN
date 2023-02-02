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
    public partial class KanbanAdi : Form
    {
        private DataBaseKontrol dataBaseKontrol;

        Form1 form1;
        public KanbanAdi(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void KanbanAdi_Load(object sender, EventArgs e)
        {
            this.dataBaseKontrol = form1.DataBaseKontrol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    if (textBox1.Text.Contains(';'))
                        throw new Exception("Kanban adınız ; içermemelidir.");
                    char[] alphaNumeric = "!@#$%^&*()_-+=[{]}:<>|./?".ToCharArray();
                    if (KarakterKontrol(textBox1.Text, alphaNumeric) == true)
                        throw new Exception("Kullanıcı adınız !@#$%^&*()_-+=[{]}:<>|./? gibi karakterler içermemelidir.");
                    if (!dataBaseKontrol.Kanbanlar.Contains(textBox1.Text))
                    {
                        dataBaseKontrol.Kanbanlar.Add(textBox1.Text);
                        dataBaseKontrol.KANBANLARIKAYDET();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Bu isimle kayıtlı bir kanban tahtasu mevcuttur");
                    }
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        public bool KarakterKontrol(string sifre, char[] karakterler)
        {
            int sayacKarakterler = 0;
            for (int i = 0; i < karakterler.Length; i++)
            {
                if (sifre.Contains(karakterler[i]))
                {
                    sayacKarakterler++;
                }

            }
            bool karakterVarMi = sayacKarakterler > 0 ? true : false;
            return karakterVarMi;
        }


    }
}
