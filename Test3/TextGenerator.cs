using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    public static class TextGenerator
    {
        public static string Create(int count)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append("_" + i.ToString() + "_0123456789\n");
            }
            return stringBuilder.ToString();
        }
    }
}
