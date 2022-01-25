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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp16
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            // doubleAnimation.From = 150;
            doubleAnimation.To = 500;
            // doubleAnimation.By = 10;
            // doubleAnimation.Duration = TimeSpan.FromSeconds(2);
            //doubleAnimation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(6));//повторнаяя анимация
            //doubleAnimation.SpeedRatio=0.5; ускорение/замедление
            //doubleAnimation.AutoReverse = true; реверс 
            //doubleAnimation.FillBehavior = FillBehavior.Stop; нужно ли вернуться к стартовым размерам

            btn.BeginAnimation(Button.WidthProperty, doubleAnimation);
            btn.BeginAnimation(Button.HeightProperty, doubleAnimation);

            ColorAnimation colorAnimation = new ColorAnimation();
            colorAnimation.From = Colors.Red;
            colorAnimation.To = Colors.Blue;
            colorAnimation.Duration = TimeSpan.FromSeconds(2);
            btn.Background = new SolidColorBrush(Colors.Red);
            btn.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
        }
    }
}
