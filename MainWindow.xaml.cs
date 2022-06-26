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

namespace calculator
{
    public partial class MainWindow : Window
    {
        public double Accum = 0;
        public string Accum_operand = "";
        public string stroka2 = "0";
        public string NumberText;
        public double M = 0;
        public double k = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NUMBER_Z_Click(object sender, EventArgs e)
        {
            if (TEXT.Text == "0")
            {
                TEXT.Text = (string)(sender as Button).Content;
                stroka2 = (string)(sender as Button).Content;
                TEXT2.Content = stroka2;
            }
            else if (TEXT.Text == "не число" || TEXT.Text == "∞")
            {
                TEXT.Text = (string)(sender as Button).Content;
                stroka2 = (string)(sender as Button).Content;
                TEXT2.Content = stroka2;
            }
            else
            {
                TEXT.Text = TEXT.Text + (sender as Button).Content;
                stroka2 += (sender as Button).Content;
                TEXT2.Content = stroka2;
            }
        }

        private void Z_Click(object sender, EventArgs e)
        {
            if (TEXT.Text == "не число" || TEXT.Text.Contains(',') || TEXT.Text ==  "∞")
            {
                
            }
            else
            {
                TEXT.Text = TEXT.Text + ",";
                stroka2 += ",";
                TEXT2.Content = stroka2;
            }
        }

        private void OPERATOR_Click(object sender, EventArgs e)
        {
            NumberText = TEXT.Text;
            if (NumberText != "не число" && NumberText != "∞" && NumberText != "")
            {
                if (Accum_operand == "")
                {
                    Accum = double.Parse(NumberText);
                }
                else if (Accum_operand == "+")
                {
                    Accum += double.Parse(NumberText);
                }
                else if (Accum_operand == "-")
                {
                    Accum -= double.Parse(NumberText);
                }
                else if (Accum_operand == "/")
                {
                    Accum /= double.Parse(NumberText);
                }
                else if (Accum_operand == "*")
                {
                    Accum *= double.Parse(NumberText);
                }
                Accum_operand = (string)(sender as Button).Content;
                TEXT.Text = "";
                stroka2 = Accum.ToString() + (sender as Button).Content;
                TEXT2.Content = stroka2;
            }
            else if (NumberText == "")
            {
                Accum_operand = (string)(sender as Button).Content;
                TEXT.Text = "";
                stroka2 = Accum.ToString() + (sender as Button).Content;
                TEXT2.Content = stroka2;
            }
            else
            {
                Accum = 0;
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
                TEXT.Text = Accum.ToString();
            }
        }

        private void ROOT_Click(object sender, EventArgs e)
        {
            NumberText = TEXT.Text;
            if (NumberText != "не число" && NumberText != "∞" && NumberText != "")
            {
                if (Accum_operand == "")
                {
                    Accum = Math.Pow(double.Parse(TEXT.Text), 0.5);
                }
                else if (Accum_operand == "+")
                {
                    Accum += Math.Pow(double.Parse(TEXT.Text), 0.5);
                }
                else if (Accum_operand == "-")
                {
                    Accum -= Math.Pow(double.Parse(TEXT.Text), 0.5);
                }
                else if (Accum_operand == "/")
                {
                    Accum /= Math.Pow(double.Parse(TEXT.Text), 0.5);
                }
                else if (Accum_operand == "*")
                {
                    Accum *= Math.Pow(double.Parse(TEXT.Text), 0.5);
                }
                Accum_operand = "";
                TEXT.Text = Accum.ToString();
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
            }
            else if (NumberText == "")
            {
                Accum_operand = "";
                TEXT.Text = Accum.ToString();
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
            }
            else
            {
                Accum = 0;
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
                TEXT.Text = Accum.ToString();
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            NumberText = TEXT.Text;
            if (NumberText != "не число" && NumberText != "∞" && NumberText != "")
            {
                if (Accum_operand == "")
                {
                    Accum = 1 / double.Parse(TEXT.Text);
                }
                else if (Accum_operand == "+")
                {
                    Accum += 1 / double.Parse(TEXT.Text);
                }
                else if (Accum_operand == "-")
                {
                    Accum -= 1 / double.Parse(TEXT.Text);
                }
                else if (Accum_operand == "/")
                {
                    Accum /= 1 / double.Parse(TEXT.Text);
                }
                else if (Accum_operand == "*")
                {
                    Accum *= 1 / double.Parse(TEXT.Text);
                }
                Accum_operand = "";
                TEXT.Text = Accum.ToString();
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
            }
            else if (NumberText == "")
            {
                Accum_operand = "";
                TEXT.Text = Accum.ToString();
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
            }
            else
            {
                Accum = 0;
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
                TEXT.Text = Accum.ToString();
            }
        }

        private void OPERATIONS_Click(object sender, EventArgs e)
        {
            NumberText = TEXT.Text;
            if (NumberText != "не число" && NumberText != "∞" && NumberText != "")
            {
                if (Accum_operand == "")
                {
                    Accum = -(double.Parse(TEXT.Text));
                }
                else if (Accum_operand == "+")
                {
                    Accum += -(double.Parse(TEXT.Text));
                }
                else if (Accum_operand == "-")
                {
                    Accum -= -(double.Parse(TEXT.Text));
                }
                else if (Accum_operand == "/")
                {
                    Accum /= -(double.Parse(TEXT.Text));
                }
                else if (Accum_operand == "*")
                {
                    Accum *= -(double.Parse(TEXT.Text));
                }
                Accum_operand = "";
                TEXT.Text = Accum.ToString();
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
            }
            else if (NumberText == "")
            {
                Accum_operand = "";
                TEXT.Text = Accum.ToString();
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
            }
            else
            {
                Accum = 0;
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
                TEXT.Text = Accum.ToString();
            }
        }

        private void RAVNO_Click(object sender, RoutedEventArgs e)
        {
            NumberText = TEXT.Text;
            if (NumberText == "")
            {
                k = Accum;
            }
            else
            {
                k = double.Parse(NumberText);
            }
            if (Accum_operand == "*")
            {
                Accum *= k;
            }
            else if (Accum_operand == "/")
            {
                Accum /= k;
            }
            else if (Accum_operand == "-")
            {
                Accum -= k;
            }
            else if (Accum_operand == "+")
            {
                Accum += k;
            }
            else
            {
                Accum = k;
            }
            Accum_operand = "";
            TEXT.Text = Accum.ToString();
            stroka2 = Accum.ToString();
            TEXT2.Content = stroka2;
        }

        private void PROCENT_Click(object sender, RoutedEventArgs e)
        {
            NumberText = TEXT.Text;
            if (NumberText == "")
            {
                Accum_operand = "";
                TEXT.Text = Accum.ToString();
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
            }
            else
            {
                if (Accum_operand == "")
                {
                    Accum = 0;
                }
                else if (Accum_operand == "+")
                {
                    Accum += Accum * (double.Parse(NumberText) / 100);
                }
                else if (Accum_operand == "-")
                {
                    Accum -= Accum * (double.Parse(NumberText) / 100);
                }
                else if (Accum_operand == "/")
                {
                    Accum = Accum / (double.Parse(NumberText) / 100);
                }
                else
                {
                    Accum = Accum * (double.Parse(NumberText) / 100);
                }
                Accum_operand = "";
                TEXT.Text = Accum.ToString();
                stroka2 = Accum.ToString();
                TEXT2.Content = stroka2;
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            TEXT.Text = "0";
            Accum_operand = "";
            Accum = 0;
            stroka2 = "";
            TEXT2.Content = stroka2;
        }

        private void STR_Click(object sender, RoutedEventArgs e)
        {
            NumberText = TEXT.Text;
            int lenght = NumberText.Length;
            if (lenght <= 1 && TEXT.Text != "0")
            {
                TEXT.Text = "0";
                lenght = stroka2.Length;
                NumberText = stroka2;
                stroka2 = "";
                for (int i = 0; i < lenght - 1; i++)
                {
                    stroka2 += NumberText[i];
                }
                TEXT2.Content = stroka2;
            }
            else if (TEXT.Text == "не число" || TEXT.Text == "∞" || TEXT.Text.Contains('E'))
            {
                TEXT.Text = "0";
                stroka2 = "";
                TEXT2.Content = stroka2;
            }
            else if (TEXT.Text == "0")
            {
                
            }
            else
            {
                TEXT.Text = "";
                for (int i = 0; i < lenght - 1; i++)
                {
                    TEXT.Text = TEXT.Text + NumberText[i];
                }
                lenght = stroka2.Length;
                NumberText = stroka2;
                stroka2 = "";
                for (int i = 0; i < lenght - 1; i++)
                {
                    stroka2 += NumberText[i];
                }
                TEXT2.Content = stroka2;
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            NumberText = TEXT.Text;
            int lenght = stroka2.Length - NumberText.Length;
            TEXT.Text = "";
            NumberText = stroka2;
            stroka2 = "";
            for (int i = 0; i < lenght; i++)
            {
                stroka2 += NumberText[i];
            }
            TEXT2.Content = stroka2;
        }

        private void MC_Click(object sender, RoutedEventArgs e)
        {
            M = 0;
        }

        private void MS_Click(object sender, RoutedEventArgs e)
        {
            if (TEXT.Text != "не число" && TEXT.Text != "∞")
            {
                NumberText = TEXT.Text;
                M = double.Parse(NumberText);
            }
        }

        private void MR_Click(object sender, RoutedEventArgs e)
        {
            TEXT.Text = M.ToString();
            stroka2 = M.ToString();
            TEXT2.Content = stroka2;
        }

        private void MP_Click(object sender, RoutedEventArgs e)
        {
            if (TEXT.Text != "не число" && TEXT.Text != "∞")
            {
                NumberText = TEXT.Text;
                M += double.Parse(NumberText); 
            }
        }

        private void MM_Click(object sender, RoutedEventArgs e)
        {
            if (TEXT.Text != "не число" && TEXT.Text != "∞")
            {
                NumberText = TEXT.Text;
                M -= double.Parse(NumberText);
            }
        }

        public void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                C_Click(sender, e);
            }
            else if (e.Key == Key.Back)
            {
                STR_Click(sender, e);
            }
            else if (e.Key == Key.Delete)
            {
                CE_Click(sender, e);
            }
            else if (e.Key == Key.Enter)
            {
                RAVNO_Click(sender, e);
            }
        }

        private void Window_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int value))
            {
                if (TEXT.Text == "0")
                {
                    TEXT.Text = e.Text;
                    stroka2 = e.Text;
                    TEXT2.Content = stroka2;
                }
                else if (TEXT.Text == "не число" || TEXT.Text == "∞")
                {
                    TEXT.Text = e.Text;
                    stroka2 = e.Text;
                    TEXT2.Content = stroka2;
                }
                else
                {
                    TEXT.Text = TEXT.Text + e.Text;
                    stroka2 += e.Text;
                    TEXT2.Content = stroka2;
                }
            }
            else if (e.Text == ",")
            {
                Z_Click(sender, e);
            }
            else if (e.Text == "+" || e.Text == "-" || e.Text == "*" || e.Text == "/")
            {
                NumberText = TEXT.Text;
                if (NumberText != "не число" && NumberText != "∞")
                {
                    if (Accum_operand == "")
                    {
                        Accum = double.Parse(NumberText);
                    }
                    else if (Accum_operand == "+")
                    {
                        Accum += double.Parse(NumberText);
                    }
                    else if (Accum_operand == "-")
                    {
                        Accum -= double.Parse(NumberText);
                    }
                    else if (Accum_operand == "/")
                    {
                        Accum /= double.Parse(NumberText);
                    }
                    else if (Accum_operand == "*")
                    {
                        Accum *= double.Parse(NumberText);
                    }
                    Accum_operand = e.Text;
                    TEXT.Text = "";
                    stroka2 = Accum.ToString() + e.Text;
                    TEXT2.Content = stroka2;
                }
                else
                {
                    Accum = 0;
                    stroka2 = Accum.ToString();
                    TEXT2.Content = stroka2;
                    TEXT.Text = Accum.ToString();
                }
            }
            else if (e.Text == "Q")
            {
                ROOT_Click(sender, e);
            }
            else if (e.Text == "@")
            {
                X_Click(sender, e);
            }
            else if (e.Text == "Z")
            {
                OPERATIONS_Click(sender, e);
            }
            else if (e.Text == "=")
            {
                RAVNO_Click(sender, e);
            }
            else if (e.Text == "%")
            {
                PROCENT_Click(sender, e);
            }
            else if (e.Text == "A")
            {
                MC_Click(sender, e);
            }
            else if (e.Text == "S")
            {
                MR_Click(sender, e);
            }
            else if (e.Text == "D")
            {
                MS_Click(sender, e);
            }
            else if (e.Text == "F")
            {
                MP_Click(sender, e);
            }
            else if (e.Text == "G")
            {
                MM_Click(sender, e);
            }
        }
    }
}
