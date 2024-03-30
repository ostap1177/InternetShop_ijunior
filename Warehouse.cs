using System;
using System.Collections.Generic;

namespace Saw_UseCase
{
    public class Warehouse : Storage
    {
        public override string Paylink { get; protected set; }

        public void Unload(Good good, int count)
        {
            if (Goods.TryGetValue(good, out int value))
            {
                if (value >= count)
                {
                    Goods[good] -= count;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}