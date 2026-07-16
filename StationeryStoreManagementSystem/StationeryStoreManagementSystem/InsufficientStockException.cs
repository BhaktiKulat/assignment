using System;

namespace StationeryStoreManagementSystem
{
    class InsufficientStockException : Exception
    {
        public InsufficientStockException()
            : base("Insufficient Stock.")
        {
        }
    }
}