using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Lab_4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in MainGrid.Children)
                if (el is Button) ((Button)el).Click += Button_Click;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC") label.Text = "";
            else if(str == "=")
            {
                string result = new DataTable().Compute(label.Text,null).ToString();
                label.Text = result;
            }
            else label.Text += str;
        }
    }
}