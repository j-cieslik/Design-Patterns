
using Dekorator;

var pizzaBase = new MediumPizza();

var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);

Console.WriteLine($"mediumPizzaWithCheese: {mediumPizzaWithCheese.CalculatePrice()}");

var p2 = new SalamiPizzaDecorator(mediumPizzaWithCheese);
Console.WriteLine($"mediumPizzaWithCheese and salami: {p2.CalculatePrice()}");

var doubleSalamiCheesePizza = new SalamiPizzaDecorator(p2);
Console.WriteLine($"mediumPizzaWithCheese and double salami: {doubleSalamiCheesePizza.CalculatePrice()}");