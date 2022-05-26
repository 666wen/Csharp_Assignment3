using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignment3
{
    public class Color
    {
        private int red;
        public int Red  
        { 
            get { return red; } 
            set 
            {
                if (value >= 0 && value <= 255)
                { red = value; }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private int green;
        public int Green
        { 
            get { return green; }
            set
            {
                if (value >= 0 && value <= 255)
                { green = value; }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private int blue;
        public int Blue 
        { 
            get { return blue; }
            set
            {
                if (value >= 0 && value <= 255)
                { blue = value; }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public int Gray()
        {
            return (Red + Green + Blue) / 3;
        }
    }

    public class Ball
    {
        public int ThrowCount { get; set; }

        public int Size { get; set; } 

        public Color BallColor { get; set; }

        public Ball(int size, Color ballColor)
        {
            ThrowCount = 0;
            Size = size;
            BallColor = ballColor;
        }

        public void POP()
        {
            Size = 0;
            ThrowCount=0;
        }
        public int Throw()
        {
            if (Size != 0)
            {
                ThrowCount++;
            }
            return ThrowCount;
        }

    }
}
