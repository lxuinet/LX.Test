using System;
using System.IO;
using System.Linq;

using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Media.Imaging;
using Avalonia.Media;
using Avalonia.Layout;
using System.Collections.Generic;

namespace Test2.Avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var scrollViewer = new ScrollViewer();
            Content = scrollViewer;

            var itemsRepeater = new ItemsRepeater()
            {
                Layout = new WrapLayout()
            };
            scrollViewer.Content = itemsRepeater;

            var images = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "png-256", "*.png").Select(file => new Bitmap(file)).ToArray();
            var source = new List<Bitmap>(images.Length * 1000);
            for (int i = 0; i < 1000; i++)
            {
                foreach (var image in images)
                {
                    source.Add(image);
                }
            }
            itemsRepeater.Items = source;

            itemsRepeater.ItemTemplate = new FuncDataTemplate<Bitmap>((source, _) => new Image
            {
                [!Image.SourceProperty] = new Binding("."),
                Stretch = Stretch.Uniform,
                Width = 128,
                Height = 128
            });
        }
    }
}
