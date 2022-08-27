using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace calculatorWPF
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainWindow());
        }

        private sealed class MainWindow : Form
        {
            private TextBox _textBox;

            public MainWindow()
            {
                InitialComponents();
                _textBox1.GotFocus += OnGetFocused;
                _textBox2.GotFocus += OnGetFocused;
            }

            private void OnGetFocused(object sender, EventArgs e)
            {
                _textBox = sender as TextBox;
            }

            private void InitialComponents()
            {
                _button1 = new Button();
                _button1.AutoSize = true;
                _button1.Location = new Point(30, 180);
                _button1.Text = "+";
                Controls.Add(_button1);
                _button1.Click += btn_Sum;

                _button2 = new Button();
                _button2.AutoSize = true;
                _button2.Location = new Point(110, 180);
                _button2.Text = "-";
                Controls.Add(_button2);
                _button2.Click += btn_Subtraction;

                _button3 = new Button();
                _button3.AutoSize = true;
                _button3.Location = new Point(110, 210);
                _button3.Text = "/";
                Controls.Add(_button3);
                _button3.Click += btn_Division;

                _button4 = new Button();
                _button4.AutoSize = true;
                _button4.Location = new Point(30, 210);
                _button4.Text = "*";
                Controls.Add(_button4);
                _button4.Click += btn_Multiplication;

                _button5 = new Button();
                _button5.AutoSize = true;
                _button5.Location = new Point(190, 210);
                _button5.Text = "C";
                Controls.Add(_button5);
                _button5.Click += btn_Clear;

                _number0 = new Button();
                _number0.AutoSize = true;
                _number0.Location = new Point(190, 180);
                _number0.Text = "0";
                Controls.Add(_number0);
                _number0.Click += number0_Click;

                _number1 = new Button();
                _number1.AutoSize = true;
                _number1.Location = new Point(30, 150);
                _number1.Text = "1";
                Controls.Add(_number1);
                _number1.Click += number1_Click;

                _number2 = new Button();
                _number2.AutoSize = true;
                _number2.Location = new Point(110, 150);
                _number2.Text = "2";
                Controls.Add(_number2);
                _number2.Click += number2_Click;

                _number3 = new Button();
                _number3.AutoSize = true;
                _number3.Location = new Point(190, 150);
                _number3.Text = "3";
                Controls.Add(_number3);
                _number3.Click += number3_Click;

                _number4 = new Button();
                _number4.AutoSize = true;
                _number4.Location = new Point(30, 120);
                _number4.Text = "4";
                Controls.Add(_number4);
                _number4.Click += number4_Click;

                _number5 = new Button();
                _number5.AutoSize = true;
                _number5.Location = new Point(110, 120);
                _number5.Text = "5";
                Controls.Add(_number5);
                _number5.Click += number5_Click;

                _number6 = new Button();
                _number6.AutoSize = true;
                _number6.Location = new Point(190, 120);
                _number6.Text = "6";
                Controls.Add(_number6);
                _number6.Click += number6_Click;

                _number7 = new Button();
                _number7.AutoSize = true;
                _number7.Location = new Point(30, 90);
                _number7.Text = "7";
                Controls.Add(_number7);
                _number7.Click += number7_Click;

                _number8 = new Button();
                _number8.AutoSize = true;
                _number8.Location = new Point(110, 90);
                _number8.Text = "8";
                Controls.Add(_number8);
                _number8.Click += number8_Click;

                _number9 = new Button();
                _number9.AutoSize = true;
                _number9.Location = new Point(190, 90);
                _number9.Text = "9";
                Controls.Add(_number9);
                _number9.Click += number9_Click;

                _dot = new Button();
                _dot.AutoSize = true;
                _dot.Location = new Point(110, 240);
                _dot.Text = ".";
                Controls.Add(_dot);
                _dot.Click += dot_Click;

                _textBox1 = new TextBox();
                _textBox1.Size = new Size(70, 70);
                _textBox1.Location = new Point(30, 30);
                Controls.Add(_textBox1);

                _textBox2 = new TextBox();
                _textBox2.Size = new Size(70, 70);
                _textBox2.Location = new Point(115, 30);
                Controls.Add(_textBox2);

                _textBox3 = new TextBox();
                _textBox3.Size = new Size(70, 70);
                _textBox3.Location = new Point(200, 30);
                Controls.Add(_textBox3);

                _label1 = new Label();
                _label1.AutoSize = true;
                _label1.Location = new Point(103, 32);
                _label1.Text = "";
                Controls.Add(_label1);

                _label2 = new Label();
                _label2.AutoSize = true;
                _label2.Location = new Point(186, 32);
                _label2.Text = "=";
                Controls.Add(_label2);
            }

            private Button _button1;
            private Button _button2;
            private Button _button3;
            private Button _button4;
            private Button _button5;

            private Button _number1;
            private Button _number2;
            private Button _number3;
            private Button _number4;
            private Button _number5;
            private Button _number6;
            private Button _number7;
            private Button _number8;
            private Button _number9;
            private Button _number0;
            private Button _dot;

            private TextBox _textBox1;
            private TextBox _textBox2;
            private TextBox _textBox3;

            private Label _label1;
            private Label _label2;
            
            private void btn_Sum(object sender, EventArgs e)
            {
                if (_textBox1.Text != null && _textBox2.Text != null)
                {
                    _label1.Text = "+";
                    var firstNumber = float.Parse(_textBox1.Text);
                    var secondNumber = float.Parse(_textBox2.Text);
                    var result = secondNumber + firstNumber;

                    _textBox3.Text = result.ToString();
                }
            }

            private void btn_Subtraction(object sender, EventArgs e)
            {
                if (_textBox1.Text != null && _textBox2.Text != null)
                {
                    _label1.Text = "-";
                    var firstNumber = float.Parse(_textBox1.Text);
                    var secondNumber = float.Parse(_textBox2.Text);
                    var result = secondNumber - firstNumber;

                    _textBox3.Text = result.ToString(CultureInfo.CurrentCulture);
                }
            }

            private void btn_Division(object sender, EventArgs e)
            {
                if (_textBox1.Text != null && _textBox2.Text != null)
                {
                    _label1.Text = "/";
                    var firstNumber = float.Parse(_textBox1.Text);
                    var secondNumber = float.Parse(_textBox2.Text);

                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                        return;
                    }
                    
                    var result = secondNumber / firstNumber;
                    _textBox3.Text = result.ToString();
                }
            }

            private void btn_Multiplication(object sender, EventArgs e)
            {
                if (_textBox1.Text != null && _textBox3.Text != null)
                {
                    _label1.Text = "*";
                    var firstNumber = float.Parse(_textBox1.Text);
                    var secondNumber = float.Parse(_textBox2.Text);
                    var result = firstNumber * secondNumber;

                    _textBox3.Text = result.ToString(CultureInfo.InvariantCulture);
                }
            }

            private void btn_Clear(object sender, EventArgs e)
            {
                _textBox1.Clear();
                _textBox2.Clear();
                _textBox3.Clear();
                _label1.Text = "";
            }

            private void number0_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += "0";
            }

            private void number1_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += "1";
            }

            private void number2_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += "2";
            }

            private void number3_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += "3";
            }

            private void number4_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += "4";
            }

            private void number5_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += "5";
            }

            private void number6_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += "6";
            }

            private void number7_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += "7";
            }

            private void number8_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += "8";
            }

            private void number9_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += "9";
            }

            private void dot_Click(object sender, EventArgs e)
            {
                if (_textBox != null) _textBox.SelectedText += ".";
            }
        }
    }
}