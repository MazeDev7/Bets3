using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingGame
{
    public partial class BettingGame : Form
    {
        private RandomNumberGenerator random;
        private powerball newTicket;
        private powerball winningTicket;
        private Horse Horse1;
        private Horse Horse2;
        private Horse Horse3;
        private Horse Horse4;
        private Horse Horse5;
        private Horse myHorse;
        private Horse [] opponents = new Horse[4];
        private Poker myHand;
        private Poker opponenthand;

        public BettingGame()
        {
            InitializeComponent();
            random = new RandomNumberGenerator(); 
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Powerball_Click(object sender, EventArgs e)
        {
            newTicket = new powerball(random);
            winningTicket = new powerball(random);
            Bets<powerball> boughtTicket = new Bets<powerball>();

            boughtTicket.WagerAmount = 2;
            boughtTicket.Mine = newTicket;
            boughtTicket.Theirs = winningTicket;

            int result = boughtTicket.Do_Powerball_Bet();

            if (result > 0)
            {
                this.Lbl_pbWinner.Text = "You win:";
                this.powerballWinnings.ForeColor = System.Drawing.Color.White;
                this.powerballWinnings.Text = "+ $";
                this.powerballWinnings.Text = result.ToString();
            }
            else
            {
                this.Lbl_pbWinner.Text = "You lose: ";

                this.powerballWinnings.ForeColor = System.Drawing.Color.Red;
                this.powerballWinnings.Text = "$";
                this.powerballWinnings.Text += result.ToString();
            }
            setEarnings(result);
        }



        private void btn_race_Click(object sender, EventArgs e)
        {
            int raceResult = 0, result = 60, maxSpeed = 0;
            string fastestHorse = "";

            myHorse.randomizeSpeed();
            for (int i = 0; i < 4; i++)
            {
                opponents[i].randomizeSpeed();
            }

            Bets<Horse> horseRace = new Bets<Horse>();
            horseRace.WagerAmount = 30;
            horseRace.Mine = myHorse;

            for (int i = 0; i < 4; i++)
            {
                horseRace.Theirs = opponents[i];
                raceResult = horseRace.DoBet();

                if (raceResult < result)
                {
                    result = raceResult;
                }
            }

            if(myHorse.getSpeed() > maxSpeed)
            {
                maxSpeed = myHorse.getSpeed();
                fastestHorse = myHorse.getName();
            }
            for (int i = 0; i < 4; i++)
            {
                if (opponents[i].getSpeed() > maxSpeed)
                {
                    maxSpeed = opponents[i].getSpeed();
                    fastestHorse = opponents[i].getName();
                }
            }

                if (result > 0)
                {

                    this.lbl_horseResult.Text = "You win: ";
                    this.horseWinnings.ForeColor = System.Drawing.Color.White;
                    this.horseWinnings.Text = "+ $";
                    this.horseWinnings.Text += result.ToString();
                }
                else
                {
                    this.lbl_horseResult.Text = "You lose: ";
                    this.horseWinnings.ForeColor = System.Drawing.Color.Red;
                    this.horseWinnings.Text = "$";
                    this.horseWinnings.Text += result.ToString();

                }

            this.winningHorseData.Text = fastestHorse;
          
            setEarnings(result);

            this.btn_race.Enabled = false;
           
           
            this.horse1.Enabled = false;
            this.horse2.Enabled = false;
            this.horse3.Enabled = false;
            this.horse4.Enabled = false;
            this.horse5.Enabled = false;

            this.btn_play_horse.Enabled = true;
        }

        void setEarnings(int result)
        {
            int winnings;

            winnings = Convert.ToInt32(this.lbl_winLoss_data.Text);
            winnings += result;

            if (winnings < 0)
            {
                this.lbl_winLoss_data.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.lbl_winLoss_data.ForeColor = System.Drawing.Color.White;
            }
            this.lbl_winLoss_data.Text = winnings.ToString();

        }

        private void btn_play_poker_Click(object sender, EventArgs e)
        {
            myHand = new Poker(random);

        }

        private void horse1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.horse1.Checked == true)
            {
                this.btn_race.Enabled = true;
            }

            myHorse = Horse1;
            opponents[0] = Horse2;
            opponents[1] = Horse3;
            opponents[2] = Horse4;
            opponents[3] = Horse5;

            Horse1.setUserHorse(true);
            Horse2.setUserHorse(false);
            Horse3.setUserHorse(false);
            Horse4.setUserHorse(false);
            Horse5.setUserHorse(false);

        }

        private void horse2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.horse2.Checked == true)
            {
                this.btn_race.Enabled = true;
            }

            myHorse = Horse2;
            opponents[0] = Horse1;
            opponents[1] = Horse3;
            opponents[2] = Horse4;
            opponents[3] = Horse5;

            Horse1.setUserHorse(false);
            Horse2.setUserHorse(true);
            Horse3.setUserHorse(false);
            Horse4.setUserHorse(false);
            Horse5.setUserHorse(false);
        }

        private void horse3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.horse3.Checked == true)
            {
                this.btn_race.Enabled = true;
            }
            myHorse = Horse3;
            opponents[0] = Horse1;
            opponents[1] = Horse2;
            opponents[2] = Horse4;
            opponents[3] = Horse5;

            Horse1.setUserHorse(false);
            Horse2.setUserHorse(false);
            Horse3.setUserHorse(true);
            Horse4.setUserHorse(false);
            Horse5.setUserHorse(false);
        }

        private void horse4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.horse4.Checked == true)
            {
                this.btn_race.Enabled = true;
            }
            myHorse = Horse4;
            opponents[0] = Horse1;
            opponents[1] = Horse2;
            opponents[2] = Horse3;
            opponents[3] = Horse5;

            Horse1.setUserHorse(false);
            Horse2.setUserHorse(false);
            Horse3.setUserHorse(false);
            Horse4.setUserHorse(true);
            Horse5.setUserHorse(false);
        }

        private void horse5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.horse5.Checked == true)
            {
                this.btn_race.Enabled = true;
            }
            myHorse = Horse5;
            opponents[0] = Horse1;
            opponents[1] = Horse2;
            opponents[2] = Horse3;
            opponents[3] = Horse4;

            Horse1.setUserHorse(false);
            Horse2.setUserHorse(false);
            Horse3.setUserHorse(false);
            Horse4.setUserHorse(false);
            Horse5.setUserHorse(true);
        }

        private void btn_play_horse_Click(object sender, EventArgs e)
        {
            Horse1 = new Horse("Seabiscuit", random);
            Horse2 = new Horse("Secretariat", random);
            Horse3 = new Horse("Seattle Slew", random);
            Horse4 = new Horse("Zenyetta", random);
            Horse5 = new Horse("Ruffian", random);

            this.horse1.Enabled = true;
            this.horse2.Enabled = true;
            this.horse3.Enabled = true;
            this.horse4.Enabled = true;
            this.horse5.Enabled = true;

            this.horse1.Checked = false;
            this.horse2.Checked = false;
            this.horse3.Checked = false;
            this.horse4.Checked = false;
            this.horse5.Checked = false;

            this.winningHorseData.Text = "";

            this.btn_play_horse.Enabled = false;
        }
    }
}
