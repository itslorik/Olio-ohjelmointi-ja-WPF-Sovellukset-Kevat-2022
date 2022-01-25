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

namespace Harjoitus21
{
    
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                listBox1.Items.Add(txt_textBox1.Text);
        }

        private void btn_Poista_Click(object sender, RoutedEventArgs e)
        {
            
            listBox1.Items.Remove(txt_textBox1.Text);
        }
    }
}
 