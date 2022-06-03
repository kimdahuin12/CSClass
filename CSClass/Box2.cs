﻿using System;

namespace CSClass
{
    internal class Box2
    {
        private int width;
        private int height;

        public Box2(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void setWidth(int width)
        {
            if (width > 0)
                this.width = width;
            else
                Console.WriteLine("양수를 입력해주세요.");

        }
        public void setHeight(int height)
        {
            if (height > 0)
                this.width = height;
            else
                Console.WriteLine("양수를 입력해주세요.");

        }

        public int getWidth() { return width; }
        public int getHeight() { return height; }

        public int Area()
        {
            return this.width * this.height;
        }
    }
}