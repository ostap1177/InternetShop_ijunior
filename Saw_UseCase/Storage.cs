using System;
using System.Collections.Generic;

namespace Saw_UseCase
{
    public abstract class Storage
    {
        protected Dictionary<Good, int> Goods = new Dictionary<Good, int>();

        public abstract string Paylink { get; protected set; }

        public void Print()
        {
            foreach (KeyValuePair<Good, int> keyValue in Goods)
            {
                Console.WriteLine($"{keyValue.Key.Name}, {keyValue.Value}");
            }
        }

        public virtual void Add(Good good, int count)
        {
            if (Goods.ContainsKey(good))
            {
                Goods[good] += count;
            }
            else
            {
                Goods.Add(good, count);
            }
        }
    }
}