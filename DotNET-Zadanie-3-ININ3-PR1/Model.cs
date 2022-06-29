using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Zadanie_3_ININ3_PR1
{
    internal class Model
    {
        public ObservableCollection<MainListEntry> MainList { get; set; } = new ObservableCollection< MainListEntry>(new MainListEntry[]
        {
            new MainListEntry(
                "Transformers",
                "Michael Bay",
                "IDW Publishing",
                "Blu ray disc",
                DateTime.Parse("2.5.2007")
                ),
            new MainListEntry(
                "ABC",
                "TEST",
                "TESTing",
                "dvd disc",
                DateTime.Parse("12.10.2008")
                ),
        });

        internal MainListEntry AddNewEntry()
        {
            MainListEntry entry = new MainListEntry();
            MainList.Add(entry);
            return entry;
        }
    }
}
