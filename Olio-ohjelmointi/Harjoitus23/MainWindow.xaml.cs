using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoitus23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kiuas kiuas = new Kiuas();

        public MainWindow()
        {
            InitializeComponent();

            //Alustetaan kiuas tietyillä arvoilla
            kiuas.VaihdaLämpötila(10);
            kiuas.VaihdaKosteutta(10);
            kiuas.OnkoPäällä = false; //Kiuas on alussa false
        }

        private void btn_LämpötilaOn_Click(object sender, RoutedEventArgs e)
        {
            int uusilämpötila = kiuas.Lämpötila + 5; // Lisäätän nykyseen lämptöilaan 5 lisää
            kiuas.VaihdaLämpötila(uusilämpötila);
            tb_Lämpötila.Text = kiuas.Lämpötila.ToString();
        }

        private void btn_LämpötilaOff_Click(object sender, RoutedEventArgs e)
        {
            int uusilämpötila = kiuas.Lämpötila - 5; // Vähennetään nykyseen lämptöilaa viidellä
            kiuas.VaihdaLämpötila(uusilämpötila);
            tb_Lämpötila.Text = kiuas.Lämpötila.ToString();
        }

        private void Input_Kosteus_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Input_Kosteus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Input_Kosteus.Text != "")
            {
                kiuas.VaihdaKosteutta(int.Parse(Input_Kosteus.Text));
                tb_Kosteus.Text = kiuas.Kosteus.ToString();
            }
        }
    }
}
