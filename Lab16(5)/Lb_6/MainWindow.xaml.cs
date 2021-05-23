using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Lab_6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init_Button();
        }
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "")
            {
                comboBox.Items.Add(textbox1.Text);
                textbox1.Text = "";
            }
        }
        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (textbox1.Text != "")
                {
                    comboBox.Items.Add(textbox1.Text);
                    textbox1.Text = "";
                }
            }
            if (e.Key == Key.Delete)
                comboBox.Items.Remove(comboBox.SelectedItem);
        }
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Remove(comboBox.SelectedItem);
        }
        private void textbox1_TextChanged(object sender, TextChangedEventArgs e) { }
        public Button[] arrayOfButtons = new Button[16];

        TextBox tb = new TextBox
        {
            Height = 50,
            Width = 400,
            Text = "How to add",
            FontSize = 20
        };
        public void Init_Button()
        {  
            int x = 1;
            int y = 1;
            int namebtn = 1;
            for (int i = 0; i < 16; ++i)
            {
                if (i % 4 == 0)
                {
                    ++x;
                    y = 1;
                }
                arrayOfButtons[i] = new Button();
                arrayOfButtons[i].Margin = new Thickness(x * 50, y * 50, 0, 40);
                arrayOfButtons[i].Width = 50;
                arrayOfButtons[i].Height = 50;

                arrayOfButtons[i].Background = Brushes.Gray;
                arrayOfButtons[i].Content = namebtn.ToString();
                arrayOfButtons[i].MouseDown += new MouseButtonEventHandler(arrayOfButtons_MouseClick);
                ++namebtn;
                ++y;
                tbControl.Items.Add(arrayOfButtons[i]);
            }
            tbControl.Items.Add(tb);
        }
        int mustClick1 = 1;
        int wasClicked;
        void arrayOfButtons_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            wasClicked = Convert.ToInt32(button.Content);
            if (wasClicked == mustClick1)
            {
                mustClick1++;
                tb.Text = "";
                if (mustClick1 == 17)
                {
                    tb.Text = "Good!";
                    mustClick1 = 1;
                }
            }
            else
            {
                mustClick1 = 1;
                tb.Text = "Error!";
            }
        }
    }
}
