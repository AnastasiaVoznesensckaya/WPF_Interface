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

namespace Practika
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

    

        private void MenuItem_Click_info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Вознесенская Анастасия", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Click_exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_Red(object sender, RoutedEventArgs e)
        {
           Window.Background = new SolidColorBrush(Colors.Red);
        }

        private void MenuItem_Click_Yellow(object sender, RoutedEventArgs e)
        {
            Window.Background = new SolidColorBrush((Color)Colors.Yellow);
        }

        private void MenuItem_Click_Gray(object sender, RoutedEventArgs e)
        {
            Window.Background = new SolidColorBrush(Colors.Gray);
        }

        private void MenuItem_Click_Blue(object sender, RoutedEventArgs e)
        {
            Window.Background= new SolidColorBrush((Color)Colors.Blue);
        }

        private void MenuItem_Click_Orange(object sender, RoutedEventArgs e)
        {
            Window.Background = new SolidColorBrush(Colors.Orange);
        }

        private void ToolBar_MouseEnter(object sender, MouseEventArgs e)
        {
            Bar.Text = "Элемент управления: ToolBar";
        }

        private void ToolBar_MouseLeave(object sender, MouseEventArgs e)
        {
            Bar.Text = "";
        }

        private void Menu_MouseEnter(object sender, MouseEventArgs e)
        {
            Bar.Text = "Элемент управления: Menu";
        }

        private void Menu_MouseLeave(object sender, MouseEventArgs e)
        {
            Bar.Text = "";
        }
    }
}
