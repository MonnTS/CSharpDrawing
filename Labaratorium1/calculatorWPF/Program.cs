using System;
using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace calculatorWPF
{
    internal class Program
    {
        public partial class Form1 : Form
        {
            #region declareButtons

            public Button button1;
            public Button button2;
            public Button button3;
            public Button button4;
            public Button button5;

            public Button number1;
            public Button number2;
            public Button number3;
            public Button number4;
            public Button number5;
            public Button number6;
            public Button number7;
            public Button number8;
            public Button number9;
            public Button number0;
            public Button dot;

            #endregion declareButtons

            #region declareTextBoxes

            private TextBox textBox1;
            private TextBox textBox2;
            private TextBox textBox3;

            #endregion declareTextBoxes

            #region labels

            public Label label1;
            public Label label2;

            #endregion labels

            private TextBox textBox = null;

            private void GetF(object sender, EventArgs e)
            {
                textBox = sender as TextBox;
            }

            public Form1()
            {
                InstalizationComponents();
                this.textBox1.GotFocus += new EventHandler(GetF);
                this.textBox2.GotFocus += new EventHandler(GetF);
            }

            private void InstalizationComponents()
            {
                #region buttons

                button1 = new Button();
                this.button1.AutoSize = true;
                this.button1.Location = new Point(30, 180);
                this.button1.Text = "+";
                this.Controls.Add(button1);
                this.button1.Click += new EventHandler(button1_Click);

                button2 = new Button();
                this.button2.AutoSize = true;
                this.button2.Location = new Point(110, 180);
                this.button2.Text = "-";
                this.Controls.Add(button2);
                this.button2.Click += new EventHandler(button2_Click);

                button3 = new Button();
                this.button3.AutoSize = true;
                this.button3.Location = new Point(110, 210);
                this.button3.Text = "/";
                this.Controls.Add(button3);
                this.button3.Click += new EventHandler(button3_Click);

                button4 = new Button();
                this.button4.AutoSize = true;
                this.button4.Location = new Point(30, 210);
                this.button4.Text = "*";
                this.Controls.Add(button4);
                this.button4.Click += new EventHandler(button4_Click);

                button5 = new Button();
                this.button5.AutoSize = true;
                this.button5.Location = new Point(190, 210);
                this.button5.Text = "C";
                this.Controls.Add(button5);
                this.button5.Click += new EventHandler(button5_Click);

                number0 = new Button();
                this.number0.AutoSize = true;
                this.number0.Location = new Point(190, 180);
                this.number0.Text = "0";
                this.Controls.Add(number0);
                this.number0.Click += new EventHandler(number0_Click);

                number1 = new Button();
                this.number1.AutoSize = true;
                this.number1.Location = new Point(30, 150);
                this.number1.Text = "1";
                this.Controls.Add(number1);
                this.number1.Click += new EventHandler(number1_Click);

                number2 = new Button();
                this.number2.AutoSize = true;
                this.number2.Location = new Point(110, 150);
                this.number2.Text = "2";
                this.Controls.Add(number2);
                this.number2.Click += new EventHandler(number2_Click);

                number3 = new Button();
                this.number3.AutoSize = true;
                this.number3.Location = new Point(190, 150);
                this.number3.Text = "3";
                this.Controls.Add(number3);
                this.number3.Click += new EventHandler(number3_Click);

                number4 = new Button();
                this.number4.AutoSize = true;
                this.number4.Location = new Point(30, 120);
                this.number4.Text = "4";
                this.Controls.Add(number4);
                this.number4.Click += new EventHandler(number4_Click);

                number5 = new Button();
                this.number5.AutoSize = true;
                this.number5.Location = new Point(110, 120);
                this.number5.Text = "5";
                this.Controls.Add(number5);
                this.number5.Click += new EventHandler(number5_Click);

                number6 = new Button();
                this.number6.AutoSize = true;
                this.number6.Location = new Point(190, 120);
                this.number6.Text = "6";
                this.Controls.Add(number6);
                this.number6.Click += new EventHandler(number6_Click);

                number7 = new Button();
                this.number7.AutoSize = true;
                this.number7.Location = new Point(30, 90);
                this.number7.Text = "7";
                this.Controls.Add(number7);
                this.number7.Click += new EventHandler(number7_Click);

                number8 = new Button();
                this.number8.AutoSize = true;
                this.number8.Location = new Point(110, 90);
                this.number8.Text = "8";
                this.Controls.Add(number8);
                this.number8.Click += new EventHandler(number8_Click);

                number9 = new Button();
                this.number9.AutoSize = true;
                this.number9.Location = new Point(190, 90);
                this.number9.Text = "9";
                this.Controls.Add(number9);
                this.number9.Click += new EventHandler(number9_Click);

                dot = new Button();
                this.dot.AutoSize = true;
                this.dot.Location = new Point(110, 240);
                this.dot.Text = ".";
                this.Controls.Add(dot);
                this.dot.Click += new EventHandler(dot_Click);

                #endregion buttons

                #region textboxes

                textBox1 = new TextBox();
                this.textBox1.Size = new Size(70, 70);
                this.textBox1.Location = new Point(30, 30);
                this.Controls.Add(textBox1);

                textBox2 = new TextBox();
                this.textBox2.Size = new Size(70, 70);
                this.textBox2.Location = new Point(115, 30);
                this.Controls.Add(textBox2);

                textBox3 = new TextBox();
                this.textBox3.Size = new Size(70, 70);
                this.textBox3.Location = new Point(200, 30);
                this.Controls.Add(textBox3);

                #endregion textboxes

                #region labels

                label1 = new Label();
                this.label1.AutoSize = true;
                this.label1.Location = new Point(103, 32);
                this.label1.Text = "";
                this.Controls.Add(label1);

                label2 = new Label();
                this.label2.AutoSize = true;
                this.label2.Location = new Point(186, 32);
                this.label2.Text = "=";
                this.Controls.Add(label2);

                #endregion labels
            }

            #region button_Click

            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    if (textBox1.Text != null && textBox2.Text != null)
                    {
                        label1.Text = "+";
                        float i, n, r;
                        i = float.Parse(textBox1.Text);
                        n = float.Parse(textBox2.Text);
                        r = n + i;

                        textBox3.Text = r.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something bad happend: " + ex.Message, "Exepction Sample", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                try
                {
                    if (textBox1.Text != null && textBox2.Text != null)
                    {
                        label1.Text = "-";
                        float i, n, r;
                        i = float.Parse(textBox1.Text);
                        n = float.Parse(textBox2.Text);
                        r = n - i;

                        textBox3.Text = r.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something bad happend: " + ex.Message, "Exepction Sample", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void button3_Click(object sender, EventArgs e)
            {
                try
                {
                    if (textBox1.Text != null && textBox2.Text != null)
                    {
                        label1.Text = "/";
                        float i, n, r;
                        i = float.Parse(textBox1.Text);
                        n = float.Parse(textBox2.Text);

                        if (n == 0)
                        {
                            string message = "Cannot devide by 0";
                            string tittle = "Error Message";
                            MessageBox.Show(message, tittle);
                        }
                        else
                        {
                            r = (n / i);
                            textBox3.Text = r.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something bad happend: " + ex.Message, "Exepction Sample", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void button4_Click(object sender, EventArgs e)
            {
                try
                {
                    if (textBox1.Text != null && textBox3.Text != null)
                    {
                        label1.Text = "*";
                        float i, n, r;
                        i = float.Parse(textBox1.Text);
                        n = float.Parse(textBox2.Text);
                        r = (n * i);

                        textBox3.Text = r.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something bad happend: " + ex.Message, "Exepction Sample", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void button5_Click(object sender, EventArgs e)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                label1.Text = "";
            }

            #endregion button_Click

            #region number_Click

            private void number0_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += "0";
            }

            private void number1_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += "1";
            }

            private void number2_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += "2";
            }

            private void number3_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += "3";
            }

            private void number4_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += "4";
            }

            private void number5_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += "5";
            }

            private void number6_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += "6";
            }

            private void number7_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += "7";
            }

            private void number8_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += "8";
            }

            private void number9_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += "9";
            }

            private void dot_Click(object sender, EventArgs e)
            {
                if (textBox != null) textBox.SelectedText += ".";
            }

            #endregion number_Click
        }

        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}