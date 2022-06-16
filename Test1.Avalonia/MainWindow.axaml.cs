using System;
using System.Linq;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Layout;
using Avalonia.Media.Imaging;
using Avalonia.Media;

namespace Test1.Avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var scrollViewer = new ScrollViewer();
            Content = scrollViewer;

            var itemsRepeater = new ItemsRepeater();
            scrollViewer.Content = itemsRepeater;

            var source = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "test.png");

            itemsRepeater.Items = Enumerable.Range(0, 10000);
            itemsRepeater.ItemTemplate = new FuncDataTemplate<int>((item, _) => new Button
            {
                Margin = new Thickness(0, 0, 0, 8),
                HorizontalAlignment = HorizontalAlignment.Center,

                Content = new StackPanel
                {
                    Children =
                    {
                        new Label
                        {
                            HorizontalAlignment = HorizontalAlignment.Right,
                            [!ContentProperty] = new Binding(".") { StringFormat = "Top {0}" }
                        },
                        new Image
                        {
                            Source = source,
                            Stretch = Stretch.None,
                            HorizontalAlignment = HorizontalAlignment.Stretch
                        },
                        new Label
                        {
                            HorizontalAlignment = HorizontalAlignment.Left,
                            [!ContentProperty] = new Binding(".") { StringFormat = "Bottom {0}" }
                        }
                    }
                }
            });
        }
    }
}
