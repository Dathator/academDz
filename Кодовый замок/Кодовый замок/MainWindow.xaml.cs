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

namespace Кодовый_замок
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string PIN = "5674";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but_1_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "1";
        }

        private void but_2_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "2";
        }

        private void but_3_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "3";
        }

        private void but_4_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "4";
        }

        private void but_5_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "5";
        }

        private void but_6_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "6";
        }

        private void but_7_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "7";
        }

        private void but_8_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "8";
        }

        private void but_9_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "9";
        }

        private void but_0_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "0";
        }

        private void but_no_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
        }

        private void but_ok_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == PIN)
            {
                text.Text = "Пинкод верен!";
                but_1.IsEnabled = false;
                but_2.IsEnabled = false;
                but_3.IsEnabled = false;
                but_4.IsEnabled = false;
                but_5.IsEnabled = false;
                but_6.IsEnabled = false;
                but_7.IsEnabled = false;
                but_8.IsEnabled = false;
                but_9.IsEnabled = false;
                but_0.IsEnabled = false;
                but_no.IsEnabled = false;
                but_ok.IsEnabled = false;
            }
            else
            {
                text.Text = "";
            }
        }
    }
}
