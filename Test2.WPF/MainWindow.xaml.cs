using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Test2.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var viewer = new ScrollViewer();
            Content = viewer;

            var panel = new WrapPanel();
            viewer.Content = panel;

            var list = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "png-256", "*.png").Select(file => new BitmapImage(new Uri(file))).ToList();

            for (int i = 0; i < 100; i++)
            {
                list.ForEach(source =>
                {
                    var image = new Image();
                    image.Source = source;
                    image.Stretch = Stretch.Uniform;
                    image.Width = 128;
                    image.Height = 128;
                    panel.Children.Add(image);
                });
            }

        }
    }
}
