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


    }
}
