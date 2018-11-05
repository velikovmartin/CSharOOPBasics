﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Contracts
{
    interface IBuyer
    {
        string Name { get; }

        int Food { get; }

        void BuyFood();
    }
}
