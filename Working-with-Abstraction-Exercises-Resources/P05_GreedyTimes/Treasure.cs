using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GreedyTimes
{
    public class Treasure
    {
        public Treasure(string name, long amount)
        {
            this.Name = name;
            this.Amount = amount;
            this.Type = GetTreasureType(name);
        }
        public string Name { get; set; }
        public long Amount { get; set; }
        public string Type { get; set; }

        public string GetTreasureType(string itemName)
        {
            var treasureType = string.Empty;
            if (itemName.Length == 3)
            {
                treasureType = "Cash";
            }
            else if (itemName.ToLower().EndsWith("gem"))
            {
                treasureType = "Gem";
            }
            else if (itemName.ToLower() == "gold")
            {
                treasureType = "Gold";
            }

            return treasureType;
        }
    }
}
