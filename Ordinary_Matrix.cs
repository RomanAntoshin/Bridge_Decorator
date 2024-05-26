using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Ordinary_Matrix: Some_Matrix
    {
        public Ordinary_Matrix(int row, int column): base(row, column)
        {
            for (int i = 0; i < Row; i++)
                SetVector(Get_vecctor(), i);
        }
        public Ordinary_Matrix(int row, int column, IDrawer drawer) : base(row, column, drawer)
        {
            for (int i = 0; i < Row; i++)
                SetVector(Get_vecctor(), i);
        }
        protected override IVector Get_vecctor()
        {
            return new Ordinary_Vector(Column);
        }
        public override void Draw(int step=0)
        {
            if(this.WithBorder==true)
                Drawer.DrawCell(Row, Column, step);
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                {
                    DrawElement(GetElement(i, j), i, j+step);
                }
        }
        public override void DrawElement(double data, int i, int j)
        {
            Drawer.DrawCellBody(data, i, j);
        }
        public override bool NecessaryDraw(int i, int j)
        {
            return true;
        }
    }
}
