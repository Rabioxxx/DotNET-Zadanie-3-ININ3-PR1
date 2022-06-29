using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Zadanie_3_ININ3_PR1
{
    internal class Model
    {
        public LinkedList<MainListEntry> MainList { get; set; } = new LinkedList<MainListEntry>(new MainListEntry[]
        {
            new MainListEntry(
                "Transformers",
                "Michael Bay",
                "IDW Publishing",
                "Blu ray disc",
                DateTime.Parse("12.05.2007")
                )
        });

        internal MainListEntry AddNewEntry()
        {
            MainListEntry entry = new MainListEntry();
            MainList.AddLast(entry);
            return entry;
        }
    }
}
