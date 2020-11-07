using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnekCS_openGL
{
    class Input
    {
 

        //this is dumb and should be a switch statement ngl
        public string GetInput(KeyboardState input)
        {
            if (input.IsAnyKeyDown)
            {
                if (input.IsKeyDown(Key.Up))
                {
                    Console.WriteLine("up");
                    return "up";
                }
                if (input.IsKeyDown(Key.Down))
                {
                    Console.WriteLine("down");

                    return "down";
                }
                if (input.IsKeyDown(Key.Left))
                {
                    Console.WriteLine("left");

                    return "Left";
                }
                if (input.IsKeyDown(Key.Right))
                {
                    Console.WriteLine("right");

                    return "right";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

    }
}
