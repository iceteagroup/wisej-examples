using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Snake
{
    public class Element
    {
        public Element()
        {
        }

        public Element(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public bool IsSamePosition(Element element) => X == element.X && Y == element.Y; 
    }
}