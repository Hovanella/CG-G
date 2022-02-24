using System;

namespace Laba1Remastered
{
    public static class MatrixControler
    {
        public static void InitializeMatrix(CMatrix matrix)
        {
            var randomizer = new Random();
            for (var i = 0; i < matrix.NumberOfRows; i++)
            {
                for (var i1 = 0; i1 < matrix.NumberOfColumns; i1++)
                {
                    matrix.Content[i, i1] = randomizer.Next(1, 10);
                }
            }
        }
        
        
    }
}