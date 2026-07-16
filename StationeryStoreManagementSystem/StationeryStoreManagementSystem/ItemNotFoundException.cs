using System;

namespace StationeryStoreManagementSystem
{
    class ItemNotFoundException : Exception
    {
        public ItemNotFoundException()
            : base("Item not found.")
        {
        }
    }
}
