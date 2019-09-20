using System;
using Animals;
using Shapes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shapes.Shape;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // MathOperations mo = new MathOperations();
            //Console.WriteLine(mo.Add(2, 3));
            // Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            //Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
            //Animal cat = new Cat("Pesho", "Whiskas");
            //Animal dog = new Dog("Gosho", "Meat");

            //Console.WriteLine(cat.ExplainSelf());
            //Console.WriteLine(dog.ExplainSelf());
            Shape circle = new Circle(5);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());

            Shape rectangle = new Rectangle(5,5);
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.ReadLine();
        }
    }
    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;

        }
    }
}
namespace Animals
{
    public class Animal
    {
        private string name;
        private string favoriteFood;
        
        public Animal(string name,string favoriteFood)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
        }
        public virtual string ExplainSelf()
        {
            return $"I am{this.name}and my favoriteFood is {this.favoriteFood}";
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood)
            : base(name, favoriteFood)
        {

        }
        public override string ExplainSelf()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ExplainSelf())
                .Append("MEEOW");

            return builder.ToString();
        }
    }
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
    : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ExplainSelf())
                .Append("DJAAF");

            return builder.ToString();
        }
    }
}
namespace Shapes
{
    public abstract class Shape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "Drawing ";
        }
        public class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double Radius
            {
                get { return radius; }
                private set { radius = value; }
            }

            public override double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }

            public override double CalculatePerimeter()
            {
                return 2 * Math.PI * Radius;
            }

            public override string Draw()
            {
                return base.Draw() + this.GetType().Name;
            }
        }
        public class Rectangle : Shape
        {
            private double width;
            private double height;

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public double Width
            {
                get { return width; }
                private set { width = value; }
            }

            public double Height
            {
                get { return height; }
                private set { height = value; }
            }

            public override double CalculateArea()
            {
                return Width * Height;
            }

            public override double CalculatePerimeter()
            {
                return 2 * Width + 2 * Height;
            }

            public override string Draw()
            {
                return base.Draw() + this.GetType().Name;
            }
        }
    }
}