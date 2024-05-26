using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface IVector
    {
        int Size { get; }
        double GetData(int i);
        void SetData(int i, double val);
        void Print();
    }
}
