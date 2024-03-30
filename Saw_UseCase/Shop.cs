using System;

namespace Saw_UseCase
{
    public class Shop
    {
        private Warehouse _warehouse;

        public Cart Cart()
        {
            return new Cart(_warehouse);
        }

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }
    }
}