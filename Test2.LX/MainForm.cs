using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using LX;

namespace Test2.LX
{
    public class MainForm : Control
    {
        public MainForm()
        {
            AddToRoot();

            Color = Color.Surface;
            Alignment = Alignment.Fill;
            Layout = new VerticalGallery();

            var list = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "png-256", "*.png").Select(file => Image.LoadFromFile(file)).ToList();

            for (int i = 0; i < 1000; i++)
            {
                list.ForEach(source =>
                {
                    var image = Add(source);
                    image.ImageAlignment = Alignment.Zoom;
                    image.Width = 128;
                    image.Height = 128;
                });
            }

        }
    }
}
