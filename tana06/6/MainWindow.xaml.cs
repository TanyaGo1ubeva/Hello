using System;
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

namespace _6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(number.Text);
            string message = "";
            if (a == 0)
            {
                MessageBox.Show("Число - нуль");
            }
            else
            {
                if (a % 1 == 0)
                {
                    message += "Число целое";
                }
                else
                {
                    message += "Число не целое";
                }
                if (a > 0)
                {
                    message += ", положительное";
                }
                else
                {
                    message += ", отрицательное";
                }
                if (a % 2 == 0)
                {
                    message += ", четное";
                }
                else
                {
                    message += ", нечетное";
                }
                MessageBox.Show(message);
            }
        }
    }
}
