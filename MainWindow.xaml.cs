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

namespace ISRPO_Palashicheva_PR2
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

        float a, b;
        int count;
        bool znak = true;

        private void bt01_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb1.Text + 0;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb1.Text + 1;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {

            tb1.Text = tb1.Text + 2;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {

            tb1.Text = tb1.Text + 3;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {

            tb1.Text = tb1.Text + 4;
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {

            tb1.Text = tb1.Text + 5;
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {

            tb1.Text = tb1.Text + 6;
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {

            tb1.Text = tb1.Text + 7;
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {

            tb1.Text = tb1.Text + 8;
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {

            tb1.Text = tb1.Text + 9;
        }

        private void bt02_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb1.Text + ",";
        }

        private void bt07_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Clear();
            count = 1;
            lb.Content = a.ToString() + "+";
            znak = true;
        }

        private void bt06_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Clear();
            count = 2;
            lb.Content = a.ToString() + "-";
            znak = true;
        }

        private void bt05_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Clear();
            count = 3;
            lb.Content = a.ToString() + "*";
            znak = true;
        }

        private void bt04_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Clear();
            count = 4;
            lb.Content = a.ToString() + "/";
            znak = true;
        }

        private void bt03_Click(object sender, RoutedEventArgs e)
        {
            calculate();
            lb.Content = "";
        }

        private void calculate()
        {
            switch (count)
            {

                case 1:
                    b = a + float.Parse(tb1.Text);
                    tb1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(tb1.Text);
                    tb1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(tb1.Text);
                    tb1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(tb1.Text);
                    tb1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }

        private void bt010_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = "";
            lb.Content = "";
        }


        private void bt09_Click(object sender, RoutedEventArgs e)
        {
            int lenght = tb1.Text.Length - 1;
            string text = tb1.Text;
            tb1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                tb1.Text = tb1.Text + text[i];
            }

        }
        private void bt08_Click(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                tb1.Text = "-" + tb1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                tb1.Text = tb1.Text.Replace("-", "");
                znak = true;

            }




        }
    }
}
