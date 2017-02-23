using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingGame
{
    public class Poker : IComparable<Poker>
    {
        public int [,] hand = new int [2,5] {{0,0,0,0,0},
                                            {0,0,0,0,0}};
        private INumberGenerator _numberGenerator;
        private static Random random = new Random();
        private int myHighScore = 0;
        private int otherHighscore = 0;
       
        public Poker(INumberGenerator numGen) 
        {
            _numberGenerator = numGen;

            for (int i = 0; i < 5; i++) 
            {
                hand[0,i] = _numberGenerator.Next(1, 14);
            }

            for (int i = 0; i < 5; i++)
            {
                hand[1, i] = _numberGenerator.Next(1, 5);
            }      
        }

        public void checkHighCard()
        {
            int max = 0;

            for (int i = 0; i < 5; i++)
            {
                if (hand[0, i] > max)
                {
                    max = hand[0, i];
                }
            }

            if (max > myHighScore)
            {
                myHighScore = max;
            }

        }
        public void checkPair()
        {
            bool[] Pair = new bool[2] { false, false };
            int iterator = 0;

            for (int i = 1; i <= 13; i++ )
            {
                Pair[0] = false;
                Pair[1] = false;

                for (int j = 0; j < 5; j++ )
                {
                    if (hand[0, j] == i)
                    {
                        Pair[iterator] = true;
                        iterator++;
                    }

                    if(Pair[0] && Pair[1] && (myHighScore < 100) )
                    {
                        myHighScore = 100;
                    }
                }
            }
        }

        public void checkTwoPair()
        {
            bool[] twoPair = new bool[4] { false, false, false, false };
            int iterator = 0;

            for (int i = 1; i <= 13; i++)
            {
                twoPair[0] = false;
                twoPair[1] = false;
                twoPair[2] = false;
                twoPair[3] = false;

                for (int j = 0; j < 5; j++)
                {
                    if (hand[0, j] == i)
                    {
                        twoPair[iterator] = true;
                        iterator++;
                    }

                    if (twoPair[0] && twoPair[1] && (myHighScore < 100))
                    {
                        myHighScore = 100;
                    }
                }
            }

        }

        public int CompareTo(Poker rhs)
        {

            return 0;
        }
    }
}
