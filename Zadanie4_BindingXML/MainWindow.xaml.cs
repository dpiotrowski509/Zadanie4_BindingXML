using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml;
using Zadanie4_BindingXML.XML;

namespace Zadanie4_BindingXML
{
    /*
      Projekt na zaliczneie z programowania .NET
      Autor: Damian Piotrowski
      Grupa: ININ3_PR1
      Album: 63172
     */
    public partial class MainWindow : Window
    {
        private XmlElement currentItem;
        public MainWindow()
        {
            InitializeComponent();
            LoadXMLPathToResources();
        }

        private void LoadXMLPathToResources()
        {
            var XmlData = (XmlDataProvider)Application.Current.Resources["XmlData"];
            XmlData.Source = new Uri(new FileInfo("example.xml").FullName);
        }
        private void OpenCategory(object sender, RoutedEventArgs e)
        {
            SubcategoryWindow subcategoryWindow = new SubcategoryWindow(currentItem);
            subcategoryWindow.Show();
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
