using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create customers
        Customer customer1 = new Customer("Alice Smith", new Address("123 Maple St", "Springfield", "IL", "USA"));
        Customer customer2 = new Customer("Bob Johnson", new Address("456 Oak Rd", "Toronto", "ON", "Canada"));
        Customer customer3 = new Customer("Carlos Reyes", new Address("789 Pine Ave", "Austin", "TX", "USA"));
        Customer customer4 = new Customer("Diana Chen", new Address("321 Birch Blvd", "Vancouver", "BC", "Canada"));

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "K789", 45.00, 1));
        order1.AddProduct(new Product("USB Cable", "U012", 10.00, 3));
        order1.AddProduct(new Product("Monitor", "MO34", 150.00, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "S234", 799.99, 1));
        order2.AddProduct(new Product("Phone Case", "PC567", 19.99, 1));
        order2.AddProduct(new Product("Charger", "C890", 29.99, 1));
        order2.AddProduct(new Product("Earbuds", "E345", 49.99, 2));
        order2.AddProduct(new Product("Screen Protector", "SP678", 9.99, 1));

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Desk Chair", "DC901", 200.00, 1));
        order3.AddProduct(new Product("Desk Lamp", "DL234", 55.00, 1));
        order3.AddProduct(new Product("Notebook", "N567", 5.00, 5));
        order3.AddProduct(new Product("Pen Set", "P890", 12.50, 2));
        order3.AddProduct(new Product("Calendar", "CA123", 15.00, 1));

        Order order4 = new Order(customer4);
        order4.AddProduct(new Product("Coffee Maker", "CM456", 120.00, 1));
        order4.AddProduct(new Product("Mug", "MG789", 8.00, 4));
        order4.AddProduct(new Product("Coffee Beans", "CB012", 20.00, 2));
        order4.AddProduct(new Product("Filter", "F345", 7.50, 3));
        order4.AddProduct(new Product("Thermometer", "T678", 25.00, 1));

        List<Order> orders = new List<Order>() { order1, order2, order3, order4 };

        // Display each order details
        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Items with prices:");
            foreach (Product product in order.GetProducts())
            {
                Console.WriteLine($"{product.GetName()} (ID: {product.GetProductId()}) - Quantity: {product.GetQuantity()} - Unit Price: ${product.GetPrice():0.00} - Total: ${product.GetTotalPrice():0.00}");
            }
            Console.WriteLine($"Shipping Fee: ${order.GetShippingCost():0.00}");
            Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():0.00}");
            Console.WriteLine("---------------------------------------------------\n");
        }
    }
}
