using System;
using Game.maze;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Player
{
    class player_
    {
        int x = 0;
        int y = 0;
        public player_(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static void player_char(int x, int y, maze_ v, int n)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" .");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("||");
            if (n == 0 || n == 1 || n == 2 || n == 3 || n == 4)
            {
                v.maze__[y, x] = ".";
                v.maze__[y + 1, x] = "||";
            }
            Console.ReadKey();
        }
        public static void moveup(ref int x, ref int y, maze_ v)
        {
            if (v.maze__[y - 1, x] != "#")
            {
                int n = 1;
                Console.SetCursorPosition(x, y + 1);
                Console.Write("  ");
                v.maze__[y + 1, x] = " ";
                y--;
                player_char(x, y, v, n);
                // Thread.Sleep(100);
            }
        }
       public static void movedown(ref int x, ref int y, maze_ v)
        {
            /* Console.SetCursorPosition(y + 1, x);
             Console.Write(y);*/
            if (v.maze__[y + 3, x] != "#")
            {
                int n = 2;
                Console.SetCursorPosition(x + 1, y);
                Console.Write(" ");
                v.maze__[y, x + 1] = " ";
                y += 1;
                player_char(x, y, v, n);
                //   Thread.Sleep(100);
            }
        }
       public static void moveright(ref int x, ref int y, maze_ v)
        {
            if (v.maze__[y, x + 2] != "#")
            {
                int n = 3;
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Console.SetCursorPosition(x, y + 1);
                Console.Write(" ");
                v.maze__[y, x] = " ";
                v.maze__[y + 1, x] = " ";
                x += 1;
                player_char(x, y, v, n);
                //   Thread.Sleep(100);
            }
        }
       public static void moveleft(ref int x, ref int y, maze_ v)
        {
            /* Console.SetCursorPosition(y, x - 1);
             Console.Write(x);*/
            if (v.maze__[y, x - 1] != "#")
            {
                int n = 4;
                Console.SetCursorPosition(x, y);
                Console.Write("  ");
                Console.SetCursorPosition(x + 1, y + 1);
                Console.Write(" ");
                v.maze__[y, x] = "  ";
                v.maze__[y + 1, x + 1] = " ";
                x -= 1;
                player_char(x, y, v, n);
                //  Thread.Sleep(100);
            }
        }
    }
}
