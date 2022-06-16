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
using System.Xml;

namespace Zadanie4_BindingXML
{
    /// <summary>
    /// Logika interakcji dla klasy SubcategoryWindow.xaml
    /// </summary>
    public partial class SubcategoryWindow : Window
    {
        XmlElement currentItem;
        public SubcategoryWindow(XmlElement element)
        {
            InitializeComponent();
            DataContext = element;
        }
        private void OpenCategory(object sender, RoutedEventArgs e)
        {
            DataGridWindow dataGridWindow = new DataGridWindow(currentItem);
            dataGridWindow.Show();
        }
        private void GetCurrentItem(object sender, RoutedEventArgs e)
        {
            try
            {
                var list = (ListView)sender;
                currentItem = (XmlElement)list.SelectedItem;
            }
            catch (Exception ex) { }
        }
    }
}
