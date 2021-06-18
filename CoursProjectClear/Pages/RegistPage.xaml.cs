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
    /// Логика взаимодействия для RegistPage.xaml
    /// </summary>
    public partial class RegistPage : Page
    {
        public Staffs _staffs = new Staffs();
        public Users _user = new Users();
        public RegistPage()
        {
            InitializeComponent();
            Staffs regStaff = new Staffs();
            Users regUsers = new Users();
            if (regStaff != null)
                _staffs = regStaff;

            if (regUsers != null)
                _user = regUsers;

            DataContext = _staffs;
            DataContext = _user;
        }

        private void Regist_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            _user.IdPrivelege = 2;

            if (string.IsNullOrWhiteSpace(_staffs.FirstName))
                errors.AppendLine("Укажите Фамилию");
            if (string.IsNullOrWhiteSpace(_staffs.LastName))
                errors.AppendLine("Укажите Имя");
            if (string.IsNullOrWhiteSpace(_staffs.Passport))
                errors.AppendLine("Укажите Passport");
            if (string.IsNullOrWhiteSpace(_staffs.Phone))
                errors.AppendLine("Укажите Телефон");
            if (string.IsNullOrWhiteSpace(_staffs.Email))
                errors.AppendLine("Укажите Email");
            if (string.IsNullOrWhiteSpace(_user.Login))
                errors.AppendLine("Укажите Login");
            if (string.IsNullOrWhiteSpace(_user.Password))
                errors.AppendLine("Укажите Login");







            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_staffs.Login == null)
                SaleComponentsEntities.getContext().Staffs.Add(_staffs);
                SaleComponentsEntities.getContext().Users.Add(_user);

            try
            {
                SaleComponentsEntities.getContext().SaveChanges();
                MessageBox.Show("Информация сохранена, вернитесь и авторизируйтесь");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new AutoPage());
        }
    }
}
