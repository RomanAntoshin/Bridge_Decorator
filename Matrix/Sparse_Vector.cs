using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Sparse_Vector:IVector
    {
        private int size;
        private List<(int, double)> data;
        public Sparse_Vector(int size)
        {
            this.size = size;
            data = new List<(int, double)>();
        }
        public Sparse_Vector()
        {
            data = new List<(int, double)>();
        }
        public int Size
        {
            get
            {
                return size;
            }
        }
        public double GetData(int i)
        {
            for (int j = 0; j < data.Count; j++)
               if (data[j].Item1 == i)
                    return data[j].Item2;
            return 0;
        }
        public void SetData(int i, double val)
        {
                for (int j = 0; j < data.Count - 1; j++)
                    if (data[j].Item1 > i && data[j + 1].Item1 < i)
                    {
                        data.Insert(j + 1, (i, val));
                        return;
                    }
                data.Add((i, val));
        }
        public Sparse_Vector(double[] d)
        {
            data = new List<(int, double)>();
            double buf;
            this.size = d.Length;
            for (int i = 0; i < size; i++)
                if (d[i] != 0)
                {
                    buf = d[i];
                    data.Add((i, buf));
                }
        }
        public void Print()
        {
            for (int i = 0; i < size; i++)
                Console.Write(GetData(i) + " ");
            Console.Write("\n");
        }
    }
}
