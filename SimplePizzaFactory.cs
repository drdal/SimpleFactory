using System;
namespace SimpleFactory
{
    public class SimplePizzaFactory
    {
        public SimplePizzaFactory()
        {
        }

        public Pizza CreatePizza(String type)
        {
            Pizza pizza = null;

            // Concrete Object creation
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}

