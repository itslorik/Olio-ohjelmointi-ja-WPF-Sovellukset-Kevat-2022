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

namespace Harjoitus18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_KertoLasku_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Numero.Text) * float.Parse(txt_Numero2.Text);
            txt_Vastaus.Text = tulos.ToString();
        }

        private void txt_Numero_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Numero.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                int.Parse(txt_Numero.Text + txt_Numero2.Text);
            }
        }
        private void txt_Numero2_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Numero.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                int.Parse(txt_Numero.Text + txt_Numero2.Text);
            }
        }


        private void btn_Erotus_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Numero.Text) - float.Parse(txt_Numero2.Text);
            txt_Vastaus.Text = tulos.ToString();
        }

        private void btn_Summa_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Numero.Text) + float.Parse(txt_Numero2.Text);
            txt_Vastaus.Text = tulos.ToString();
        }

        private void btn_JakoLasku_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Numero.Text) / float.Parse(txt_Numero2.Text);
            txt_Vastaus.Text = tulos.ToString();
        }

    }
}

