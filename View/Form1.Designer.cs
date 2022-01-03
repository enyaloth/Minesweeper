namespace Minesweeper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MinesweeperGrid = new System.Windows.Forms.Panel();
            this.newgamebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MinesweeperGrid
            // 
            this.MinesweeperGrid.Location = new System.Drawing.Point(17, 75);
            this.MinesweeperGrid.Name = "MinesweeperGrid";
            this.MinesweeperGrid.Size = new System.Drawing.Size(840, 840);
            this.MinesweeperGrid.TabIndex = 0;
            this.MinesweeperGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // newgamebutton
            // 
            this.newgamebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgamebutton.Location = new System.Drawing.Point(324, 18);
            this.newgamebutton.Name = "newgamebutton";
            this.newgamebutton.Size = new System.Drawing.Size(187, 51);
            this.newgamebutton.TabIndex = 1;
            this.newgamebutton.Text = "New Game";
            this.newgamebutton.UseVisualStyleBackColor = true;
            this.newgamebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 927);
            this.Controls.Add(this.newgamebutton);
            this.Controls.Add(this.MinesweeperGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MinesweeperGrid;
        private System.Windows.Forms.Button newgamebutton;
    }
}

