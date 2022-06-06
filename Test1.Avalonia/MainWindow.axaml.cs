using System;

using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media.Imaging;
using Avalonia.Media;
using Avalonia;

namespace Test1.Avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var scrollViewer = new ScrollViewer();
            this.Content = scrollViewer;

            var panel = new StackPanel();
            scrollViewer.Content = panel;

            var source = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "test.png");


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
