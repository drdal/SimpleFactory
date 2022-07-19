using System;
namespace SimpleFactory
{
    public abstract class Pizza
    {
        public String? PizzaName { get; set; }


        public void Prepare()
        {
            Console.WriteLine("Preparing a {0} pizza..", PizzaName);
        }

        public void Bake()
        {
            Console.WriteLine("{0} pizza is now baking in the owen..", PizzaName);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting {0} pizza..", PizzaName);
        }

        public void Box()
        {
            Console.WriteLine("Boxing {0} pizza..", PizzaName);
        }
    }
}

