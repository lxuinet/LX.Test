﻿using System;
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

namespace Test3.WPF
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

            var text = new TextBox();
            text.Text = TextGenerator.Create(10000);
            text.TextWrapping = TextWrapping.Wrap;
            text.TextAlignment = TextAlignment.Right;
            scrollViewer.Content = text;
        }

        protected override void OnActivated(EventArgs e)
        {
            Title += " Launch duration: " + (DateTime.UtcNow - App.StartDate).ToString("c");
            base.OnActivated(e);
        }
    }
}
