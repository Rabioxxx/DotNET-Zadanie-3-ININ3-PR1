using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Zadanie_3_ININ3_PR1
{
    internal class MainListEntry : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly static Dictionary<string, string[]> relatedProperties = new Dictionary<string, string[]>()
        {
            ["Title"] = new string[] { "Title", "ListFormat" },
            ["Director"] = new string[] { "Director", "ListFormat" },
            ["Publisher"] = new string[] { "Publisher", "ListFormat" },
            ["DataMedium"] = new string[] { "DataMedium", "ListFormat" },
            ["Premiere"] = new string[] { "Premiere", "ListFormat" }
        };

        void OnPropertyChanged([CallerMemberName] string? property = null, HashSet<string>? fixedProperties = null)
        {
            if (fixedProperties == null)
            {
                fixedProperties = new HashSet<string>();
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            fixedProperties.Add(property);

            if (relatedProperties.ContainsKey(property))
            {
                foreach (string linkedProperty in relatedProperties[property])
                {
                    if (!fixedProperties.Contains(linkedProperty))
                        OnPropertyChanged(linkedProperty, fixedProperties);
                }
            }
        }

        string title, director, publisher, dataMedium, premiere;

        public string RecordDetails => $"{title}";

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }
        public string Director
        {
            get => director;
            set
            {
                director = value;
                OnPropertyChanged();
            }
        }
        public string Publisher
        {
            get => publisher;
            set
            {
                publisher = value;
                OnPropertyChanged();
            }
        }
        public string DataMedium
        {
            get => dataMedium;
            set
            {
                dataMedium = value;
                OnPropertyChanged();
            }
        }
        public string Premiere
        {
            get => premiere;
            set
            {
                premiere = value;
                OnPropertyChanged();
            }
        }

        public MainListEntry(string title, string director, string publisher, string dataMedium, string premiere)
        {
            Title = title;
            Director = director;
            Publisher = publisher;
            DataMedium = dataMedium;
            Premiere = premiere;
        }
    }
}
