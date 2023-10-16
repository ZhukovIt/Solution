using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class FindWinnerOnATicTacToeGameSolution
    {
        public string Tictactoe(int[][] moves)
        {
            short first = 0;
            short second = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                if (i % 2 == 0)
                {
                    first |= InterpretTurn(moves[i]);
                    if (IsWinner(first))
                        return "A";
                }
                else
                {
                    second |= InterpretTurn(moves[i]);
                    if (IsWinner(second))
                        return "B";
                }
            }

            return moves.Length == 9 ? "Draw" : "Pending";
        }
        //--------------------------------------------------------------
        private bool IsWinner(short _PlayerValue)
        {
            return
                (_PlayerValue & 1) != 0 && (_PlayerValue & 2) != 0 && (_PlayerValue & 4) != 0 ||
                (_PlayerValue & 8) != 0 && (_PlayerValue & 16) != 0 && (_PlayerValue & 32) != 0 ||
                (_PlayerValue & 64) != 0 && (_PlayerValue & 128) != 0 && (_PlayerValue & 256) != 0 ||
                (_PlayerValue & 1) != 0 && (_PlayerValue & 8) != 0 && (_PlayerValue & 64) != 0 ||
                (_PlayerValue & 2) != 0 && (_PlayerValue & 16) != 0 && (_PlayerValue & 128) != 0 ||
                (_PlayerValue & 4) != 0 && (_PlayerValue & 32) != 0 && (_PlayerValue & 256) != 0 ||
                (_PlayerValue & 1) != 0 && (_PlayerValue & 16) != 0 && (_PlayerValue & 256) != 0 ||
                (_PlayerValue & 4) != 0 && (_PlayerValue & 16) != 0 && (_PlayerValue & 64) != 0;
        }
        //--------------------------------------------------------------
        private short InterpretTurn(int[] _Move)
        {
            return (short)Math.Pow(2, _Move[0] * 3 + _Move[1]);
        }
        //--------------------------------------------------------------
    }
}
