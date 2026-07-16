using System;

namespace StationeryStoreManagementSystem
{
    class DuplicateItemException : Exception
    {
        public DuplicateItemException()
            : base("Item ID already exists.")
        {
        }
    }
}
