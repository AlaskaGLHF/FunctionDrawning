using System;
using System.Windows.Forms;

namespace FunctionGrapher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFunctionOptions();
        }

        private void InitializeFunctionOptions()
        {
            // Добавляем функции в ComboBox
            comboBoxFunctions.Items.Add("y = ax + b");
            comboBoxFunctions.Items.Add("y = x^2");
            comboBoxFunctions.Items.Add("y = sqrt(x)");
            comboBoxFunctions.Items.Add("y = ln(x)");
            comboBoxFunctions.Items.Add("y = e^x");
            comboBoxFunctions.SelectedIndex = 0; // Первая функция выбрана по умолчанию
        }

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            PlotSelectedFunction();
        }

        private void PlotSelectedFunction()
        {
            // Очищаем предыдущие точки на графике
            chartFunction.Series[0].Points.Clear();

            // Получаем выбранную функцию
            string selectedFunction = comboBoxFunctions.SelectedItem.ToString();
            double a = 1.0, b = 0.0; // Задаем параметры для линейной функции, можно изменить на динамические

            // Строим график функции в диапазоне x от 0.1 до 10 с шагом 0.1
            for (double x = 0.1; x <= 10; x += 0.1)
            {
                double y = 0;
                switch (selectedFunction)
                {
                    case "y = ax + b":
                        y = a * x + b;
                        break;
                    case "y = x^2":
                        y = x * x;
                        break;
                    case "y = sqrt(x)":
                        y = Math.Sqrt(x);
                        break;
                    case "y = ln(x)":
                        y = Math.Log(x);
                        break;
                    case "y = e^x":
                        y = Math.Exp(x);
                        break;
                    default:
                        MessageBox.Show("Неизвестная функция.");
                        return;
                }
                chartFunction.Series[0].Points.AddXY(x, y);
            }
        }
    }
}
