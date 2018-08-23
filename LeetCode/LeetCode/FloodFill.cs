using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class FloodFill
    {
        public int[,] FloodFillMethod(int[,] image, int sr, int sc, int newColor)
        {
            if (image[sr,sc] == newColor) return image;
            InnerMethod(image, sr, sc, image[sr,sc], newColor);
            return image;
        }

        private void InnerMethod(int[,] image, int sr, int sc,int color, int newColor)
        {
            if (sr < 0 || sr >= image.GetLength(0) || sc < 0 || sc >= image.GetLength(1) || image[sr,sc] != color) return;
            image[sr,sc] = newColor;
            InnerMethod(image, sr + 1, sc, color, newColor);
            InnerMethod(image, sr - 1, sc, color, newColor);
            InnerMethod(image, sr, sc + 1, color, newColor);
            InnerMethod(image, sr, sc - 1, color, newColor);

        }
    }
}
