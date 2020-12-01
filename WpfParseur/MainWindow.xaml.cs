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

namespace WpfParseur
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            String[] CG_Romain = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD","D","CM","M" };
            String[] C1_Romain = new string[] { "I", "V", "L", "C", "D", "M" };
            String[] C2_Romain = new string[] { "IV", "IX", "XL", "XC", "CD", "CM" };
        }

        private void ConvertBtn_Click(object sender, RoutedEventArgs e)
        {
            var RcText = this.EnterChiffreRomain.Text;

            char[] CharRcText = RcText.ToCharArray();

            for (int i =0;i<CharRcText.Length;i++)
            {

            }

        }

        private void EnterChiffreRomain_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
