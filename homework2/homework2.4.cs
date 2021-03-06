static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };

            if (isToeplitzMatrix(matrix)) 
            {
                Console.WriteLine("是托普利茨矩阵");
            }
            else
            {
                Console.WriteLine("不是托普利茨矩阵");
            }
        }
        public static bool isToeplitzMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.Length; ++row)
            {
                for (int col = 0; col < matrix.GetLength(0); ++col)
                {
                    if (row > 0 && col > 0 && matrix[row,col] != matrix[row - 1,col - 1])
                        return false;
                }
            }
            return true;
        }
