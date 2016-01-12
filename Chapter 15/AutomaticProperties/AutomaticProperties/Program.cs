using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticProperties
{
    class Program
    {
        static void DoWork()
        {
            Polygon square = new Polygon();
            Polygon triangle = new Polygon { NumSides = 3 };
            Polygon pentagon = new Polygon { SideLenght = 15.5, NumSides = 5 };

            Console.WriteLine("Square: num of sides is {0}, lenght of each side {1}", 
                square.NumSides, square.SideLenght);
            Console.WriteLine("Triangle: num of sides is {0}, lenght of each side {1}",
                triangle.NumSides, triangle.SideLenght);
            Console.WriteLine("Pentagon: num of sides is {0}, lenght of each side {1}", 
                pentagon.NumSides, pentagon.SideLenght);

        }

        static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
