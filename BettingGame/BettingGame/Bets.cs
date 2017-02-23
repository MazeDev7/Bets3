using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingGame
{
    public class Bets<T> where T : IComparable<T>
    {
        public T Mine { get; set; }
        public T Theirs { get; set; }
        public int WagerAmount { get; set; }
        public int jackpot = 400000000;
        public string fastesHorse = "";

        public int DoBet()
        {
            if (Mine == null || Theirs == null)
            {
                throw new InvalidOperationException("Must define Mine and Theirs before betting");
            }
          
          int multiplier = 1;
            
          if (Mine.CompareTo(Theirs) == 0)
            {
                    multiplier = -1;
                    return WagerAmount * multiplier;
            }    
            else
            {
                multiplier = 2;
                return  WagerAmount * multiplier;
            }
        }

        public int Do_Powerball_Bet()
        {
            if (Mine == null || Theirs == null)
            {
                throw new InvalidOperationException("Must define Mine and Theirs before betting");
            }

            int multiplier = 1;

            if (Mine.CompareTo(Theirs) == 0)
            {
                multiplier = -1;
                return WagerAmount * multiplier;
            }
            else
            {
                multiplier = 2;
                return jackpot;
            }
        }
    }
}



