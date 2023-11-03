namespace AlgorithmsAndDataStructures.Matrix
{
    // Not working
    internal class Strassen
    {
        public static int[,] Multiply(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] C = new int[n, n];

            if (n == 1)
            {
                C[0, 0] = A[0, 0] + B[0, 0];
            }
            else
            {
                int[,] A11 = new int[n / 2, n / 2];
                int[,] A12 = new int[n / 2, n / 2];
                int[,] A21 = new int[n / 2, n / 2];
                int[,] A22 = new int[n / 2, n / 2];
                int[,] B11 = new int[n / 2, n / 2];
                int[,] B12 = new int[n / 2, n / 2];
                int[,] B21 = new int[n / 2, n / 2];
                int[,] B22 = new int[n / 2, n / 2];

                Split(A, A11, 0, 0);
                Split(A, A12, 0, n / 2);
                Split(A, A21, n / 2, 0);
                Split(A, A22, n / 2, n / 2);

                Split(B, B11, 0, 0);
                Split(B, B12, 0, n / 2);
                Split(B, B21, n / 2, 0);
                Split(B, B22, n / 2, n / 2);

                int[,] M1 = Multiply(Add(A11, A22), Add(B11, B22));
                int[,] M2 = Multiply(Add(A21, A22), B11);
                int[,] M3 = Multiply(A11, Sub(B12, B22));
                int[,] M4 = Multiply(A22, Sub(B21, B11));
                int[,] M5 = Multiply(Add(A11, A12), B22);
                int[,] M6 = Multiply(Sub(A21, A11), Add(B11, B12));
                int[,] M7 = Multiply(Sub(A12, A22), Add(B21, B22));

                int[,] C11 = Add(Sub(Add(M1, M4), M5), M7);
                int[,] C12 = Add(M3, M5);
                int[,] C21 = Add(M2, M4);
                int[,] C22 = Add(Sub(Add(M1, M3), M2), M6);


                Join(C11, C, 0, 0);
                Join(C12, C, 0, n / 2);
                Join(C21, C, n / 2, 0);
                Join(C22, C, n / 2, n / 2);
            }

            return C;
        }

        private static void Split(int[,] source, int[,] destination, int startRow, int startColumn)
        {
            int numRows = destination.GetLength(0);
            int numColumns = destination.GetLength(1);


            for (int destRow = 0, sourceRow = startRow; destRow < numRows; destRow++, sourceRow++)
            {
                for (int destCol = 0, sourceCol = startColumn; destCol < numColumns; destCol++, sourceCol++)
                {
                    destination[destRow, destCol] = source[sourceRow, sourceCol];
                }
            }
        }

        private static int[,] Add(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] C = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    C[i, j] = A[i, j] + B[i, j];
            return C;
        }
        private static int[,] Sub(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] C = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }

            return C;
        }

        private static void Join(int[,] C, int[,] P, int iB, int jB)
        {
            for (int i1 = 0, i2 = iB; i1 < C.GetLength(0); i1++, i2++)
                for (int j1 = 0, j2 = jB; j1 < C.GetLength(0); j1++, j2++)
                    P[i2, j2] = C[i1, j1];
        }
    }
}
