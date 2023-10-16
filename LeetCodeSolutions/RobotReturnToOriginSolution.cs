using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class RobotReturnToOriginSolution
    {
        public bool JudgeCircle(string moves)
        {
            int leftRight = 0;
            int upDown = 0;

            foreach (char move in moves)
            {
                switch (move)
                {
                    case 'L':
                        leftRight--;
                        break;
                    case 'R':
                        leftRight++;
                        break;
                    case 'U':
                        upDown++;
                        break;
                    case 'D':
                        upDown--;
                        break;
                }
            }

            return leftRight == 0 && upDown == 0;
        }
    }
}
