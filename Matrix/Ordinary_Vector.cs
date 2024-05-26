using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Ordinary_Vector: IVector
    {
        private int size;
        private double[] data;
        public Ordinary_Vector(int size)
        {
            this.size = size;
            data = new double[size];
        }
        public Ordinary_Vector()
        {

        }
        public double GetData(int i)
        {
            if (i < size && i>=0)
            {
                return data[i];
            }
            throw new Exception("Некорректный индекс");

        }
        public void SetData(int i, double val)
        {
            if (i < size && i>=0)
                data[i] = val;
            else
                throw new Exception("Некорректный индекс");
        }
        public Ordinary_Vector(double[] d)
        {
            double buf;
            this.size = d.Length;
            data = new double[size];
            for (int i = 0; i < size; i++)
            {
                buf = d[i];
                this.data[i] = buf;
            }
        }
        public int Size
        {
            get
            {
                return size;
            }
        }
        public void Print()
        {
            for (int i = 0; i < Size; i++)
                Console.Write(GetData(i) + " ");
            Console.Write("\n");
        }
        public double GetSum()
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
                sum = sum + data[i];
            return sum;
        }
        public double Max()
        {
            double max = data[0];
            for (int i = 1; i < size; i++)
                if (data[i] > max)
                    max = data[i];
            return max;
        }
        public int No_Zero()
        {
            int count = size;
            for (int i = 0; i < size; i++)
                if (data[i] == 0)
                    count--;
            return count;
        }
    }
}
