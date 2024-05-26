using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface IMatrix
    {
        int Row { get; }
        int Column { get; }
        bool NecessaryDraw(int i, int j);
        double GetElement(int row, int column);
        void SetElement(int row, int column, double val);
        void SetDrawer(IDrawer drawer);
        IDrawer GetDrawer();
        void DrawBorder(int step);
        void Draw(int step=0);
        bool WithBorder { get; set; }
        IDrawer Drawer { get; }
        void DrawElement(double data, int i, int j);
        void AddMatrix(IMatrix m);
    }
}
