using Avalonia.Controls;
using Avalonia.Media;
using System;
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

        protected override void OnOpened(EventArgs e)
        {
            Title += " Launch duration: " + (DateTime.UtcNow - Program.StartDate).ToString("c");
            base.OnOpened(e);
        }
    }
}
