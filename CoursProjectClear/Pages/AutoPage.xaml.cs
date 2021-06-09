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
    /// Логика взаимодействия для AutoPage.xaml
    /// </summary>
    public partial class AutoPage : Page
    {
        public AutoPage()
        {
            InitializeComponent();
        }

        private void Auto_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new SectionsPage());
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new RegistPage());
        }
    }
}
