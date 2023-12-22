using System.Windows;
using System.Windows.Controls;

namespace _3_CalculatorHomeWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operation;
        double a;
        double b;
        public MainWindow()
        {
            InitializeComponent();
            textBoxCurrentOperation.Text = "0";
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {

            if(textBoxCurrentOperation.Text == "0")
            {
                textBoxCurrentOperation.Clear();
                textBoxCurrentOperation.Text += (sender as Button).Content.ToString();
                a = double.Parse(textBoxCurrentOperation.Text);
            }
            else if ((sender as Button).Content.ToString() != "+" || (sender as Button).Content.ToString() != "-" || (sender as Button).Content.ToString() != "/" || (sender as Button).Content.ToString() != "*")
            {
                textBoxCurrentOperation.Text += (sender as Button).Content.ToString();
                a = double.Parse(textBoxCurrentOperation.Text);
            }
        }

        private void EqulBtn_Click(object sender, RoutedEventArgs e)
        {
           switch (operation) 
            {
                case "+":
                    {
                        textBoxRead.Text = b + " + " + a + " =";
                        double res = a+b;
                        textBoxCurrentOperation.Text =res.ToString();
                        a = res;
                        
                        break;
                    }
                case "-":
                    {
                        textBoxRead.Text = b + " - " + a + " =";
                        double res = b - a;
                        textBoxCurrentOperation.Text = res.ToString();
                        a = res;
                        break;
                    }
                case "*":
                {
                        textBoxRead.Text = b + " * " + a + " =";
                        double res = a * b;
                    textBoxCurrentOperation.Text = res.ToString();
                    a = res;
                    break;
                }
                case "/":
                    {
                        if(a!=0)
                        {
                            textBoxRead.Text = b + " / " + a + " =";
                            double res = b / a;
                            textBoxCurrentOperation.Text = res.ToString();
                            a = res;
                        }
                        else
                        {
                            textBoxRead.Text = b + " / " + a + " =";
                            textBoxCurrentOperation.Text = "Помилка";
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
           }

        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            textBoxRead.Text = a + " + ";
            operation = (sender as Button).Content.ToString();
            b = a;
            textBoxCurrentOperation.Clear();
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            textBoxRead.Text = a + " - ";
            operation = (sender as Button).Content.ToString();
            b = a;
            textBoxCurrentOperation.Clear();
        }

        private void StarBtn_Click(object sender, RoutedEventArgs e)
        {
            textBoxRead.Text = a + " * ";
            operation = (sender as Button).Content.ToString();
            b = a;
            textBoxCurrentOperation.Clear();
        }

        private void SlashBtn_Click(object sender, RoutedEventArgs e)
        {
            textBoxRead.Text = a + " / ";
            operation = (sender as Button).Content.ToString();
            b = a;
            textBoxCurrentOperation.Clear();
        }

        private void CEBtn_Click(object sender, RoutedEventArgs e)
        {
            textBoxCurrentOperation.Clear();
            a = 0;
        }

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            textBoxCurrentOperation.Clear();
            textBoxRead.Clear();
            a = 0;
            b = 0;
        }

        private void ArrowBtn_Click(object sender, RoutedEventArgs e)
        {
            char[] a =textBoxCurrentOperation.Text.ToCharArray();
            char[] b = new char[a.Length-1];
            for (int i = 0; i < a.Length-1; i++)
            {
                b[i] = a[i];
            }
            string c = new string(b);
            textBoxCurrentOperation.Text = c;
        }

        private void DotBtn_Click(object sender, RoutedEventArgs e)
        {
            textBoxCurrentOperation.Text += ",";
        }
    }
}