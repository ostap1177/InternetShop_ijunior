using System;
using System.Collections.Generic;

namespace Saw_UseCase
{
    public class Cart : Storage
    {
        private Warehouse _warehouse;

        public override string Paylink { get; protected set; }

        public override void Add(Good good, int count)
        {
            _warehouse.Unload(good, count);

            Goods.Add(good, count);
        }

        public Order GetOrder()
        {
            Order order = new Order();
            Transfer(order);
            return order;
        }

        private void Transfer(Order order)
        {
            foreach (var good in Goods)
            {
                order.Add(good.Key, good.Value);
            }
        }

        public Cart(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }
    }
}