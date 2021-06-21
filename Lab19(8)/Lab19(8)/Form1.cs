using System;
using System.IO;
using System.Windows.Forms;

namespace Lab19_8_
{
    public partial class former : Form
    {
        public former()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string writePath = @"C:\TextArea\option.txt";

            string text = "TextBox: " + textBox1.Text + "\n" + "CheckBox1: " + checkBox1.Checked + "\n" + "CheckBox1: " + checkBox2.Checked + "\n" + "CheckBox1: " + checkBox3.Checked + "\n" + "Size H: " + former.ActiveForm.Height + "\n" + "Size W: " + former.ActiveForm.Width;
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync(".");
                    await sw.WriteAsync(".");
                }
                Console.WriteLine("Wrote!");
            }
            catch (Exception et)
            {
                Console.WriteLine(et.Message);
            }
        }
    }
}
