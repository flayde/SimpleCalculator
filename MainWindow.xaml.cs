using System;
using System.Windows;

namespace SimpleCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInputs(out double num1, out double num2))
            {
                txtResult.Text = $"Результат: {num1 + num2}";
            }
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInputs(out double num1, out double num2))
            {
                txtResult.Text = $"Результат: {num1 - num2}";
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInputs(out double num1, out double num2))
            {
                txtResult.Text = $"Результат: {num1 * num2}";
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInputs(out double num1, out double num2))
            {
                if (num2 != 0)
                {
                    txtResult.Text = $"Результат: {num1 / num2}";
                }
                else
                {
                    MessageBox.Show("Деление на ноль невозможно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private bool TryParseInputs(out double num1, out double num2)
        {
            num1 = 0; // Инициализация переменной num1
            num2 = 0; // Инициализация переменной num2

            bool isValid = double.TryParse(txtFirstNumber.Text, out num1) && double.TryParse(txtSecondNumber.Text, out num2);
            if (!isValid)
            {
                MessageBox.Show("Введите корректные числа!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtResult.Text = string.Empty;
            }
            return isValid;
        }

    }
}