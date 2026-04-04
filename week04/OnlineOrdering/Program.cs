using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop",        "A001", 999.99, 1));
        order1.AddProduct(new Product("Mouse",         "B042",  25.50, 2));
        order1.AddProduct(new Product("USB-C Hub",     "C018",  45.00, 1));

        Address address2 = new Address("456 Reforma Ave", "Mexico City", "CDMX", "Mexico");
        Customer customer2 = new Customer("Ana García", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mechanical Keyboard", "D101", 120.00, 1));
        order2.AddProduct(new Product("Monitor 27\"",        "E055", 350.00, 1));

        List<Order> orders = new List<Order>() { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total: ${order.GetTotalCost():F2}");
            Console.WriteLine("══════════════════════════════════════");
        }
    }
}