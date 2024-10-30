using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> figuras = new List<Shape>();

        Square figura1 = new Square("Purple", 2);
        figuras.Add(figura1);

        Rectangle figura2 = new Rectangle("Pink", 1, 1);
        figuras.Add(figura2);

        Circle figura3 = new Circle("Yellow", 100);
        figuras.Add(figura3);

        Square figura4 = new Square("Black", 15);
        figuras.Add(figura4);

        Rectangle figura5 = new Rectangle("Red", 4, 5);
        figuras.Add(figura5);

        Circle figura6 = new Circle("Green", 6);
        figuras.Add(figura6);

        foreach (Shape figura in figuras)
        {
            string color = figura.GetColor();

            double area = figura.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}