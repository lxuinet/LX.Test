using System;

using LX;

namespace Test2.LX
{
    class Program
    {

        public static DateTime StartDate;

        static void Main(string[] args)
        {
            StartDate = DateTime.UtcNow;
            App.OnRun += () => new MainForm();
            App.Run();
        }
    }
}
