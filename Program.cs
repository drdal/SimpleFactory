﻿// See https://aka.ms/new-console-template for more information

SimpleFactory.SimplePizzaFactory factory = new SimpleFactory.SimplePizzaFactory();
SimpleFactory.PizzaStore store = new SimpleFactory.PizzaStore(factory);

SimpleFactory.Pizza _ = store.OrderPizza("pepperoni");


