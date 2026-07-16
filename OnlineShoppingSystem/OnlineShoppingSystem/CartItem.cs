namespace OnlineShoppingSystem
{
    class CartItem
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public double Total()
        {
            return Product.Price * Quantity;
        }
    }
}