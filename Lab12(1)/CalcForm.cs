using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Lab_12.Entities;

namespace Lab_12
{
    public partial class CalcForm : Form
    {
        private readonly string[] _calcSymbols = {
            "7", "8", "9", "/",
            "4", "5", "6", "*",
            "1", "2", "3", "-",
            "0", ",", "=", "+" 
        };
        private bool _activeOperation;
        private Operator _operator;
        
        public CalcForm()
        {
            InitializeComponent();
            InitKeyboardLayout();
            _operator = new Operator();
        }
        
        private void InitKeyboardLayout()
        {
            int buttonSize = 30;
            int layoutCounter = 0;
            for (int i = 0; i < _calcSymbols.Length / 4; ++i)
            {
                for (int j = 0; j < _calcSymbols.Length / 4; ++j)
                {
                    Button button = new Button
                    {
                        Location = new Point((buttonSize + 10) * j, (buttonSize + 10) * i),
                        Text = _calcSymbols[layoutCounter++],
                        ForeColor = Color.Black,
                        FlatStyle = FlatStyle.Standard,
                        BackColor = Color.FromArgb(255, 255, 255),
                        Size = new Size(buttonSize, buttonSize),
                    };
                    button.Click += Button_Click;
                    KeyboardLayout.Controls.Add(button);
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (double.TryParse(button.Text, out double _))
            {
                if (_activeOperation)
                {
                    TextField.Clear();
                    _activeOperation = !_activeOperation;
                }
                if (TextField.Text == "0" || TextField.Text == "∞" || TextField.Text == "-∞")
                    TextField.Text = button.Text;
                else
                    TextField.Text += button.Text;
                return;
            }

            switch (button.Text)
            {
                case "+":
                    _activeOperation = true;
                    UpdateNumberIfNotEmpty(TextField, 
                        _operator.GetResult(new PlusOperation(), double.Parse(TextField.Text)).ToString());
                    break;
                case "-":
                    _activeOperation = true;
                    UpdateNumberIfNotEmpty(TextField, 
                        _operator.GetResult(new MinusOperation(), double.Parse(TextField.Text)).ToString());
                    break;
                case "*":
                    _activeOperation = true;
                    UpdateNumberIfNotEmpty(TextField, 
                        _operator.GetResult(new MultiplyOperation(), double.Parse(TextField.Text)).ToString());
                    break;
                case "/":
                    _activeOperation = true;
                    UpdateNumberIfNotEmpty(TextField, 
                        _operator.GetResult(new DivideOperation(), double.Parse(TextField.Text)).ToString());
                    break;
                case "=":
                    UpdateNumberIfNotEmpty(TextField, 
                        _operator.GetResult(null, double.Parse(TextField.Text)).ToString());
                    break;
                case ",":
                {
                    if (_activeOperation || TextField.Text.Contains(","))
                    {
                        return;
                    }

                    TextField.Text += ',';
                    break;
                }
               default:
                    MessageBox.Show(@"Error!");
                    break;
            }
        }

        private void UpdateNumberIfNotEmpty(TextBox textBox, string newValue)
        {
            if (!string.IsNullOrEmpty(newValue))
            {
                textBox.Text = newValue;
            }
        }
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextField.Clear();
            _operator.Reset();
        }

        private void ChangeSignButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextField.Text, out double number) || number == 0)
            {
                return;
            }
            
            if (number >= 1)
            {
                TextField.Text = '-' + TextField.Text;
            }
            else
            {
                TextField.Text = (number * -1).ToString(CultureInfo.CurrentCulture);
            }
        }
    }
}