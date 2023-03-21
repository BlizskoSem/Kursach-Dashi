using DIPLOM_DASHI.Helpers;
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

        public List<Uzhin> Uzhins { get; set; }
        public List<Obed> Obeds { get; set; }

        public List<Zavtrak> Zavtraks { get; set; }
       
        public Okno_Prosmotra_Menu_Rebenka()
        {
            InitializeComponent();

            Zavtraks = new List<Zavtrak>();

            Zavtrak zavtrak = new Zavtrak();
            zavtrak.Eda = "Манная";
            zavtrak.Napitok = "Черный";
            zavtrak.Bulochka = "С вареньем";

            


            Obeds = new List<Obed>();
            Obed obed = new Obed();
            obed.Pervoe = "Борщ";
            obed.Vtoroe = "Пюре с грибами";
            obed.Kompot = "Сок";

            Uzhins = new List<Uzhin>();
            Uzhin uzhin = new Uzhin();
            uzhin.Yogurt = "С вишней";
            uzhin.Zapekanka = "С изюмом";
            uzhin.Popit = "Кофе";


            Zavtraks.Add(zavtrak);
            Obeds.Add(obed);
            Uzhins.Add(uzhin);

            DataContext = this;




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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Завтрачек_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
