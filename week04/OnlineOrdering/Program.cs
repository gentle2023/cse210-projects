using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address(
            "123 Main Street",
            "Rexburg",
            "ID",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "P1001", 3.50, 4));
        order1.AddProduct(new Product("Pen", "P1002", 1.25, 10));

        Address address2 = new Address(
            "45 King Road",
            "London",
            "Greater London",
            "UK"
        );

        Customer customer2 = new Customer("Emily Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "P2001", 25.00, 1));
        order2.AddProduct(new Product("Water Bottle", "P2002", 12.00, 2));
        order2.AddProduct(new Product("Sticker Pack", "P2003", 5.00, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}