using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KANBAN
{
    public class KanbanTahtasi
    {
        public List<string> Yapilacaklar { get; set; }
        public List<string> Yapiyorum { get; set; }
        public List<string> Yaptim { get; set; }

    }
}
