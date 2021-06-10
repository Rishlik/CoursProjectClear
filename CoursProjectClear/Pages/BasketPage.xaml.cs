using CoursProjectClear.Base;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace CoursProjectClear.Pages
{
    /// <summary>
    /// Логика взаимодействия для BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        public BasketPage()
        {
            InitializeComponent();
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            SaleComponentsEntities.getContext().ChangeTracker.Entries().ToList();
            Basket.ItemsSource = SaleComponentsEntities.getContext().Basket.ToList();
            Basket.ItemsSource = SaleComponentsEntities.getContext().Services.ToList();
            Basket.ItemsSource = SaleComponentsEntities.getContext().Components.ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            
        }

        

        private void Load_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
