using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KANBAN
{
    public class DataBaseKontrol
    {
        private List<string> kanbanlar = new List<string>();

        private List<KanbanTahtasi> kanbanKayitlari = new List<KanbanTahtasi>();

        public List<string> Kanbanlar { get => kanbanlar; set => kanbanlar = value; }
        public List<KanbanTahtasi> KanbanKayitlari { get => kanbanKayitlari; set => kanbanKayitlari = value; }


        public DataBaseKontrol()
        {

        }

        public void MenuleriDoldur()
        {
            if (File.Exists("Kanbanlar.txt"))
            {

                FileStream fileoku = null;
                StreamReader streamoku = null;

                try
                {
                    fileoku = new FileStream("Kanbanlar.txt", FileMode.OpenOrCreate, FileAccess.Read);
                    streamoku = new StreamReader(fileoku);

                    string okunan = streamoku.ReadLine();

                    while (okunan != null)
                    {
                        string kanban = okunan;

                        kanbanlar.Add(kanban);
                        okunan = streamoku.ReadLine();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    streamoku.Close();
                    streamoku = null;
                    fileoku.Close();
                    fileoku = null;
                }

            }

            if (File.Exists("Kanbankayitlari.txt"))
            {

                FileStream fileoku = null;
                StreamReader streamoku = null;

                try
                {
                    fileoku = new FileStream("Kanbankayitlari.txt", FileMode.Open, FileAccess.Read);
                    streamoku = new StreamReader(fileoku);

                    string okunan = streamoku.ReadLine();

                    while (okunan != null)
                    {
                        string[] kanbanListesi = okunan.Split(';');

                        KanbanTahtasi kanban = new KanbanTahtasi();

                        int index = 0;
                        foreach (var kanbanListeleri in kanban.GetType().GetProperties())
                        {
                            kanbanListeleri.SetValue(kanban, kanbanListesi[index].Split(',').ToList());
                            index++;
                        }

                        //kanban.Yapilacaklar = kanbanListesi[0];
                        //kanban.Yapiyorum = kanbanListesi[1];
                        //kanban.Yaptim = kanbanListesi[2];

                        kanbanKayitlari.Add(kanban);
                        okunan = streamoku.ReadLine();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    streamoku.Close();
                    streamoku = null;
                    fileoku.Close();
                    fileoku = null;
                }

            }
            else
            {
                KanbanTahtasi kanban = new KanbanTahtasi();
                kanbanKayitlari = new List<KanbanTahtasi>();
                kanbanKayitlari.Add(kanban);
            }
        }

        public void KANBANLARIKAYDET()
        {
            string filePath = "Kanbanlar.txt";
            FileStream fileyaz = null;
            StreamWriter streamyaz = null;
            try
            {
                fileyaz = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);
                streamyaz = new StreamWriter(fileyaz);
                foreach (string kanban in kanbanlar)
                {
                    streamyaz.WriteLine(kanban);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException + "\n" + ex.StackTrace);
            }
            finally
            {
                streamyaz.Close();
                streamyaz = null;
                fileyaz.Close();
                fileyaz = null;
                filePath = null;
            }
        }

        public void KAYITLARIKAYDET()
        {

            string filePath = "Kanbankayitlari.txt";

            StreamWriter streamyaz = null;
            try
            {
                streamyaz = new StreamWriter(filePath, false);
                foreach (KanbanTahtasi kanbankaydi in kanbanKayitlari)
                {
                    string Yapilacaklar = String.Join(",", kanbankaydi.Yapilacaklar);
                    string Yapiyorum = String.Join(",", kanbankaydi.Yapilacaklar);
                    string Yaptim = String.Join(",", kanbankaydi.Yapilacaklar);
                    streamyaz.WriteLine(String.Join(";", Yapilacaklar, Yapiyorum, Yaptim));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException + "\n" + ex.StackTrace);
            }
            finally
            {
                streamyaz.Close();
                streamyaz = null;
                filePath = null;
            }
        }








    }
}
