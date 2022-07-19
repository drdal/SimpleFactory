using System;
namespace SimpleFactory
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPizza(String type)
        {
            Pizza pizza;


            pizza = factory.CreatePizza(type);


            pizza.Prepare();

            pizza.Bake();

            pizza.Cut();

            pizza.Box();

            Console.WriteLine("{0} pizza is ready", pizza.PizzaName);
            return pizza;
        }
    }
}

