using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class MinefieldPainter
    {
        private static Bitmap unknown = new Bitmap(@"C:\BekahStuff\projects\Minesweeper\BitmapCells\cell.png");
        private static readonly Bitmap mine;
        private static readonly Bitmap number;
        private static readonly Bitmap empty;
        
        private Bitmap[,] minefieldPainter;

        public Minefield minefield = Minefield.getInstance();

        public MinefieldPainter(Minefield minefield)
        {
            initializeNewMinefieldPaint();
        }

        public void initializeNewMinefieldPaint()
        {
            for (int row = 0; row < minefield.getRowCount(); row++)
            {
                for (int col = 0; col < minefield.getColumnCount(); col++)
                {
                    minefieldPainter[row, col] = unknown;
                }
            }
        }
       
    }
}
