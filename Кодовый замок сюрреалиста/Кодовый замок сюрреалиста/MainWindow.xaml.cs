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
            while ((r == g | g == b | r == b) & r <= 80)
            {
                r = rand.Next(256);
                g = rand.Next(256);
                b = rand.Next(256);
            }
            brush.Color = Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b));
            return brush;
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
            but0.Content = nums[0];
            but1.Content = nums[1];
            but2.Content = nums[2];
            but3.Content = nums[3];
            but4.Content = nums[4];
            but5.Content = nums[5];
            but6.Content = nums[6];
            but7.Content = nums[7];
            but8.Content = nums[8];
            but9.Content = nums[9];
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            int num = rand.Next(10);

        }
    }
}
