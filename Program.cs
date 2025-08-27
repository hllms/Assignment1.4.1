using System.Runtime.InteropServices;

namespace Assignment1._4._1
{
    internal class Program
    {
        class Points
        {
            public double XCoord { get; set; }
            public double YCoord { get; set; }
        }
        static void RightOrLeft(Points p1, Points p2)
        {
            if (p1.XCoord > p2.XCoord)
            {
                Console.WriteLine("\n\nP1 is to the right of P2\n\n");
            }
            else if (p1.XCoord < p2.XCoord)
            {
                Console.WriteLine("\n\nP1 is to the left of P2\n\n");
            }
            else
            {
                Console.WriteLine("\n\nP1 is inline with P2\n\n");
            }
        }
            static void Main(string[] args)
            {
                Points p1 = new Points();
                p1.XCoord = 8;
                Points p2 = new Points();
                p2.XCoord = 9;
                RightOrLeft(p1, p2);
            }
        }
    }

