using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab13_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int order = 0;

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.Items.Count - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (order == Convert.ToInt32((sender as Button).Text) - 1)
            {
                (sender as Button).Visible = false;
                order = Convert.ToInt32((sender as Button).Text);
            }
            else
            {
                foreach (Button btn in tabPage2.Controls.OfType<Button>())
                {
                    btn.Visible = true;
                }
                order = 0;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (order == Convert.ToInt32((sender as Button).Text) - 1)
            {
                (sender as Button).Visible = false;
                order = Convert.ToInt32((sender as Button).Text);
            }
            else
            {
                foreach (Button btn in tabPage2.Controls.OfType<Button>())
                {
                    btn.Visible = true;
                }
                order = 0;
            }
            if ((sender as Button).Visible == false)
            {
                textBox2.Text = "Молодець!!!";
            }
        }
    }
}