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
    /// Логика взаимодействия для SectionsPage.xaml
    /// </summary>
    public partial class SectionsPage : Page
    {
        public SectionsPage()
        {
            InitializeComponent();
            comboFilter.Items.Add("Компоненты");
            comboFilter.Items.Add("Услуги");
            comboFilter.SelectedIndex = 0;
            Update();
        }

        private void BtnBasket_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                
                Update();
            }
        }

        private void Update()
        {
            List<Components> currentComp = SaleComponentsEntities.getContext().Components.ToList();
            List<Services> currentServ = SaleComponentsEntities.getContext().Services.ToList();
            currentComp = currentComp.Where(p => p.Name.ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.Categories.Name.ToLower().Contains(txtBoxSearch.Text.ToLower())).ToList();
            currentServ = currentServ.Where(p => p.Name.ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.Categories.Name.ToLower().Contains(txtBoxSearch.Text.ToLower())).ToList();

            if (comboFilter.SelectedIndex == 0)
                dGridHotels.ItemsSource = currentComp.OrderBy(p => p.Name).ToList();
            if (comboFilter.SelectedIndex == 1)
                dGridHotels.ItemsSource = currentServ.OrderBy(p => p.Name).ToList();


        }
        private void txtBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
        private void comboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }


    }
}
