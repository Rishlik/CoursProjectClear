using CoursProjectClear.Base;
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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                SaleComponentsEntities.getContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            }
        }
        private void txtBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
        private void Update()
        {
            listViewTour.ItemsSource = SaleComponentsEntities.getContext().Components.ToList().Where(p => p.Name.ToLower().Contains(txtBoxSearch.Text.ToLower())).ToList();
           
        }
    }
}
