using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Initiator
    {
        public static void Fill_Matrix(IMatrix matrix, int n_z, int max)
        {
            if (n_z >= 0 && n_z <= matrix.Row * matrix.Column)
            {
                double a;
                Random random = new Random();
                double[] data = new double[matrix.Row * matrix.Column];
                for (int i = 0; i < n_z; i++)
                {
                    a = Math.Round(random.NextDouble() * random.Next(0, max), 2);
                    if (a == 0)
                        a = 0.01;
                    data[i] = a;
                }
                for (int i = n_z; i < data.Length; i++)
                    data[i] = 0;
                double[] buf = new double[matrix.Column];
                for(int i=0; i<matrix.Row; i++)
                {
                    Array.Copy(data, i * matrix.Column, buf, 0, matrix.Column);
                    for (int j = 0; j < matrix.Column; j++)
                        matrix.SetElement(i, j, buf[j]);
                }
                Array.Clear(data, 0, data.Length);
            }
            else
            {
                throw new Exception("Число отличных от нуля элементов отрицательно, либо превышает общее число элементов матрицы");
            }
        }
    }
}
