using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingGame
{
    public class Horse : IComparable<Horse>
    {
        private const int numHorses = 4;
        //private int[] horses = new int[numHorses] { 0, 0, 0, 0 };
        private int speed = 0;
        private bool userHorse = false;
        private string horseName = "";
        private INumberGenerator _numberGenerator;    

        public Horse(string n, INumberGenerator numberGenerator2)
        {
            _numberGenerator = numberGenerator2;

            horseName = n;
            speed = _numberGenerator.Next(1, 1001);
        }

        public void randomizeSpeed()
        {
            
        }
        public void setUserHorse(bool user) { userHorse = user; }
        public int getSpeed() { return speed; }
        public string getName() { return horseName; }
        public int CompareTo(Horse rhs)
        {
            bool fastestHorse = false;

            if(this.speed > rhs.speed)
            {
                fastestHorse = true;
            }

            if (fastestHorse == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }       
        }

    }
}
