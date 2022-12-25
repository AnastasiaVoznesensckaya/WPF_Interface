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

namespace Praktika2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CanvaName.EditingMode = InkCanvasEditingMode.None;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TextSize.Text = slide.Value.ToString();
            if (CanvaName == null) return;
            CanvaName.DefaultDrawingAttributes.Width = slide.Value;
            CanvaName.DefaultDrawingAttributes.Height = slide.Value;
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            CanvaName.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void ComboBoxItem_Selected_Green(object sender, RoutedEventArgs e)
        {
           CanvaName.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void ComboBoxItem_Selected_Blue(object sender, RoutedEventArgs e)
        {
            CanvaName.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void ComboBoxItem_Selected_Yellow(object sender, RoutedEventArgs e)
        {
            CanvaName.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void ComboBoxItem_Selected_Black(object sender, RoutedEventArgs e)
        {
            CanvaName.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void ComboBoxItem_Selected_Brown(object sender, RoutedEventArgs e)
        {
            CanvaName.DefaultDrawingAttributes.Color = Colors.Brown;
        }

        private void RadioButton_Boot2_Click(object sender, RoutedEventArgs e)
        {
            CanvaName.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void RadioButton_Boot3_Click(object sender, RoutedEventArgs e)
        {
            CanvaName.Strokes.Clear();
        }

        private void RadioButton_Boot1_Click(object sender, RoutedEventArgs e)
        {
            CanvaName.EditingMode = InkCanvasEditingMode.InkAndGesture;
        }
    }
}
