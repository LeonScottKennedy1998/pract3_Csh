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
using System.Windows.Shapes;

namespace pract3
{
    /// <summary>
    /// Логика взаимодействия для HistoryWindow.xaml
    /// </summary>
    public partial class HistoryWindow : Window
    {
        public string FilePath;
        public HistoryWindow()
        {
            InitializeComponent();
        }

        private void hist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilePath = hist.SelectedItem.ToString();
            DialogResult = true;
            Close();
        }


    }
}
