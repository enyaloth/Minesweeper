using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        // TODO: Change from Singleton; doesn't work for new game.
        public static Minefield minefield = Minefield.getInstance();
        MinefieldPainter minefieldPainter = new MinefieldPainter(minefield);

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minefield = Minefield.getInstance();
        }
    }
}
