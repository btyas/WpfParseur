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

            int resulatConversion = 0;
            
            for (int i =0;i<CharRcText.Length;i++)
            {
                int C2 = 0;
                int C1 = 0;
                if (CharRcText[i] == 'I')
                {
                    C1 = 1;
                }
                else if (CharRcText[i] == 'V')
                {
                    C1 = 5;
                }
                else if (CharRcText[i] == 'X')
                {
                    C1 = 10;
                }
                else if (CharRcText[i] == 'L')
                {
                    C1 = 50;
                }
                else if (CharRcText[i] == 'C')
                {
                    C1 = 100;
                }
                else if (CharRcText[i] == 'D')
                {
                    C1 = 500;
                }
                else if (CharRcText[i] == 'M')
                {
                    C1 = 1000;
                }
                else
                {
                    C1 = -1;
                }

                if (i + 1 < CharRcText.Length)
                {
                    // Getting value of symbol s[i+1]
                    if (CharRcText[i+1] == 'I')
                    {
                        C2 = 1;
                    }
                    else if (CharRcText[i] == 'V')
                    {
                        C2 = 5;
                    }
                    else if (CharRcText[i] == 'X')
                    {
                        C2 = 10;
                    }
                    else if (CharRcText[i] == 'L')
                    {
                        C2 = 50;
                    }
                    else if (CharRcText[i] == 'C')
                    {
                        C2 = 100;
                    }
                    else if (CharRcText[i] == 'D')
                    {
                        C2 = 500;
                    }
                    else if (CharRcText[i] == 'M')
                    {
                        C2 = 1000;
                    }
                    else
                    {
                        C2 = -1;
                    }

                    // Comparing both values
                    if (C1 >= C2)
                    {

                        resulatConversion = resulatConversion + C1;
                    }
                    else
                    {

                        resulatConversion = resulatConversion + C2 - C1;
                        i++;
                    }
                }
                else
                {
                    resulatConversion = resulatConversion + C1;
                }
            }

            
           

            ResultConvert.Text = resulatConversion.ToString();


        }

    }





}

 

