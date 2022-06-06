using System;

using LX;

namespace Test1.LX
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
