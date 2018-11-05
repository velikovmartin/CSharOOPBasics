using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GreedyTimes
{
    class Bag
    {
        public List<Treasure> Treasures { get; set; }

        internal void Add(Treasure treasure)
        {
            this.Treasures.Add(treasure);
        }
    }
}
