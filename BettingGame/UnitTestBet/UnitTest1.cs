using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BettingGame;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestBet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void calc_horse_gen() 
        {
            List<int> vals = new List<int> { 99 };
            string x="jerry";
            FakeNumberGenerator num_gen = new FakeNumberGenerator(vals);
            Horse my_horse = new Horse(x, num_gen);          
                Assert.AreEqual(99, my_horse.getSpeed());
        }

        [TestMethod]

        public void calc_get_horse_name()
        {

        }

        [TestMethod]
        public void calc_horse_class_gen() //case where user loses to opponent in horse betting  (integration testing)
        {
            List<int> vals = new List<int> { 25, 89, 110, 54 }; //initialize test vals for user & cpu
            List<int> vals2 = new List<int> { 99, 74, 68, 35 };
            string x = "jerry";
            FakeNumberGenerator num_gen = new FakeNumberGenerator(vals); //uses lists vals , vals2 as a fake random generator
            FakeNumberGenerator num_gen2 = new FakeNumberGenerator(vals2);
            Horse my_bet = new Horse(x, num_gen); //create instance from class containing both user's & other player's 'fake numbers' 
            Horse Their_bet = new Horse(x, num_gen2);

            Bets<Horse> horse_race = new Bets<Horse>(); // create instance from Generic Class of type Horse
            horse_race.WagerAmount = 60; //set user's wager amount 
            horse_race.Mine = my_bet;
            horse_race.Theirs = Their_bet;

            int winner = horse_race.DoBet(); //call CompareTo method to determine winner

            Assert.AreEqual(-(horse_race.WagerAmount), winner); //user loses money from wager amount 

        }

        [TestMethod]
        public void calc_user_win_horse() //case where user wins against opponent in horse betting (integration testing)
        {
            string x = "jerry";
            List<int> vals = new List<int> { 84, 59, 43, 54 }; //initialize test vals for user & cpu
            List<int> vals2 = new List<int> { 65, 74, 68, 80 };
            FakeNumberGenerator num_gen = new FakeNumberGenerator(vals); //uses lists vals , vals2 as a fake random generator
            FakeNumberGenerator num_gen2 = new FakeNumberGenerator(vals2);
            Horse my_bet = new Horse(x, num_gen); //create instance from class containing both user's & other player's 'fake numbers' 
            Horse Their_bet = new Horse(x, num_gen2);

            Bets<Horse> horse_race = new Bets<Horse>(); // create instance from Generic Class of type Horse
            horse_race.WagerAmount = 60; //set user's wager amount 
            horse_race.Mine = my_bet;
            horse_race.Theirs = Their_bet;

            int winner = horse_race.DoBet(); //call CompareTo method to determine winner

            Assert.AreEqual(horse_race.WagerAmount * 2, winner); //user wins double the money from wager amount 

        }
        [TestMethod]

        public void calc_user_lose_pball() //user losing in pball (integration testing )
        {
            List<int> vals = new List<int> { 84, 59, 43, 54 }; //initialize test vals for user & cpu
            List<int> vals2 = new List<int> { 65, 74, 68, 80 };
            FakeNumberGenerator num_gen = new FakeNumberGenerator(vals); //uses lists vals , vals2 as a fake random generator
            FakeNumberGenerator num_gen2 = new FakeNumberGenerator(vals2);

            powerball my = new powerball(num_gen);
            powerball your = new powerball(num_gen2);

            Bets<powerball> draw = new Bets<powerball>();
            draw.WagerAmount = 2;
            draw.Mine = my;
            draw.Theirs = your;

            int winner = draw.DoBet();

            Assert.AreEqual(-(draw.WagerAmount), winner);

        }
        [TestMethod]
        public void calc_user_win_pball() // user wins pball (integration testing)
        {
            List<int> vals = new List<int> { 84, 59, 43, 54 }; //initialize test vals for user & cpu
            List<int> vals2 = new List<int> { 84, 59, 43, 54 };
            FakeNumberGenerator num_gen = new FakeNumberGenerator(vals); //uses lists vals , vals2 as a fake random generator
            FakeNumberGenerator num_gen2 = new FakeNumberGenerator(vals2);

            powerball my = new powerball(num_gen);
            powerball your = new powerball(num_gen2);

            Bets<powerball> draw = new Bets<powerball>();
            draw.WagerAmount = 2;
            draw.Mine = my;
            draw.Theirs = your;

            int winner = draw.DoBet();

            Assert.AreEqual(2 * (draw.WagerAmount), winner);

        }
        // [TestMethod]
        //      public  void test_draw_card()
        //        {
        //            Poker my_card = new






        //        }


        //        [TestMethod]
        //        public void check_high_card()
        //        {
        //            int [,] test= new int[2,5]{{4, 8 , 1 , 3, 10 },
        //                                        {4,2, 1, 3,2 }};

        //           // FakeNumberGenerator fake_hand = new FakeNumberGenerator(test);

        //            Poker my_hand = new Poker(fake_hand);

        //            my_hand.checkHighCard();

        //            Assert.AreEqual(10, test);
        //        }
        //}
    }
}
