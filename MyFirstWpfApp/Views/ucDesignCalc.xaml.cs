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

namespace MyFirstWpfApp.Views
{
    /// <summary>
    /// Interação lógica para ucDesignCalc.xam
    /// </summary>
    public partial class ucDesignCalc : UserControl
    {
        long numero1 = 0;
        long numero2 = 0;
        string operacao = "";
        
        public ucDesignCalc()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 2;
                screen.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 2;
                screen.Text = numero2.ToString();
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           screen.Text = "";
           operacao = "";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "";
            operacao = "/";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 7;
                screen.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 7;
                screen.Text = numero2.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 8;
                screen.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 8;
                screen.Text = numero2.ToString();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 9;
                screen.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 9;
                screen.Text = numero2.ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "";
            operacao = "-";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 4;
                screen.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 4;
                screen.Text = numero2.ToString();
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 5;
                screen.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 5;
                screen.Text = numero2.ToString();
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 6;
                screen.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 6;
                screen.Text = numero2.ToString();
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "";
            operacao = "+";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            //screen.Text = screen.Text + "1";
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 1;
                screen.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 1;
                screen.Text = numero2.ToString();
            }
         
 
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 3;
                screen.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 3;
                screen.Text = numero2.ToString();
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "=";
            switch (operacao)
            {
                case "+":
                    {
                        screen.Text = (numero1 + numero2).ToString();
                        numero1 = 0;
                        numero2 = 0;
                        operacao = null;
                    }
                    break;
                case "-":
                    {
                        screen.Text = (numero1 - numero2).ToString();
                        numero1 = 0;
                        numero2 = 0;
                        operacao = null;
                    }
                    break;
                case "*":
                    {
                        screen.Text = (numero1 * numero2).ToString();
                        numero1 = 0;
                        numero2 = 0;
                        operacao = null;
                    }
                    break;
                case "/":
                    {
                        screen.Text = (numero1 / numero2).ToString();
                        numero1 = 0;
                        numero2 = 0;
                        operacao = null;
                    }
                    break;
            }
            //numero1 = 0;
            //numero2 = 0;
            //operacao = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10);
                screen.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10);
                screen.Text = numero2.ToString();
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + ".";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            screen.Text = screen.Text + "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "";
            operacao = "*";
        }
    }
}
