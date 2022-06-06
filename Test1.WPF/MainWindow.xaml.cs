using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Test1.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var scrollViewer = new ScrollViewer();
            this.Content = scrollViewer;

            var panel = new StackPanel();
            scrollViewer.Content = panel;

            var source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "test.png"));


            for (int i = 0; i < 10000; i++)
            {
                var button = new Button();
                button.Margin = new Thickness(0, 0, 0, 8);
                button.HorizontalAlignment = HorizontalAlignment.Center;

                var buttonStack = new StackPanel();
                button.Content = buttonStack;

                var label1 = new Label();
                label1.HorizontalAlignment = HorizontalAlignment.Right;
                label1.Content = "Top " + i.ToString();
                buttonStack.Children.Add(label1);

                var image1 = new Image();
                image1.Source = source;
                image1.Stretch = Stretch.None;
                image1.HorizontalAlignment = HorizontalAlignment.Stretch;
                buttonStack.Children.Add(image1);

                var label2 = new Label();
                label2.HorizontalAlignment = HorizontalAlignment.Left;
                label2.Content = "Bottom " + i.ToString();
                buttonStack.Children.Add(label2);

                panel.Children.Add(button);
            }
        }
    }
}
