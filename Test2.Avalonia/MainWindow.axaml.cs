using System;

using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Media;
using Avalonia.Threading;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Linq;

namespace Test2.Avalonia
{
    public partial class MainWindow : Window
    {
        private Bitmap source;
        public MainWindow()
        {
            InitializeComponent();

            var viewer = new ScrollViewer();
            Content = viewer;

            var panel = new WrapPanel();
            viewer.Content = panel;

            var list = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "png-256", "*.png").Select(file => new Bitmap(file)).ToList();

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

        protected override void OnOpened(EventArgs e)
        {
            Title += " Launch duration: " + (DateTime.UtcNow - Program.StartDate).ToString("c");
            base.OnOpened(e);
        }
    }
}
