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

namespace OmaSovellus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Page> Sivut = new List<Page>();
        int Nykyinensivu = 0;
        public MainWindow()
        {
            InitializeComponent();
            Sivut.Add(new Page1());
            Sivut.Add(new Page2());
            frame_Main.NavigationService.Navigate(Sivut[0]);

        }

        private void btn_SeuraavaSivu_Click(object sender, RoutedEventArgs e)
        {
            Nykyinensivu += 1;
            if (Nykyinensivu >= Sivut.Count)
            {
                Nykyinensivu = Sivut.Count - 1;
            }
            frame_Main.NavigationService.Navigate(Sivut[Nykyinensivu]);

        }

        private void btn_Sivu2_Click(object sender, RoutedEventArgs e)
        {
            Nykyinensivu -= 1;
            if (Nykyinensivu < 0)
            {
                Nykyinensivu = 0;
            }
            frame_Main.NavigationService.Navigate(Sivut[Nykyinensivu]);

        }
    }
}
