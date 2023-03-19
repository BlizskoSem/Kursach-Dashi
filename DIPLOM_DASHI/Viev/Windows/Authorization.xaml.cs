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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            var xv = Helpers.BD2.user24Entities.Authorizations.FirstOrDefault(i => i.Login == LogTb.Text && i.Password == passPb.Password);
            if (xv != null)
            {
                MessageBox.Show("Успех");
                Okno_Prosmotra_Menu_Rebenka okno_Prosmotra_Menu_Rebenka = new Okno_Prosmotra_Menu_Rebenka();
                okno_Prosmotra_Menu_Rebenka.Show();
             
                
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            
           
            
        }

        private void РегистрациЯ_Click(object sender, RoutedEventArgs e)
        {
            Registr registration = new Registr();
            registration.Show();
            Close();
        }

        private void EnterBtn_Click_1(object sender, RoutedEventArgs e)
        {
            var xv = Helpers.BD2.user24Entities.Authorizations.FirstOrDefault(i => i.Login == LogTb.Text && i.Password == passPb.Password);
            if (xv != null)
            {
                MessageBox.Show("Успех");
                Okno_Prosmotra_Menu_Rebenka okno_Prosmotra_Menu_Rebenka = new Okno_Prosmotra_Menu_Rebenka();
                okno_Prosmotra_Menu_Rebenka.Show();
                Close();


            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}

