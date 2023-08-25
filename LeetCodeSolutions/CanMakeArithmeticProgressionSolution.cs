using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class CanMakeArithmeticProgressionSolution
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            int _StepProgression = int.MaxValue;
            List<int> _StepsOfProgression = new List<int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int _TempStep = Math.Abs(arr[i] - arr[i + 1]);

                _StepsOfProgression.Add(_TempStep);

                if (_TempStep < _StepProgression)
                {
                    _StepProgression = _TempStep;
                }
            }

            if (_StepProgression == 1)
            {
                return !_StepsOfProgression.Any(step => step != 1);
            }

            return _StepsOfProgression.All(step => step % _StepProgression == 0);
        }
    }
}
