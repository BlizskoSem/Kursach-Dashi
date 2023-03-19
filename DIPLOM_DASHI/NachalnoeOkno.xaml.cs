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
using System.Windows.Shapes;

namespace DIPLOM_DASHI
{
    /// <summary>
    /// Логика взаимодействия для NachalnoeOkno.xaml
    /// </summary>
    public partial class NachalnoeOkno : Window
    {
        public NachalnoeOkno()
        {
            InitializeComponent();
            Завтрак.SelectedItem = "ID";

            Завтрак.DisplayMemberPath = "Каша";
            Завтрак.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Завтрак.ToList();

            Чай.SelectedItem = "ID";

            Чай.DisplayMemberPath = "Чай";
            Чай.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Завтрак.ToList();



            Булочка.SelectedItem = "ID";

            Булочка.DisplayMemberPath = "Булочка";
            Булочка.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Завтрак.ToList();




            Обед.SelectedItem = "ID";
            Обед.DisplayMemberPath = "Первое";
            Обед.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Обед.ToList();

            Второе.SelectedItem = "ID";
            Второе.DisplayMemberPath = "Второе";
            Второе.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Обед.ToList();


            Напиток.SelectedItem = "ID";
            Напиток.DisplayMemberPath = "Напиток";
            Напиток.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Обед.ToList();





            Ужин.SelectedItem = "ID";
            Ужин.DisplayMemberPath = "Йогурт";
            Ужин.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Ужин.ToList();


            Запеканка.SelectedItem = "ID";
            Запеканка.DisplayMemberPath = "Запеканка";
            Запеканка.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Ужин.ToList();


            Молоко.SelectedItem = "ID";
            Молоко.DisplayMemberPath = "Молоко";
            Молоко.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Ужин.ToList();


            








        }

        private void НАЗАД_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }

        private void ДобавитЬ_Click(object sender, RoutedEventArgs e)
        {
            string log = "";
            if (string.IsNullOrWhiteSpace(TxtFamiliya.Text))
                log += "Введите фамилию\n";

            if (string.IsNullOrWhiteSpace(TXTIMYA.Text))
                log += "Введите имя\n";

            if (string.IsNullOrWhiteSpace(TxtOtcestvo.Text))
                log += "Повторите отчество\n";




            if (log != "")
            {
                MessageBox.Show("Введите фамилию");
                log = "";
                return;
            }

            if (log != "")
            {
                MessageBox.Show("Введите имя");
                log = "";
                return;
            }


            if (log != "")
            {
                MessageBox.Show("Введите отчество");
                log = "";
                return;
            }



           
           

        }

        private void Очистить_Форму_Click(object sender, RoutedEventArgs e)
        {
            TxtFamiliya.Clear();
            TXTIMYA.Clear();
            TxtOtcestvo.Clear();
            
        }
    }
}
