using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class RenumberingDecorator: IMatrix
    {
        private IMatrix component;
        private static Dictionary<int, int> Rows = new Dictionary<int, int>();
        private static Dictionary<int, int> Columns = new Dictionary<int, int>();
        public RenumberingDecorator(IMatrix component)
        {
            this.component = component;
            Rows.Clear();
            Columns.Clear();
        }
        public bool WithBorder
        {
            get { return component.WithBorder; }
            set { component.WithBorder = value; }
        }
        public void SetElement(int row, int column, double val)
        {

        }
        public IDrawer GetDrawer()
        {
            return component.Drawer;
        }
        public void SetDrawer(IDrawer drawer)
        {
            component.SetDrawer(drawer);
        }
        public int Row
        {
            get { return component.Row; }
        }
        public int Column
        {
            get { return component.Column; }
        }
        public IDrawer Drawer
        {
            get { return component.Drawer; }
        }
        public double GetElement(int row, int column)
        {
            int a=row;
            int b=column;
            if (Rows.ContainsKey(row))
                a = Rows[row];
            if (Columns.ContainsKey(column))
                b = Columns[column];
            return component.GetElement(a, b);
        }
        public void DrawBorder(int step=0)
        {
            component.DrawBorder(0);
        }
        public void Draw(int step=0)
        {
            component.Drawer.Draw(this);
        }
        public void DrawElement(double data, int i, int j)
        {
            component.DrawElement(data, i, j);
        }
        public void RenumRow()
        {
            Rows.Clear();
            Random rnd = new Random();
            int Row1 = rnd.Next(0, Row / 2);
            int Row2 = rnd.Next(Row / 2, Row);
            Rows.Add(Row1, Row2);
            Rows.Add(Row2, Row1);
        }
        public void RenumColumn()
        {
            Random rnd = new Random();
            int Col1 = rnd.Next(0, Column / 2);
            int Col2 = rnd.Next(Column / 2, Column);
            Columns.Add(Col1, Col2);
            Columns.Add(Col2, Col1);
        }
        public void AddMatrix(IMatrix m)
        {

        }
        public bool NecessaryDraw(int i, int j)
        {
            return component.NecessaryDraw(i, j);
        }
    }
}
