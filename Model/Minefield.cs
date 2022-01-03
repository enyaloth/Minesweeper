using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    /** Constructs a cell which contains its value, position, and number of adjacent cells */
    public struct MineCell
    {
        int row;
        int col;
        char value;
        int adjacents;

        public MineCell(int row, int col, char value, int adj)
        {
            this.row = row;
            this.col = col;
            this.value = value;
            this.adjacents = adj;
        }

        public Point getCoordinate()
        {
            return new Point(row, col);
        }

        public int getAdj()
        {
            return adjacents;
        }

        public bool isMine()
        {
            return value == '*';
        }

    }

    /** 
     * Minefield class to handle Minefield behavior. 
     * Uses Singleton design pattern to ensure a single point of access for one Minefield for the game.
     */
    public class Minefield
    {
        private static readonly char SAFE = '.';
        private static readonly char MINE = '*';
        private static readonly int COLUMN_COUNT = 20;
        private static readonly int ROW_COUNT = 20;

        /** The max & min number of rows & columns allowed in random mine generation */
        private static readonly int MAX = 30;
        private static readonly int MIN = 10;

        private int myMineCount;

        /** a 2D array representation of the MineField */
        private MineCell[,] minefieldMatrix;

        private static Minefield theMinefield;

        /** A list stores the coordinates of all mines */
        List<MineCell> mines = new List<MineCell>();

        /** 
         * Constructs a minefield of randomly generated number of mines.
         * First initializes empty minefield, then randomly generates and places mines.
         */
        private Minefield()
        {
            minefieldMatrix = new MineCell[COLUMN_COUNT,ROW_COUNT];
            initializeEmptyMinefield();
            generateMineCount();
            placeMines();
            countAdjacents();
        }

        public static Minefield getInstance()
        {
            if (theMinefield == null)
            {
                theMinefield = new Minefield(); 
            }    
            return theMinefield;
        }

        /**
         * Getters & Setters
         */
        public MineCell[,] getMinefield() => minefieldMatrix;

        public int getRowCount() => ROW_COUNT;

        public int getColumnCount() => COLUMN_COUNT;

        public int getMineCount() => myMineCount;

        public List<MineCell> Mines => mines;

        public MineCell getCell(int row, int col) => minefieldMatrix[row, col];

        public void setMine(int row, int col)
        {
            minefieldMatrix[row, col] = new MineCell(row,col,MINE,0);
        }

        private void initializeEmptyMinefield()
        {
            for (int row=0; row<ROW_COUNT; row++)
            {
                for (int col=0; col<COLUMN_COUNT; col++)
                {
                    minefieldMatrix[row, col] = new MineCell(row,col,SAFE,0);
                }
            }
        }

        /** Generates a random number of mines between MAX and MIN */
        private void generateMineCount()
        {
            var rand = new Random();
            myMineCount = (rand.Next(MIN,MAX+1));
        }

        /** Randomly places mines throughout the field */
        private void placeMines()
        {
            int placeX;
            int placeY;
            for (int i=0; i<myMineCount; i++)
            {
                var rand = new Random();
                placeX = rand.Next(COLUMN_COUNT + 1);
                placeY = rand.Next(ROW_COUNT + 1);
                MineCell currMine = new MineCell(placeX, placeY, MINE, 0);
;                if (!mines.Contains(currMine))
                {
                    minefieldMatrix[placeX, placeY] = currMine;
                    mines.Add(currMine);
                }
                else i--;
            }
        }

        public void countAdjacents()
        {
            for (int row = 0; row<ROW_COUNT; row++)
            {
                for (int col = 0; col<COLUMN_COUNT; col++)
                {
                    if (minefieldMatrix[row, col].isMine())
                    {
                        for (int k = -1; k < 2; k++)
                        {
                            for (int l = -1; l < 2; l++)
                            {
                                try
                                {
                                    if (!minefieldMatrix[row + k, col + l].isMine())
                                    {
                                        int a = minefieldMatrix[row + k, col + l].getAdj();
                                        a++;
                                        minefieldMatrix[row + k, col + l] = new MineCell(row + k, col + l, SAFE, a);
                                    }
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void printMines()
        {
            foreach (MineCell p in mines)
            {
                Point currCell = p.getCoordinate();
                Console.WriteLine("(" + currCell.X + "," + currCell.Y + ")");
            }
        }

    }
}
