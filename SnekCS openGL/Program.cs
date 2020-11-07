using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using System;
using System.Runtime.CompilerServices;

namespace SnekCS_openGL
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int height = 1280;
            int width = 720;
            string title = "snek";
            string pressedKey;
            
            Visuals window = new Visuals(height, width, title);
            window.Run(60.0);



            //Main game loop
            while (isRunning)
            {
            }
        }
    }
}
