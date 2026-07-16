using System;

namespace StationeryStoreManagementSystem
{
    class StationeryItem : Product
    {
        private int quantity;

        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string Category { get; set; }

        public string Brand { get; set; }

        public double Price { get; set; }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidQuantityException();
                }

                quantity = value;
            }
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Item ID : {ItemId}");
            Console.WriteLine($"Item Name : {ItemName}");
            Console.WriteLine($"Category : {Category}");
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Quantity : {Quantity}");
        }

        public override double CalculateDiscount(double amount)
        {
            return 0;
        }

        public void UpdateQuantity(int qty)
        {
            Quantity = qty;
        }
    }
}