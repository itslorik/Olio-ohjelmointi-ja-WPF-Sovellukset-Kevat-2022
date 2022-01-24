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

namespace SivujdenVahito
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Page> sivut = new List<Page>();

        public MainWindow()
        {
            InitializeComponent();

            sivut.Add(new Page1());
            sivut.Add(new Page2());

            Frame_Main.NavigationService.Navigate(sivut[0]);
        }
    }
}
