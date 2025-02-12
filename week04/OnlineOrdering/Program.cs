using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Customer Dane = new Customer("Dane", new Address("123 Main St", "Springfield", "IL", "USA"));
        Customer Daliah = new Customer("Daliah", new Address("456 Elm St", "Chandler", "AZ", "USA"));
        Product Charger = new Product("Charger", 12345, 19.79, 1);
        Product Earbuds = new Product("Earbuds", 54321, 39.99, 1);
        Product Tomato = new Product("Tomato", 98765, 0.99, 6);
        Product Lettuce = new Product("Lettuce", 56789, 1.99, 2);
        Product Meat = new Product("Meat", 24680, 4.99, 1);
        Order order1 = new Order(Dane, Charger, Earbuds);
        Order order2 = new Order(Daliah, Tomato, Lettuce, Meat);

        Console.WriteLine(order1._packingLabel());
        Console.WriteLine(order1._shippingLabel());
        Console.WriteLine(order1._total());
        Console.WriteLine();
        Console.WriteLine(order2._packingLabel());
        Console.WriteLine(order2._shippingLabel());
        Console.WriteLine(order2._total());
    }   
}