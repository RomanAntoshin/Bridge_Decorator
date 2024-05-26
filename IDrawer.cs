using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface IDrawer
    {
        void DrawCellBody(double data, int i, int j);
        void DrawCell(int i, int j, int step=0);
        void Draw(IMatrix m);
    }
}
