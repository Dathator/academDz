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
using System.Windows.Threading;

namespace Кодовый_замок_сюрреалиста
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public Brush Make_Rand_Brush()
        {
            SolidColorBrush brush = new SolidColorBrush();
            int r = rand.Next(256);
            int g = rand.Next(256);
            int b = rand.Next(256);
            while (((r == g | g == b | r == b) & r <= 80) | ((r == g | g == b | r == b) & r >= 220))
            {
                r = rand.Next(256);
                g = rand.Next(256);
                b = rand.Next(256);
            }
            brush.Color = Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b));
            return brush;
        }

        public void Set_But_Num(Button but, int[] nums, int i)
        {
            if (nums[i] == 10)
            {
                but.Content = 0;
            }
            else
            {
                but.Content = nums[i];
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            but1.Background = Make_Rand_Brush();
            but2.Background = Make_Rand_Brush();
            but3.Background = Make_Rand_Brush();
            but4.Background = Make_Rand_Brush();
            but5.Background = Make_Rand_Brush();
            but6.Background = Make_Rand_Brush();
            but7.Background = Make_Rand_Brush();
            but8.Background = Make_Rand_Brush();
            but9.Background = Make_Rand_Brush();
            but0.Background = Make_Rand_Brush();
            butOk.Background = Make_Rand_Brush();
            butNo.Background = Make_Rand_Brush();

            int[] nums = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                int num = rand.Next(11);
                while (nums.Contains(num))
                {
                    num = rand.Next(11);
                }
                nums[i] = num;
            }
            Set_But_Num(but0, nums, 0);
            Set_But_Num(but1, nums, 1);
            Set_But_Num(but2, nums, 2);
            Set_But_Num(but3, nums, 3);
            Set_But_Num(but4, nums, 4);
            Set_But_Num(but5, nums, 5);
            Set_But_Num(but6, nums, 6);
            Set_But_Num(but7, nums, 7);
            Set_But_Num(but8, nums, 8);
            Set_But_Num(but9, nums, 9);
        }

        public void Change_But_Num(Button but1, Button but2)
        {
            object a = but1.Content;
            but1.Content = but2.Content;
            but2.Content = a;
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            switch (rand.Next(10))
            {
                case 0:
                    Change_But_Num(but, but0);
                    break;
                case 1:
                    Change_But_Num(but, but1);
                    break;
                case 2:
                    Change_But_Num(but, but2);
                    break;
                case 3:
                    Change_But_Num(but, but3);
                    break;
                case 4:
                    Change_But_Num(but, but4);
                    break;
                case 5:
                    Change_But_Num(but, but5);
                    break;
                case 6:
                    Change_But_Num(but, but6);
                    break;
                case 7:
                    Change_But_Num(but, but7);
                    break;
                case 8:
                    Change_But_Num(but, but8);
                    break;
                case 9:
                    Change_But_Num(but, but9);
                    break;
            }
            Text.Text += but.Content;
            Text.Margin = new Thickness(Text.Margin.Left + rand.Next(-10, 10), Text.Margin.Top + rand.Next(-10, 10), 0, 0);
        }

        private void butNoOk_Click(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            if (but.Name == "butNo")
            {
                but0.Content = "";
                but1.Content = "";
                but2.Content = "";
                but3.Content = "";
                but4.Content = "";
                but5.Content = "";
                but6.Content = "";
                but7.Content = "";
                but8.Content = "";
                but9.Content = "";
                Text.Text = "";
            }
            else if (but.Name == "butOk")
            {
                if (Convert.ToString(slider_label.Content) != "")
                {
                    if (Convert.ToInt32(Text.Text.Length) == Convert.ToInt32(slider_label.Content))
                    {
                        Text.Text = "Pin-код верен!";
                        but0.IsEnabled = false;
                        but1.IsEnabled = false;
                        but2.IsEnabled = false;
                        but3.IsEnabled = false;
                        but4.IsEnabled = false;
                        but5.IsEnabled = false;
                        but6.IsEnabled = false;
                        but7.IsEnabled = false;
                        but8.IsEnabled = false;
                        but9.IsEnabled = false;
                        butNo.IsEnabled = false;
                        butOk.IsEnabled = false;
                        Text.IsEnabled = false;
                        timer.Stop();
                    }
                }
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider_label.Content = slider.Value;
        }
    }
}
