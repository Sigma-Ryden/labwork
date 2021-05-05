using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab14_3_
{
    public partial class Form1 : Form
    {
        public bool clicker = false;
        public Form1()
        {
            InitializeComponent();
            Random n = new Random();

            button1.Location = new Point(n.Next(550), n.Next(300));
            button1.Width = 200;
            button1.Height = 200;
            label1.ForeColor = Color.Transparent;
            button1.TabStop = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
            label1.Text = "win";
            clicker = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(100, 100);
            button1.Width = 200;
            button1.Height = 200;
            label1.ForeColor = Color.Transparent;
            clicker = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = button1.Location.X;
            int y = button1.Location.Y;

            Random n = new Random();
            int k = n.Next(5);

            if (!clicker)
            {
                if (button1.Width == 0 && button1.Height == 0)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "lose";
                }

                if (button1.Location.X < 750)
                {
                    switch (k)
                    {
                        case 1:
                            button1.Location = new Point(x + n.Next(15), y + n.Next(15));
                            break;
                        case 2:
                            button1.Location = new Point(x - n.Next(15), y + n.Next(15));
                            break;
                        case 3:
                            button1.Location = new Point(x + n.Next(15), y - n.Next(15));
                            break;
                        case 4:
                            button1.Location = new Point(x - n.Next(15), y - n.Next(15));
                            break;
                    }
                    button1.Width = button1.Width - n.Next(5);
                    button1.Height = button1.Height - n.Next(5);
                }
                else
                {
                    button1.Location = new Point(n.Next(400), n.Next(400));
                }

                if (button1.Left < 50) button1.Left = 50;
                if ((button1.Left + button1.Width) > ClientSize.Width) button1.Left = ClientSize.Width - button1.Width;
                if (button1.Top < 50) button1.Top = 50;
                if ((button1.Top + button1.Height) > ClientSize.Height) button1.Top = ClientSize.Height - button1.Height;
            }
        }
    }
}