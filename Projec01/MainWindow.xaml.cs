using System;
using System.Data; //дополнительная библиотека для выполнения математических действий
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projec01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement el in MainRoot.Children) //перебираем элементы, отделяем кнопки от текстовой надписи
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click; //ссылка на метод при событии нажатия на кнопку
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) //реализация метода
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC") //если пользователь нажал АС, происходит очищение текстового поля
                textLabel.Text = "";
            else if (str == "sin")
            {
                textLabel.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textLabel.Text)));
            }
            else if (str == "cos")
            {
                textLabel.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textLabel.Text)));
            }
            else if (str == "tg")
            {
                textLabel.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textLabel.Text)));
            }
            else if (str == "arcsin")
            {
                textLabel.Text = Convert.ToString(System.Math.Sinh(Convert.ToDouble(textLabel.Text)));
            }
            else if (str == "arccos")
            {
                textLabel.Text = Convert.ToString(System.Math.Cosh(Convert.ToDouble(textLabel.Text)));
            }
            else if (str == "arctg")
            {
                textLabel.Text = Convert.ToString(System.Math.Tanh(Convert.ToDouble(textLabel.Text)));
            }
            else if (str == "sqrt")
            {
                textLabel.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textLabel.Text)));
            }
            else if (str == "x^2")
            {
                textLabel.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(textLabel.Text), 2));
            }
            else if (str == "=") //если пользователь нажал =
            {
                string value = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = value;
            }
            else //если пользователь просто жмет кнопки, вывод символов в текстовое поле
                textLabel.Text += str;
        }
    }
}
