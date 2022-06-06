using Avalonia.Controls;
using Avalonia.Media;

using Test3;

namespace Text3.Avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var scrollViewer = new ScrollViewer();
            this.Content = scrollViewer;

            var text = new TextBox();
            text.Text = TextGenerator.Create(10000);
            text.TextWrapping = TextWrapping.Wrap;
            text.TextAlignment = TextAlignment.Right;
            scrollViewer.Content = text;
        }
    }
}
