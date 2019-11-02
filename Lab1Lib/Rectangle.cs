using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Lib {
    interface ISize {
        int Height { get; set; }
        int Weight { get; set; }
        int Perimeter();
    }
    interface ICordinates {
        int X { get; set; }
        int Y { get; set; }
    }
    public struct Rectangle : ISize, ICordinates {
        public int Height { get; set; }
        public int Weight { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Rectangle(int x, int y, int height, int weight) {
            X = x;
            Y = y;
            Height = height;
            Weight = weight;
        }

        public int Perimeter() {
            return 2 * (Height + Weight);
        }
    }
}
