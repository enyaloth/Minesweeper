using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.View
{
    internal class Class1
    {
        private static readonly Bitmap unkown = "C:\BekahStuff\projects\Minesweeper\BitmapCells\cell.png";
        private static readonly Bitmap mine;
        private static readonly Bitmap number;
        private static readonly Bitmap empty;

        private readonly Bitmap thisCell;

        public MineCellPainter(Bitmap cell)
        {
            thisCell = cell;
        }

        public Bitmap getMineCellPaint() => thisCell;

        public void setMineCellPaint(Bitmap cell)
        {
            thisCell = cell;
        }
    }
}
