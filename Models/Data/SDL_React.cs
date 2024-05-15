﻿using System.Runtime.InteropServices;

namespace Silk.NET.SDL
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SDL_Rect
    {
        public int x;
        public int y;
        public int w;
        public int h;
    }
}