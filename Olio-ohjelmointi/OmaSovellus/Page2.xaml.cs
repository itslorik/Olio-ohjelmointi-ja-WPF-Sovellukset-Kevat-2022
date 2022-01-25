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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Input_Kentä_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_Pekka == null)
            {
                return;
            }
            txt_Pekka.Text = Input_Kentä.Text;
            if (Input_Kentä.Text == "Sauli Niinistö")
            {
                txt_Pekka.Text += ". Oiken!";
            }
            else if (Input_Kentä.Text != " ")
            {
                
                txt_Pekka.Text += "";
            }
        }

        private void Input_Koulu_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_Seppo == null)
            {
                return;
            }
            txt_Seppo.Text = Input_Koulu.Text;
            
        }
    }
}
