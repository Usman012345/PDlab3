using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.maze
{
    class maze_
    {
        public string[,] maze__ = new string[30,100];
        public maze_()
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (i == 0 || i == 30 - 1 || j == 0 || j == 99)
                        maze__[i, j] = "#";
                    else
                        maze__[i, j] = " ";

                }
            }
        }
        public static void mazef(maze_ v)
        {
            for (int i = 0; i <v.maze__.GetLength(0); i++)
            {
                for (int j = 0; j < v.maze__.GetLength(1); j++)
                {
                    Console.Write(v.maze__[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
    }

