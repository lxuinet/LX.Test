using System.Diagnostics;
using System.IO;

using LX;

namespace Test3.LX
{
    public class MainForm : Control
    {
        public MainForm()
        {
            AddToRoot();

            Color = Color.Surface;
            Alignment = Alignment.Fill;

            var text = new TextBox();
            text.InlineAlignment = InlineAlignment.Far;
            text.VerticalScrollBar.Visible = true;
            text.MultiLine = true;
            text.WordWrap = true;
            text.Text = TextGenerator.Create(100000);
            text.AddTo(this, Alignment.Fill);
        }
    }
}
