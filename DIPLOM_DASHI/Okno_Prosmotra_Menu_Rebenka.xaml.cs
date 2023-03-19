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
    /// Логика взаимодействия для Okno_Prosmotra_Menu_Rebenka.xaml
    /// </summary>
    public partial class Okno_Prosmotra_Menu_Rebenka : Window
    {
        public Okno_Prosmotra_Menu_Rebenka()
        {
            InitializeComponent();
            Deti.SelectedItem = "ID";
            Deti.DisplayMemberPath = "Familiya";
            Deti.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Ребенок.ToList();

            Vospitateli.SelectedItem = "ID";
            Vospitateli.DisplayMemberPath = "FIO";
            Vospitateli.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Воспитатели.ToList();

        }

        private void Выйти_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }

        private void Изменить_Click(object sender, RoutedEventArgs e)
        {
            NachalnoeOkno nachalnoeOkno = new NachalnoeOkno();
            nachalnoeOkno.Show();
            Close();
        }

        private void Узнать_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Deti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Deti.SelectedItem = "ID";
            Deti.DisplayMemberPath = "Familiya";
            Deti.ItemsSource = Helpers.BD.Kontrol_PitaniaEntities1.Ребенок.ToList();
        }
    }
}
