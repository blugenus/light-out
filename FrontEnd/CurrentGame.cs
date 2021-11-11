using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    class CurrentGame
    {
        private const int ButtonWidth = 50;
        private const int ButtonHeight = 50;

        private Game ThisGame;
        private Panel ThisBoard;

        public CurrentGame(Panel TargetPanel)
        {
            ThisBoard = TargetPanel;
        }
            
        public void NewGame(Game Game)
        {
            ThisGame = Game;
            ResetBoard();
            SetBoard();
        }

        public void ResetBoard()
        {
            ThisBoard.Controls.Clear();
        }

        private void SetBoard()
        {
            for (int coun1 = 0; coun1 < ThisGame.Settings.Height; coun1++)
            {
                for (int coun2 = 0; coun2 < ThisGame.Settings.Width; coun2++)
                {
                    CreateNewButton(coun2, coun1, ThisGame.Board[coun1][coun2]);
                }
            }
        }

        private void CreateNewButton(int X, int Y, bool On) {
            Button NewBtn = new Button();

            NewBtn.Name = GetButtonName(X, Y);
            NewBtn.Width = ButtonWidth;
            NewBtn.Height= ButtonHeight;
            NewBtn.BackColor = GetButtonColor(On);
            NewBtn.Tag = new int[] {X, Y};
            NewBtn.Location = new Point(X * ButtonWidth, Y * ButtonHeight);
            
            NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            ThisBoard.Controls.Add(NewBtn);

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            int[] Target = (int[])((Button)sender).Tag;
            ToggleButton(Target[0] - 1, Target[1]);
            ToggleButton(Target[0] + 1, Target[1]);
            ToggleButton(Target[0], Target[1]);
            ToggleButton(Target[0], Target[1] - 1);
            ToggleButton(Target[0], Target[1] + 1);
        }

        private void ToggleButton(int X, int Y)
        {
            if (
                X >= 0 
                && X < ThisGame.Settings.Width
                && Y >= 0
                && Y < ThisGame.Settings.Height
                )
            {
                ThisGame.Board[Y][X] = !ThisGame.Board[Y][X];
                Button Btn = FindButton(X, Y);
                Btn.BackColor = GetButtonColor(ThisGame.Board[Y][X]);
            }
        }

        private Button FindButton(int X, int Y)
        {
            string ButtonName = GetButtonName(X, Y);
            foreach (Button Btn in ThisBoard.Controls.OfType<Button>())
            {
                if (ButtonName == Btn.Name)
                {
                    return Btn;
                }
            }
            return null;
        }

        private string GetButtonName(int X, int Y)
        {
            return "btn_" + X + "_" + Y;
        }

        private Color GetButtonColor(bool On)
        {
            return On ? Color.Green : Color.Black;
        }

    }
}
