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

namespace DIPLOM_DASHI
{
    /// <summary>
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        public Registr()
        {
            InitializeComponent();
        }


        private void Зарегаться_Click(object sender, RoutedEventArgs e)
        {
            string log = "";
            if (string.IsNullOrWhiteSpace(LoginTB.Text))
                log += "Введите логин\n";

            if (string.IsNullOrWhiteSpace(PassTB.Password))
                log += "Введите пароль\n";

            if (string.IsNullOrWhiteSpace(EmTb.Text))
                log += "Введите почту\n";



            if (log != "")
            {
                MessageBox.Show(log);
                log = "";
                return;
            }


            if (log != "")
            {
                MessageBox.Show("Введите логин");
                log = "";
                return;
            }

            if (log != "")
            {
                MessageBox.Show("Введите пароль");
                log = "";
                return;
            }


            if (log != "")
            {
                MessageBox.Show("Введите почту");
                log = "";
                return;
            }

            Models2.Authorizations profile = new Models2.Authorizations()
            {
                Id = 23,
                Name = "Sem",
                Login = LoginTB.Text,
                Phone = 123,
                Password = PassTB.Password,

            };
            Helpers.BD2.user24Entities.Authorizations.Add(profile);
            Helpers.BD2.user24Entities.SaveChanges();
            MessageBox.Show("Учетная запись создана");

            MessageBox.Show("Успех");
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();


        }
    }
}
