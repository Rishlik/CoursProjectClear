using CoursProjectClear.Classes;
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

namespace CoursProjectClear.Pages
{
    /// <summary>
    /// Логика взаимодействия для NavigMenuPage.xaml
    /// </summary>
    public partial class NavigMenuPage : Page
    {
        public NavigMenuPage()
        {
            InitializeComponent();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new HistoryPage());
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new ProductPage());
        }

        private void Calen_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new CalendPage());
        }

        private void Basket_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new BasketPage());
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new SettingPage());
        }

        private void Printing_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new PrintPage());
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new SeactionsPage());
        }
    }
}
