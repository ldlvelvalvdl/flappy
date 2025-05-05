
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    class TheWall
    {
        public int x;
        public int y;

        public int sizeX;
        public int sizeY;

        public Image wallImg;

        public TheWall(int x, int y, bool isRotatedImage = false)
        {
            wallImg = new Bitmap("C:\\Users\\New\\Pictures\\tube.png");
            this.x = x;
            this.y = y;
            sizeX = 50;
            sizeY = 250;
            if (isRotatedImage)
                wallImg.RotateFlip(RotateFlipType.Rotate180FlipX);
        }
    }
}