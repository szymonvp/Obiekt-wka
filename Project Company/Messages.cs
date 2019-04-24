using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class Messages
    {
        public static void PrintInColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        internal static void SetCursorPosition(int v, int cursorTop)
        {
            throw new NotImplementedException();
        }
    }
}
