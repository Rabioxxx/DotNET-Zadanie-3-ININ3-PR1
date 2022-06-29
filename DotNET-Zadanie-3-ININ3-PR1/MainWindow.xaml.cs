using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DotNET_Zadanie_3_ININ3_PR1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model = new Model();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = model;
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            MainListEntry entry = model.AddNewEntry();
            ListBox entryList = (ListBox)FindName("mainList");
            entryList.ItemsSource = model.MainList;

            DetailsWindow detailsWindow = new DetailsWindow(entry);
            detailsWindow.Show();
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            ListBox entryList = (ListBox)FindName("mainList");
            MainListEntry x = (MainListEntry)entryList.SelectedItem;
            if (x != null)
            {
                (new DetailsWindow(x)).Show();
            }
        }
    }
}
