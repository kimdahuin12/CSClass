using System;

namespace CSClass
{
    internal class Box
    {
        public int MyProperty { get;set; }
        public int myVar;

        private int width;
        public int Width
        {
            get { return width; }
            set {
                if (value > 0) width = value;
                else Console.WriteLine("양수를 입력해주세요.");
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value; 
                else Console.WriteLine("양수를 입력해주세요.");
            }
        }
        private int height;

        public Box(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Area
        {
            get { return this.Width * this.Height; }
        }
    }
}