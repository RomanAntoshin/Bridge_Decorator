using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class DrawOnConsole: IDrawer
    {
        private StringBuilder content=new StringBuilder();
        private RichTextBox box;
        private int row;
        private int column;
        private List<(int, int, int)> place;
        bool flag = false;
        public DrawOnConsole(RichTextBox richTextBox)
        {
            place = new List<(int, int, int)>();
            box = richTextBox;
        }
        public DrawOnConsole(RichTextBox richTextBox, int row, int column)
        {
            place = new List<(int, int, int)>();
            box = richTextBox;
            this.row = row;
            this.column = column;
        }
        public void DrawCell(int row, int column, int step=0)
        {
            flag = true;
            string pattern = content.ToString();
            for (int j = 0; j < row; j++)
            {
                for (int i = 0; i < column; i++)
                    pattern = pattern + "+-----+";
                pattern = pattern + "\n";
                for (int i = 0; i < column; i++)
                {
                    place.Add((j, i, pattern.Length + 1));
                    pattern = pattern + "+     +";
                }
                pattern = pattern + "\n";
            }
            for (int i = 0; i < column; i++)
                pattern = pattern + "+----+";
            content.Append(pattern);
            box.Text = content.ToString();
        }
        public void DrawCellBody(double data, int i, int j)
        {
            if (place.Count == 0)
            {
                content.Insert(content.Length, data.ToString() + "   ");
                if (j == column-1)
                    content.Insert(content.Length, "\n");
            }
            else
            {
                for (int k = 0; k < place.Count; k++)
                    if (place[k].Item1 == i && place[k].Item2 == j)
                    {
                        content.Insert(place[k].Item3, data.ToString());
                        content.Remove(place[k].Item3 + data.ToString().Length, data.ToString().Length);
                    }
            }
            box.Text = content.ToString();
        }
        public void Draw(IMatrix matrix)
        {
            /*if (matrix.WithBorder == true)
                DrawCell(matrix.Row, matrix.Column);*/
            DrawCell(matrix.Row, matrix.Column);
            /*if (matrix.WithBorder == false)
                box.Clear();*/
            for (int i = 0; i < matrix.Row; i++)
                for (int j = 0; j < matrix.Column; j++)
                    DrawCellBody(matrix.GetElement(i, j), i, j);
        }
    }
}
