using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Game.Player;
using System.Runtime.InteropServices;
using EZInput;
using Game.maze;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
        maze_ v = new maze_();
          
            int option = 0;
            Console.WriteLine("1.Play");
            Console.WriteLine(" ");
            Console.WriteLine("2.Instructions");
            option = int.Parse(Console.ReadLine());
            
             if (option == 1)
                play(v);
        }
        static void play(maze_ v)
        {
            Console.Clear();
         int x = 15;
         int y = 15;
            player_ p = new player_(x,y);
            maze_.mazef(v);
            player(ref x,ref y,v);

        }
        static void player(ref int x,ref int y,maze_ v)
        {
            int b = 0;
            int t = 0;
            bool running = false;
            int i = 2;
            bool run = false;
            int j = x;
            int count = 0;
            int n = 5;
            int score=0;
          player_.player_char(x, y, v, n);
            while (true)
            {
                Console.SetCursorPosition(110, 5);
                Console.Write("Score: {0}",score);
                if ((Keyboard.IsKeyPressed(Key.Space)|| run==true))
                {
                    
                    bullet(ref t,ref b, x, y,ref run,v,ref score);
                    
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                   player_.moveup(ref x, ref y, v);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                   player_.movedown(ref x, ref y, v);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    player_.moveleft(ref x, ref y, v);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                   player_.moveright(ref x, ref y, v);
                }
                count++;
                if (count == 3)
                {
                    enemy(ref count, ref i, ref j,ref running,v);
                }
                Thread.Sleep(100);
            }
                
            
        }
        static void bullet( ref int t,ref int b,int x,int y,ref bool run, maze_ v,ref int score)
        {
            
            if (run == false)
            {
                 b = x;
                 t = y;
                run = true;
            }
            if (v.maze__[t - 1, b] == " ")
            {
                
                Console.SetCursorPosition(b, t);
                Console.Write(".");
                v.maze__[t, b] = ".";
                Console.SetCursorPosition(b, t+1);
                Console.Write(" ");
                v.maze__[t+1,b] = " ";
                t--;
                Thread.Sleep(50);
                
            }
      
            else if(v.maze__[t - 1, b] != "#")
            {
                Console.SetCursorPosition(b, t+1);
                Console.Write(" ");
                run = false;
                score++;

            }
            else
            {
                Console.SetCursorPosition(b, t + 1);
                Console.Write(" ");
                run = false;
            }

        }
        
        static void enemy(ref int count,ref int x,ref int y,ref bool running,maze_ v)
        {
        
            if (x < 96 && running==false)
            {
                Console.SetCursorPosition(x, 3);
                Console.Write("||");
                v.maze__[3, x]="||";
                Console.SetCursorPosition(x, 4);
                Console.Write(".");
                v.maze__[4, x] = ".";
                Console.SetCursorPosition(x - 1, 3);
                Console.Write(" ");
                v.maze__[3, x - 1] = " ";
                Console.SetCursorPosition(x - 1, 4);
                Console.Write(" ");
                v.maze__[4,x-1] = " ";
                Thread.Sleep(100);
                x++;
                count = 0;
            }
                 else if (x <= 96)
                    {
                running = true;
                        
                            Console.SetCursorPosition(x, 3);
                            Console.Write("||");
                v.maze__[3, x]="||";
                            Console.SetCursorPosition(x, 4);
                            Console.Write(".");
                v.maze__[4, x] = ".";
                            Console.SetCursorPosition(x +2, 3);
                            Console.Write(" ");
                v.maze__[3, x + 2] = " ";
                            Console.SetCursorPosition(x + 1, 4);
                            Console.Write(" ");
                v.maze__[4, x + 1] = " ";
                            Thread.Sleep(100);
                            x--;
                if(x==2)
                {
                    running = false;
                }
                    count = 0;
                    }
                    
                
            
        }
        
    }

    }
