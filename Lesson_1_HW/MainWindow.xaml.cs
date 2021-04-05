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

namespace Lesson_1_HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Random rnd = new Random();
            SolidColorBrush brush =
                  new SolidColorBrush(
                      Color.FromRgb(
                      (byte)rnd.Next(255),
                      (byte)rnd.Next(255),
                      (byte)rnd.Next(255)
                      ));
            button.Background = brush;
            MessageBox.Show($"I AM BUTTON № {button.Content}");

        }

        private void button1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button_delete = sender as Button;
            var text=(string)button_delete.Content;
            Title = text;
            MessageBox.Show($"Title`s text changed to # {  button_delete.Content}  #");
            button_delete.Visibility = Visibility.Collapsed;
        }
    }
}
