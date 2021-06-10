using CoursProjectClear.Base;
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

        public string login = null;
        
        public AutoPage()
        {
            InitializeComponent();

        }

        private void Auto_Click(object sender, RoutedEventArgs e)
        {
            if (autorize(txtLogin.Text, txtPassword.Password))
            {
                MessageBox.Show("Вы успешно авторизованы", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                Navig.MainFrame.Navigate(new SectionsPage());
                Navig.MenuFrame.Navigate(new NavigMenuPage());
                
            }
        }
        private bool autorize(string login, string password)
        {
            int errors = 0;

            try
            {
                foreach (var user in SaleComponentsEntities.getContext().Users.ToList())
                {
                    if (login == user.Login && password == user.Password)
                    {
                        this.login = user.Login;
                        errors = 0;
                        break;
                    }
                    if (txtLogin.Text == user.Login)
                        this.login = user.Login;

                    else
                        errors++;
                }

                if (errors == 0)
                {
                    addEntryHistory(this.login, true);
                    return true;
                }
                else
                {
                    if (this.login != null)
                    {
                        addEntryHistory(this.login, false);
                    }
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return false;
        }
        private void addEntryHistory(string login, bool access)
        {
            try
            {
                History historyEnter = new History();
                historyEnter.Login = login;
                historyEnter.Date = DateTime.Now;
                historyEnter.Succsesfull = access;
                SaleComponentsEntities.getContext().History.Add(historyEnter);
                SaleComponentsEntities.getContext().SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        private void addEntryBasket(string login, bool access)
        {
            try
            {
                Basket basketEnter = new Basket();
                basketEnter.Login = login;
                SaleComponentsEntities.getContext().Basket.Add(basketEnter);
                SaleComponentsEntities.getContext().SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new RegistPage());
        }
    }
}
      
    
