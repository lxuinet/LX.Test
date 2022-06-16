using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LX;

namespace Test1.LX
{
    public class MainForm : Control
    {
        public MainForm()
        {
            AddToRoot();

            Color = Color.Surface;
            Padding = 8;
            Alignment = Alignment.Fill;
            Layout = new VerticalList(8);

            var source = Image.LoadFromFile("test.png");

            for (int i = 0; i < 100000; i++)
            {
                var button = new Button();
                button.Color = Color.LightGray;
                button.Layout = VerticalList.Default;
                button.AddTo(this, Alignment.TopCenter);

                var label1 = button.Add("Top " + i.ToString(), Alignment.TopRight);
                var image1 = button.Add(source, Alignment.TopCenter);
                var label2 = button.Add("Bottom " + i.ToString(), Alignment.TopLeft);
            }

        }

        protected override void DoShow()
        {
            Window.Title += " Launch duration: " + (DateTime.UtcNow - Program.StartDate).ToString("c");
            base.DoShow();
        }
    }
}
