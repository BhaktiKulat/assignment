using System;
using System.Collections.Generic;

namespace OnlineShoppingSystem
{
    class Program
    {
        static Customer customer = new Customer();

        static List<Product> products = new List<Product>();

        static List<CartItem> cart = new List<CartItem>();

        static void Main(string[] args)
        {
            RegisterCustomer();

            if (!Login())
                return;

            AddProducts();

            DisplayProducts();

            SearchProduct();

            AddToCart();

            CalculateBill();

            Payment();
        }

        static void RegisterCustomer()
        {
            Console.WriteLine("===== CUSTOMER REGISTRATION =====");

            Console.Write("Customer ID: ");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            customer.Name = Console.ReadLine();

            Console.Write("Email: ");
            customer.Email = Console.ReadLine();

            Console.Write("Password: ");
            customer.Password = Console.ReadLine();

            Console.WriteLine("\nRegistration Successful\n");
        }

        static bool Login()
        {
            int attempts = 0;

            while (attempts < 3)
            {
                Console.WriteLine("\n===== LOGIN =====");

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (email == customer.Email && password == customer.Password)
                {
                    Console.WriteLine($"\nWelcome {customer.Name}");
                    return true;
                }

                attempts++;

                Console.WriteLine("Invalid Credentials");
            }

            Console.WriteLine("Account Locked");

            return false;
        }

        static void AddProducts()
        {
            Console.Write("\nHow many products do you want to add? ");

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Product p = new Product();

                Console.Write("\nProduct ID: ");
                p.ProductId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                p.ProductName = Console.ReadLine();

                Console.Write("Price: ");
                p.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Stock: ");
                p.Stock = Convert.ToInt32(Console.ReadLine());

                products.Add(p);
            }
        }

        static void DisplayProducts()
        {
            Console.WriteLine("\n===== PRODUCTS =====");

            foreach (Product p in products)
            {
                Console.WriteLine($"{p.ProductId}  {p.ProductName}  ₹{p.Price}  Stock:{p.Stock}");
            }
        }

        static void SearchProduct()
        {
            Console.Write("\nEnter Product Name to Search: ");

            string name = Console.ReadLine();

            Product p = products.Find(x => x.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (p != null)
            {
                Console.WriteLine("\nProduct Found");

                Console.WriteLine($"Product ID : {p.ProductId}");
                Console.WriteLine($"Product Name : {p.ProductName}");
                Console.WriteLine($"Price : {p.Price}");
                Console.WriteLine($"Stock : {p.Stock}");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
        }

        static void AddToCart()
        {
            int choice;

            do
            {
                Console.Write("\nEnter Product ID: ");

                int id = Convert.ToInt32(Console.ReadLine());

                Product p = products.Find(x => x.ProductId == id);

                if (p == null)
                {
                    Console.WriteLine("Product Not Found");
                    continue;
                }

                Console.Write("Enter Quantity: ");

                int qty = Convert.ToInt32(Console.ReadLine());

                if (qty <= p.Stock)
                {
                    cart.Add(new CartItem
                    {
                        Product = p,
                        Quantity = qty
                    });

                    p.Stock -= qty;

                    Console.WriteLine("Added To Cart");
                }
                else
                {
                    Console.WriteLine("Insufficient Stock");
                }

                Console.WriteLine("\n1.Yes");
                Console.WriteLine("2.No");

                Console.Write("Add another product? ");

                choice = Convert.ToInt32(Console.ReadLine());

            } while (choice == 1);
        }

        static void CalculateBill()
        {
            double total = 0;

            Console.WriteLine("\n===== CART =====");

            foreach (CartItem item in cart)
            {
                Console.WriteLine($"{item.Product.ProductName} x {item.Quantity}");

                total += item.Total();
            }

            double discount = 0;

            if (total < 1000)
                discount = 0;

            else if (total <= 4999)
                discount = total * 0.10;

            else if (total <= 9999)
                discount = total * 0.20;

            else
                discount = total * 0.30;

            Console.WriteLine($"\nTotal Amount : ₹{total}");
            Console.WriteLine($"Discount : ₹{discount}");
            Console.WriteLine($"Final Amount : ₹{total - discount}");
        }

        static void Payment()
        {
            Console.WriteLine("\n===== PAYMENT =====");

            Console.WriteLine("1. UPI");
            Console.WriteLine("2. Credit Card");
            Console.WriteLine("3. Debit Card");
            Console.WriteLine("4. Cash On Delivery");

            Console.Write("Choose Payment Method: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Payment Successful using UPI");
                    break;

                case 2:
                    Console.WriteLine("Payment Successful using Credit Card");
                    break;

                case 3:
                    Console.WriteLine("Payment Successful using Debit Card");
                    break;

                case 4:
                    Console.WriteLine("Cash on Delivery Selected");
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
