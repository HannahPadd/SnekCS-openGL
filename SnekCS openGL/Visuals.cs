using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES20;
using OpenTK.Input;

namespace SnekCS_openGL
{
    class Visuals : GameWindow
    {
        //test
        string pressedKey = "";
        Input inputListener = new Input();
        public Visuals(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            pressedKey = inputListener.GetInput(Keyboard.GetState());
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.4f, 0.3f, 0.3f, 1.0f);

            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            //Code goes here.

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }


    }
}
