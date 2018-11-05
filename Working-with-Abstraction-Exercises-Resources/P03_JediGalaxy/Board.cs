using System;
using System.Collections.Generic;
using System.Text;

namespace P03_JediGalaxy
{
    public class Board
    {
        private int[,] matrix;

        public Board(int dimOne, int dimTwo)
        {
            this.Matrix = new int[dimOne, dimTwo];
            this.FillMatrix();
        }

        public int[,] Matrix { get => matrix; set => matrix = value; }

        private void FillMatrix()
        {
            int value = 0;
            for (int i = 0; i < this.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.Matrix.GetLength(1); j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }

        public bool IsInside(int dimOne, int dimTwo)
        {
            return dimOne >= 0 && dimOne < matrix.GetLength(0) && dimTwo >= 0 && dimTwo < matrix.GetLength(1);
        }
    }
}
