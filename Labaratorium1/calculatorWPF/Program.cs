using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace calculatorWPF
{
    internal static class Program
    {
        private partial class Form1 : Form
        {
            #region declareButtons

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

            #endregion declareButtons

            #region declareTextBoxes

            private TextBox _textBox1;
            private TextBox _textBox2;
            private TextBox _textBox3;

            #endregion declareTextBoxes

            #region labels

            private Label _label1;
            private Label _label2;

            #endregion labels

            private TextBox _textBox;

            private void GetF(object sender, EventArgs e)
            {
                _textBox = sender as TextBox;
            }

            public Form1()
            {
                InstalizationComponents();
                this._textBox1.GotFocus += GetF;
                this._textBox2.GotFocus += GetF;
            }

            private void InstalizationComponents()
            {
                #region buttons

                _button1 = new Button();
                this._button1.AutoSize = true;
                this._button1.Location = new Point(30, 180);
                this._button1.Text = "+";
                this.Controls.Add(_button1);
                this._button1.Click += button1_Click;

                _button2 = new Button();
                this._button2.AutoSize = true;
                this._button2.Location = new Point(110, 180);
                this._button2.Text = "-";
                this.Controls.Add(_button2);
                this._button2.Click += button2_Click;

                _button3 = new Button();
                this._button3.AutoSize = true;
                this._button3.Location = new Point(110, 210);
                this._button3.Text = "/";
                this.Controls.Add(_button3);
                this._button3.Click += button3_Click;

                _button4 = new Button();
                this._button4.AutoSize = true;
                this._button4.Location = new Point(30, 210);
                this._button4.Text = "*";
                this.Controls.Add(_button4);
                this._button4.Click += button4_Click;

                _button5 = new Button();
                this._button5.AutoSize = true;
                this._button5.Location = new Point(190, 210);
                this._button5.Text = "C";
                this.Controls.Add(_button5);
                this._button5.Click += button5_Click;

                _number0 = new Button();
                this._number0.AutoSize = true;
                this._number0.Location = new Point(190, 180);
                this._number0.Text = "0";
                this.Controls.Add(_number0);
                this._number0.Click += number0_Click;

                _number1 = new Button();
                this._number1.AutoSize = true;
                this._number1.Location = new Point(30, 150);
                this._number1.Text = "1";
                this.Controls.Add(_number1);
                this._number1.Click += number1_Click;

                _number2 = new Button();
                this._number2.AutoSize = true;
                this._number2.Location = new Point(110, 150);
                this._number2.Text = "2";
                this.Controls.Add(_number2);
                this._number2.Click += number2_Click;

                _number3 = new Button();
                this._number3.AutoSize = true;
                this._number3.Location = new Point(190, 150);
                this._number3.Text = "3";
                this.Controls.Add(_number3);
                this._number3.Click += number3_Click;

                _number4 = new Button();
                this._number4.AutoSize = true;
                this._number4.Location = new Point(30, 120);
                this._number4.Text = "4";
                this.Controls.Add(_number4);
                this._number4.Click += number4_Click;

                _number5 = new Button();
                this._number5.AutoSize = true;
                this._number5.Location = new Point(110, 120);
                this._number5.Text = "5";
                this.Controls.Add(_number5);
                this._number5.Click += number5_Click;

                _number6 = new Button();
                this._number6.AutoSize = true;
                this._number6.Location = new Point(190, 120);
                this._number6.Text = "6";
                this.Controls.Add(_number6);
                this._number6.Click += number6_Click;

                _number7 = new Button();
                this._number7.AutoSize = true;
                this._number7.Location = new Point(30, 90);
                this._number7.Text = "7";
                this.Controls.Add(_number7);
                this._number7.Click += number7_Click;

                _number8 = new Button();
                this._number8.AutoSize = true;
                this._number8.Location = new Point(110, 90);
                this._number8.Text = "8";
                this.Controls.Add(_number8);
                this._number8.Click += number8_Click;

                _number9 = new Button();
                this._number9.AutoSize = true;
                this._number9.Location = new Point(190, 90);
                this._number9.Text = "9";
                this.Controls.Add(_number9);
                this._number9.Click += number9_Click;

                _dot = new Button();
                this._dot.AutoSize = true;
                this._dot.Location = new Point(110, 240);
                this._dot.Text = ".";
                this.Controls.Add(_dot);
                this._dot.Click += dot_Click;

                #endregion buttons

                #region textboxes

                _textBox1 = new TextBox();
                this._textBox1.Size = new Size(70, 70);
                this._textBox1.Location = new Point(30, 30);
                this.Controls.Add(_textBox1);

                _textBox2 = new TextBox();
                this._textBox2.Size = new Size(70, 70);
                this._textBox2.Location = new Point(115, 30);
                this.Controls.Add(_textBox2);

                _textBox3 = new TextBox();
                this._textBox3.Size = new Size(70, 70);
                this._textBox3.Location = new Point(200, 30);
                this.Controls.Add(_textBox3);

                #endregion textboxes

                #region labels

                _label1 = new Label();
                this._label1.AutoSize = true;
                this._label1.Location = new Point(103, 32);
                this._label1.Text = "";
                this.Controls.Add(_label1);

                _label2 = new Label();
                this._label2.AutoSize = true;
                this._label2.Location = new Point(186, 32);
                this._label2.Text = "=";
                this.Controls.Add(_label2);

                #endregion labels
            }

            #region button_Click

            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    if (_textBox1.Text != null && _textBox2.Text != null)
                    {
                        _label1.Text = "+";
                        var i = float.Parse(_textBox1.Text);
                        var n = float.Parse(_textBox2.Text);
                        var r = n + i;

                        _textBox3.Text = r.ToString(CultureInfo.InvariantCulture);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something bad happened: " + ex.Message, "Exception Sample", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                try
                {
                    if (_textBox1.Text != null && _textBox2.Text != null)
                    {
                        _label1.Text = "-";
                        var i = float.Parse(_textBox1.Text);
                        var n = float.Parse(_textBox2.Text);
                        var r = n - i;

                        _textBox3.Text = r.ToString(CultureInfo.CurrentCulture);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something bad happened: " + ex.Message, "Exception Sample", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void button3_Click(object sender, EventArgs e)
            {
                try
                {
                    if (_textBox1.Text == null || _textBox2.Text == null) return;
                    _label1.Text = "/";
                    var i = float.Parse(_textBox1.Text);
                    var n = float.Parse(_textBox2.Text);

                    if (n == 0)
                    {
                        const string message = "Cannot divide by 0";
                        const string tittle = "Error Message";
                        MessageBox.Show(message, tittle);
                    }
                    else
                    {
                        var r = (n / i);
                        _textBox3.Text = r.ToString(CultureInfo.CurrentCulture);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something bad happened: " + ex.Message, "Exception Sample", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void button4_Click(object sender, EventArgs e)
            {
                try
                {
                    if (_textBox1.Text != null && _textBox3.Text != null)
                    {
                        _label1.Text = "*";
                        var i = float.Parse(_textBox1.Text);
                        var n = float.Parse(_textBox2.Text);
                        var r = (n * i);

                        _textBox3.Text = r.ToString(CultureInfo.CurrentCulture);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something bad happened: " + ex.Message, "Exception Sample", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void button5_Click(object sender, EventArgs e)
            {
                _textBox1.Clear();
                _textBox2.Clear();
                _textBox3.Clear();
                _label1.Text = "";
            }

            #endregion button_Click

            #region number_Click

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

            #endregion number_Click
        }

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}