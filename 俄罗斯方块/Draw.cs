﻿using System;

namespace 俄罗斯方块
{
    public class Draw
    {
        public static Draw instance;
        public Draw()
        {
            instance = this;
        }
        Random r = new Random((int) DateTime.Now.Ticks);
        
        //输出第一行或者最后一行
        void Print1()
        {
            for (int i = 0; i < 12; i++)
            {
                Console.Write('■');
            }
            Console.WriteLine("");
        }

        //输出Rect中间行
        void Print2(int[,] table)
        {
            for (int i = 2; i < 20; i++)
            {
                Console.Write('■');

                for (int j = 0; j < 10; j++)
                {
                    if (table[i, j] == 0)
                    {
                        Console.Write("  ");
                    }
                    else if(table[i, j] == 9)
                    {
                        Console.Write("□");
                    }
                    else
                    {
                        Console.Write("■");
                        //Console.Write(table[i, j] + " ");
                    }
                }
                Console.WriteLine('■');
            }
        }

        //预览下一个方块
        public void PrintTitle(Cube titleCube)
        {
            Console.WriteLine();
            DrawTitle(titleCube.cube);
            Console.WriteLine("");
        }

        //画矩形
        public void PrintRect()
        {
            Print1();
            Print2(Game.instance.table);
            Print1();
        }

        //画标题
        void DrawTitle(int[,] title)
        {
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < 5; j++)
                {
                    if (title[i,j] == 0)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("■");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}