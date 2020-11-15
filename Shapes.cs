using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public abstract class Shapes // абстрактные члены могут пристуствовать только в абстрактном классе, не имеют реализации
    {    
        public Shapes() // конструктор базового класса
        {
            Console.WriteLine("Shapes Created");
        }

        public abstract void Draw(); // описание сигнатуры

        public abstract double Area();

        public abstract double Perimeter();
    }

    public class Triangle : Shapes
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac) 
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;

            Console.WriteLine("Triangle Created.");
        }

        public double Bc { get; }

        public override double Area()
        {
            double s = (ab + bc + ac) / 2;
            return Math.Sqrt(s * (s - ab) * (s - bc) * (s - ac));

        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public override double Perimeter()
        {
            return ab + bc + ac;
        }
    }

    public class Rectangle : Shapes
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine("Rectangle Created.");
        }
        
        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }


}
