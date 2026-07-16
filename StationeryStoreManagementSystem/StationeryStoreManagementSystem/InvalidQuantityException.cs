using System;

namespace StationeryStoreManagementSystem
{
    class InvalidQuantityException : Exception
    {
        public InvalidQuantityException()
            : base("Quantity cannot be negative.")
        {
        }
    }
}