using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingGame
{
    public class powerball : IComparable<powerball>
    {
        const int SIZE = 5;
        private List<int> pbList = new List<int> { 0,0,0,0,0};
        private int power_b = 0;
        private INumberGenerator _numberGenerator;

        public powerball(INumberGenerator numberGenerator2) 
        {
            _numberGenerator = numberGenerator2;

            for (int i = 0; i < SIZE; i++)
            {
                this.pbList[i] = _numberGenerator.Next(1, 70);
            }

            power_b = _numberGenerator.Next(1, 27);
        }

        public int CompareTo(powerball rhs)
        {
            bool equal = false;

            if (this.pbList.Contains(rhs.pbList[0]) && this.pbList.Contains(rhs.pbList[1]) && this.pbList.Contains(rhs.pbList[2])
                && this.pbList.Contains(rhs.pbList[3]) && this.pbList.Contains(rhs.pbList[4]))
            {
                equal = true;
            }

            if (equal && (this.power_b == rhs.power_b))
            {
                return 1;
            }
            else
                return 0;


        }

    }
}
