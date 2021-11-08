using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTaks
{
    abstract class Gameplay
    {
        protected string digit;
        protected bool first;
        protected int[] field =
            { 0, 0, 0 ,
            0, 0, 0,
            0, 0, 0 };

        public Gameplay(bool first)
        {
            this.first = first;

            if (first)
                digit = "X";
            else
                digit = "O";
        }

        protected void CheckDiagonal(int simbol)
        {
            if (field[0] == simbol && field[4] == simbol && field[8] == simbol
                || field[2] == simbol && field[4] == simbol && field[6] == simbol)
            {
                string message = digit + " won!";
                throw new ApplicationException(message);
            }
        }

        protected void CheckLanes(int simbol)
        {
            if (field[0] == simbol && field[1] == simbol && field[2] == simbol
                || field[3] == simbol && field[4] == simbol && field[5] == simbol
                || field[6] == simbol && field[7] == simbol && field[8] == simbol
                || field[0] == simbol && field[3] == simbol && field[6] == simbol
                || field[1] == simbol && field[4] == simbol && field[7] == simbol
                || field[2] == simbol && field[5] == simbol && field[8] == simbol)
            {
                string message = digit + " won!";
                throw new ApplicationException(message);
            }
        }

        public void CheckWin(int simbol)
        {
            CheckDiagonal(simbol);
            CheckLanes(simbol);
        }

        public void Draw()
        {
            bool temp = false;

            foreach (int item in field)
                if (item == 0) temp = true;

            if (!temp)
                throw new ApplicationException("Draw!");
        }

        public void Clear()
        {
            for (int i = 0; i < 9; i++)
                field[i] = 0;
        }

        public void SetFigure(int index)
        {
            if (field[index] == 0)
            {
                if (first)
                    field[index] = 1;
                else
                    field[index] = 2;
            }
        }

        public abstract int SetFigureComputer();
    }
}
