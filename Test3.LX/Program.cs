using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LX;

namespace Test3.LX
{
    class Program
    {
        static void Main(string[] args)
        {
            App.OnRun += () => new MainForm();
            App.Run();
        }
    }
}
