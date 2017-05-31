using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tasks
{
    static class RectangleIntoSquares
    {
        public static List<int> sqInRect(int lng, int wdth)
        {
            if (lng == wdth) return null;
            var squares = new List<int>();
            while (lng > 0 && wdth > 0)
            {
                if (lng < wdth)
                {
                    squares.Add(lng);
                    wdth -= lng;
                }
                else
                {
                    squares.Add(wdth);
                    lng -= wdth;
                }
            }
            return squares;
        }
    }
}
