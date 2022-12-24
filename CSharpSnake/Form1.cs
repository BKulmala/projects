using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSnake
{
    public partial class CSharpSnake : Form
    {
        int directionX = 5;
        int directionY = 5;
        int bottomBoundary;
        bool playerDetectedUp, playerDetectedLeft, playerDetectedRight, playerDetectedDown;
        public CSharpSnake()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - Snake.Height;
        }

        private void CSharpSnake_Load(object sender, EventArgs e)
        {

        }

        private void Apple_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random newAppleSpot = new Random();
            int newSpot = newAppleSpot.Next(100, ClientSize.Height - 100);
            if (playerDetectedUp == true) { Snake.Top -= 5; }
            if (playerDetectedLeft == true) { Snake.Left -= 5; }
            if (playerDetectedRight == true) { Snake.Left += 5; }
            if (playerDetectedDown == true) { Snake.Top += 5; }
        }

        private void CSharpSnake_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { playerDetectedUp = false; }
            if (e.KeyCode == Keys.Left) { playerDetectedLeft = false; }
            if (e.KeyCode == Keys.Right) { playerDetectedRight = false; }
            if (e.KeyCode == Keys.Down) { playerDetectedDown = false; }
        }
        private void CSharpSnake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { playerDetectedUp = true; }
            if (e.KeyCode == Keys.Left) { playerDetectedLeft = true; }
            if (e.KeyCode == Keys.Right) { playerDetectedRight = true; }
            if (e.KeyCode == Keys.Down) { playerDetectedDown = true; }
        }

    }
}
