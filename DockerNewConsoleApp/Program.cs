﻿using System;

namespace DockerNewConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=1000)
            {
                Console.WriteLine(i + " "+ "Hello World");
                i++;
                System.Threading.Thread.Sleep(1000);//1 saniyelik aralıklarla çalıştır
            }
        }
    }
}
