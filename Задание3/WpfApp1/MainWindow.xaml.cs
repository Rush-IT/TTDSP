using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            if (string.IsNullOrEmpty(input) || !IsNumeric(input))
            {
                resultTextBlock.Text = "Ошибка: Введите только цифры.";
            }
            else
            {
                resultTextBlock.Text = "Все хорошо!";
            }
        }

        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
