using System;

namespace Lab6Lib {
    public class Rectangle {

        public Rectangle(int x, int y, int heigh, int width) {
            X = x;
            Y = y;
            Height = heigh;
            Width = width;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }

        public void MoveTo(int newX, int newY) {
            X = newX;
            Y = newY;
        }
        public void ChangeSize(int newHeigh, int newWidth) {
            Height = newHeigh;
            Width = newWidth;
        }
        public static void intersectionRectangle(Rectangle first, Rectangle second) {

        }
        public static Rectangle containTwoRectangle(Rectangle first, Rectangle second) {
            int y = first.Y > second.Y ? first.Y : second.Y;
            int x = first.X < second.X ? first.X : second.X;
            int height = first.Y > second.Y ? first.Height + second.Height - 2*(first.Y-second.Y) : first.Height + second.Height - 2 * (first.Y - second.Y);
            int width = first.X < second.X ? first.Width + second.Width + (second.X - first.X - first.Width) : first.Width + second.Width + (first.X - second.X - second.Width);

            return new Rectangle(x, y, height, width);
        }
    }
}
