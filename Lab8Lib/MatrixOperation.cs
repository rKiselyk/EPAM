using System;
using System.Threading;

namespace Lab8Lib {
    public class MatrixOperation {
        public static int[,] GenerateMatrix(int row, int coll) {
            int[,] matrix = new int[row,coll];
            Random random = new Random();

            for (int i = 0; i < row; ++i)
                for (int j = 0; j < coll; ++j)
                    matrix[i,j] = random.Next(0, 1000);

            return matrix;
        }

        public static long sumInThread(int[,] matrix, int threadCount) {
            long sum = 0;
            Thread[] threads = new Thread[threadCount];

            int start = 0;
            for (int i = 0; i < threadCount; ++i) {
                if (start + (matrix.GetLength(0) / threads.Length) < matrix.GetLength(0)) {
                    threads[i] = new Thread(() => {
                        sum += MatrixOperation.sumByRow(matrix, start, start + matrix.GetLength(0) / threads.Length);
                    });
                    start += matrix.GetLength(0) / threads.Length;
                    threads[i].Start();
                }
                else {
                    threads[i] = new Thread(() => {
                        sum += MatrixOperation.sumByRow(matrix, start, matrix.GetLength(0));
                    });
                    threads[i].Start();
                }
            }
            for (int i = 0; i < threadCount; ++i)
                threads[i].Join();

            return sum;
        }

        public static long sumByRow(int[,] matrix, int start, int end) {
            long sum = 0;

            for (int i = start; i < end; ++i)
                for (int j = 0; j < matrix.GetLength(1);++j)
                    sum += matrix[i, j];

            return sum;
        }
    }
}
