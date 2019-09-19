using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
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
