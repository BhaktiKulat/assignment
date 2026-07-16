using System;

namespace StationeryStoreManagementSystem
{
    class InvalidPriceException : Exception
    {
        public InvalidPriceException()
            : base("Price must be greater than zero.")
        {
        }
    }
}
