﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char wallSymbol = '\u25A0';

        public Wall(int leftX, int topY) 
            : base(leftX, topY)
        {
            this.InitializeWallBorders();
        }

        private void InitializeWallBorders()
        {
            this.SetHorisontalLine(0);
            this.SetHorisontalLine(this.TopY - 1);
            this.SetVerticalLine(0);
            this.SetVerticalLine(this.LeftX);
        }

        private void SetHorisontalLine(int topY)
        {
            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                this.Draw(leftX, topY, wallSymbol);
            }
        }

        private void SetVerticalLine(int leftX)
        {
            for (int topY = 0; topY < this.TopY; topY++)
            {
                this.Draw(leftX, topY, wallSymbol);
            }
        }
    }
}
