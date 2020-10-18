using System.Windows;

namespace Laboratorium2
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

        #region variables

        private double n1;
        private double n2;
        private bool plusButtonClicked = false;
        private bool minusButtonClicked = false;
        private bool multiplyButtonClicked = false;
        private bool dividedButtonClicked = false;

        #endregion variables

        #region buttonsNumbers

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (resultBox.Text.Length <= 1)
            {
                resultBox.Text = "0";
            }
            else
            {
                resultBox.Text += "0";
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text += "9";
        }

        #endregion buttonsNumbers

        #region buttonsSymbols

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            n1 += double.Parse(resultBox.Text);
            resultBox.Text = "";

            plusButtonClicked = true;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            n1 += double.Parse(resultBox.Text);
            resultBox.Text = "";

            minusButtonClicked = true;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            n1 += double.Parse(resultBox.Text);
            resultBox.Text = "";

            dividedButtonClicked = true;
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            n1 += double.Parse(resultBox.Text);
            resultBox.Text = "";

            multiplyButtonClicked = true;
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            if (plusButtonClicked == true)
            {
                n2 = n1 + double.Parse(resultBox.Text);
                resultBox.Text = n2.ToString();
                n1 = 0;
            }
            else if (minusButtonClicked == true)
            {
                n2 = n1 - double.Parse(resultBox.Text);
                resultBox.Text = n2.ToString();
                n1 = 0;
            }
            else if (multiplyButtonClicked == true)
            {
                n2 = n1 * double.Parse(resultBox.Text);
                resultBox.Text = n2.ToString();
                n1 = 0;
            }
            else if (dividedButtonClicked == true)
            {
                if (double.Parse(resultBox.Text) == 0)
                {
                    MessageBox.Show("Can't divide by 0");
                }
                else
                {
                    n2 = n1 / double.Parse(resultBox.Text);
                    resultBox.Text = n2.ToString();
                    n1 = 0;
                }
            }
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            if (!resultBox.Text.Contains("."))
                resultBox.Text += ".";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "";
        }

        private void clearlast_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Clear();
        }

        private void plusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (!resultBox.Text.StartsWith("-"))
                resultBox.Text = "-" + resultBox.Text;
            else
                resultBox.Text = resultBox.Text.Remove(0, 1);
        }

        #endregion buttonsSymbols
    }
}