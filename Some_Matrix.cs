using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    abstract class Some_Matrix: IMatrix
    {
        private int row;
        private int column;
        private IVector[] v;
        private IDrawer drawer;
        private bool withBorder = false;
        public Some_Matrix(int row, int column)
        {
            this.row = row;
            this.column = column;
            this.v = new IVector[row];
            for(int i =0; i < row; i++)
            {
                v[i] = Get_vecctor();
            }
        }
        public Some_Matrix()
        {

        }
        public Some_Matrix(int row, int column, IDrawer drawer)
        {
            this.row = row;
            this.column = column;
            this.v = new IVector[row];
            for (int i = 0; i < row; i++)
            {
                v[i] = Get_vecctor();
            }
            SetDrawer(drawer);
        }
        protected abstract IVector Get_vecctor();
        public double GetElement(int row, int column)
        {
            if(row>=0 && row<this.Row && column>=0 && column<this.Column)
                return v[row].GetData(column);
            throw new Exception("Некорректный запрос");
        }
        public void SetVector(IVector vector, int i)
        {
            v[i] = vector;
        }
        public void SetElement(int row, int column, double val)
        {
            if (row >= 0 && row < this.Row && column >= 0 && column < this.Column)
                    v[row].SetData(column, val);
            else
                throw new Exception("Попытка присвоить значени несуществующему элементу");
        }
        public int Row
        {
           get{ return row; }
            protected set { row = value; }
        }
        public int Column
        {
            get { return column; }
            protected set { column = value; }
        }
        public void SetDrawer(IDrawer drawer)
        {
            this.drawer = drawer;
        }
        public IDrawer GetDrawer()
        {
            return drawer;
        }
        public void DrawBorder(int step)
        {
            drawer.DrawCell(Row, Column);
        }
        public IDrawer Drawer
        {
            get { return drawer; }
        }
        public bool WithBorder
        {
            get { return withBorder; }
            set { withBorder = value; }
        }
        abstract public void Draw(int step=0);
        abstract public void DrawElement(double data, int i, int j);
        abstract public bool NecessaryDraw(int i, int j);
        public void AddMatrix(IMatrix m)
        {

        }
    }
}
