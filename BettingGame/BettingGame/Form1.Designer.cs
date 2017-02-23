namespace BettingGame
{
    partial class BettingGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BettingGame));
            this.Btn_Powerball = new System.Windows.Forms.Button();
            this.Lbl_pbWinner = new System.Windows.Forms.Label();
            this.horseLabel = new System.Windows.Forms.Label();
            this.horse1 = new System.Windows.Forms.RadioButton();
            this.horse2 = new System.Windows.Forms.RadioButton();
            this.horse3 = new System.Windows.Forms.RadioButton();
            this.horse4 = new System.Windows.Forms.RadioButton();
            this.horse5 = new System.Windows.Forms.RadioButton();
            this.btn_race = new System.Windows.Forms.Button();
            this.lbl_horseResult = new System.Windows.Forms.Label();
            this.horseWinnings = new System.Windows.Forms.Label();
            this.powerballWinnings = new System.Windows.Forms.Label();
            this.btn_play_poker = new System.Windows.Forms.Button();
            this.lbl_welcome_horse1 = new System.Windows.Forms.Label();
            this.lbl_welcome_horse2 = new System.Windows.Forms.Label();
            this.lbl__winLoss = new System.Windows.Forms.Label();
            this.lbl_winLoss_data = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_welcome_powerball1 = new System.Windows.Forms.Label();
            this.lbl_welcome_powerball2 = new System.Windows.Forms.Label();
            this.lbl_welcome_powerball3 = new System.Windows.Forms.Label();
            this.lbl_welcome_poker1 = new System.Windows.Forms.Label();
            this.lbl_welcome_poker2 = new System.Windows.Forms.Label();
            this.lbl_welcome_poker3 = new System.Windows.Forms.Label();
            this.lbl_welcome_horse3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_winningHorse = new System.Windows.Forms.Label();
            this.winningHorseData = new System.Windows.Forms.Label();
            this.btn_play_horse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Powerball
            // 
            this.Btn_Powerball.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Powerball.Location = new System.Drawing.Point(16, 240);
            this.Btn_Powerball.Name = "Btn_Powerball";
            this.Btn_Powerball.Size = new System.Drawing.Size(103, 36);
            this.Btn_Powerball.TabIndex = 0;
            this.Btn_Powerball.Text = "Buy Ticket!";
            this.Btn_Powerball.UseVisualStyleBackColor = true;
            this.Btn_Powerball.Click += new System.EventHandler(this.Btn_Powerball_Click);
            // 
            // Lbl_pbWinner
            // 
            this.Lbl_pbWinner.AutoSize = true;
            this.Lbl_pbWinner.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_pbWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pbWinner.ForeColor = System.Drawing.Color.Lavender;
            this.Lbl_pbWinner.Location = new System.Drawing.Point(30, 383);
            this.Lbl_pbWinner.Name = "Lbl_pbWinner";
            this.Lbl_pbWinner.Size = new System.Drawing.Size(0, 24);
            this.Lbl_pbWinner.TabIndex = 1;
            // 
            // horseLabel
            // 
            this.horseLabel.AutoSize = true;
            this.horseLabel.BackColor = System.Drawing.Color.Transparent;
            this.horseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseLabel.ForeColor = System.Drawing.Color.Lavender;
            this.horseLabel.Location = new System.Drawing.Point(338, 240);
            this.horseLabel.Name = "horseLabel";
            this.horseLabel.Size = new System.Drawing.Size(146, 20);
            this.horseLabel.TabIndex = 2;
            this.horseLabel.Text = "Choose your horse:";
            // 
            // horse1
            // 
            this.horse1.AutoSize = true;
            this.horse1.BackColor = System.Drawing.Color.Transparent;
            this.horse1.Enabled = false;
            this.horse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horse1.ForeColor = System.Drawing.Color.Lavender;
            this.horse1.Location = new System.Drawing.Point(342, 263);
            this.horse1.Name = "horse1";
            this.horse1.Size = new System.Drawing.Size(101, 24);
            this.horse1.TabIndex = 3;
            this.horse1.Text = "Seabiscuit";
            this.horse1.UseVisualStyleBackColor = false;
            this.horse1.CheckedChanged += new System.EventHandler(this.horse1_CheckedChanged);
            // 
            // horse2
            // 
            this.horse2.AutoSize = true;
            this.horse2.BackColor = System.Drawing.Color.Transparent;
            this.horse2.Enabled = false;
            this.horse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horse2.ForeColor = System.Drawing.Color.Lavender;
            this.horse2.Location = new System.Drawing.Point(342, 293);
            this.horse2.Name = "horse2";
            this.horse2.Size = new System.Drawing.Size(105, 24);
            this.horse2.TabIndex = 4;
            this.horse2.Text = "Secretariat";
            this.horse2.UseVisualStyleBackColor = false;
            this.horse2.CheckedChanged += new System.EventHandler(this.horse2_CheckedChanged);
            // 
            // horse3
            // 
            this.horse3.AutoSize = true;
            this.horse3.BackColor = System.Drawing.Color.Transparent;
            this.horse3.Enabled = false;
            this.horse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horse3.ForeColor = System.Drawing.Color.Lavender;
            this.horse3.Location = new System.Drawing.Point(342, 323);
            this.horse3.Name = "horse3";
            this.horse3.Size = new System.Drawing.Size(116, 24);
            this.horse3.TabIndex = 5;
            this.horse3.Text = "Seattle Slew";
            this.horse3.UseVisualStyleBackColor = false;
            this.horse3.CheckedChanged += new System.EventHandler(this.horse3_CheckedChanged);
            // 
            // horse4
            // 
            this.horse4.AutoSize = true;
            this.horse4.BackColor = System.Drawing.Color.Transparent;
            this.horse4.Enabled = false;
            this.horse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horse4.ForeColor = System.Drawing.Color.Lavender;
            this.horse4.Location = new System.Drawing.Point(342, 353);
            this.horse4.Name = "horse4";
            this.horse4.Size = new System.Drawing.Size(90, 24);
            this.horse4.TabIndex = 6;
            this.horse4.Text = "Zenyatta";
            this.horse4.UseVisualStyleBackColor = false;
            this.horse4.CheckedChanged += new System.EventHandler(this.horse4_CheckedChanged);
            // 
            // horse5
            // 
            this.horse5.AutoSize = true;
            this.horse5.BackColor = System.Drawing.Color.Transparent;
            this.horse5.Enabled = false;
            this.horse5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horse5.ForeColor = System.Drawing.Color.Lavender;
            this.horse5.Location = new System.Drawing.Point(342, 383);
            this.horse5.Name = "horse5";
            this.horse5.Size = new System.Drawing.Size(79, 24);
            this.horse5.TabIndex = 7;
            this.horse5.Text = "Ruffian";
            this.horse5.UseVisualStyleBackColor = false;
            this.horse5.CheckedChanged += new System.EventHandler(this.horse5_CheckedChanged);
            // 
            // btn_race
            // 
            this.btn_race.Enabled = false;
            this.btn_race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_race.Location = new System.Drawing.Point(342, 413);
            this.btn_race.Name = "btn_race";
            this.btn_race.Size = new System.Drawing.Size(142, 34);
            this.btn_race.TabIndex = 8;
            this.btn_race.Text = "Start Race!";
            this.btn_race.UseVisualStyleBackColor = true;
            this.btn_race.Click += new System.EventHandler(this.btn_race_Click);
            // 
            // lbl_horseResult
            // 
            this.lbl_horseResult.AutoSize = true;
            this.lbl_horseResult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_horseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horseResult.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_horseResult.Location = new System.Drawing.Point(338, 450);
            this.lbl_horseResult.Name = "lbl_horseResult";
            this.lbl_horseResult.Size = new System.Drawing.Size(0, 24);
            this.lbl_horseResult.TabIndex = 9;
            // 
            // horseWinnings
            // 
            this.horseWinnings.AutoSize = true;
            this.horseWinnings.BackColor = System.Drawing.Color.Transparent;
            this.horseWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseWinnings.ForeColor = System.Drawing.Color.Transparent;
            this.horseWinnings.Location = new System.Drawing.Point(427, 450);
            this.horseWinnings.Name = "horseWinnings";
            this.horseWinnings.Size = new System.Drawing.Size(0, 24);
            this.horseWinnings.TabIndex = 10;
            // 
            // powerballWinnings
            // 
            this.powerballWinnings.AutoSize = true;
            this.powerballWinnings.BackColor = System.Drawing.Color.Transparent;
            this.powerballWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerballWinnings.ForeColor = System.Drawing.Color.Lavender;
            this.powerballWinnings.Location = new System.Drawing.Point(131, 383);
            this.powerballWinnings.Name = "powerballWinnings";
            this.powerballWinnings.Size = new System.Drawing.Size(0, 24);
            this.powerballWinnings.TabIndex = 11;
            // 
            // btn_play_poker
            // 
            this.btn_play_poker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play_poker.Location = new System.Drawing.Point(749, 450);
            this.btn_play_poker.Name = "btn_play_poker";
            this.btn_play_poker.Size = new System.Drawing.Size(101, 36);
            this.btn_play_poker.TabIndex = 12;
            this.btn_play_poker.Text = "Play Hand!";
            this.btn_play_poker.UseVisualStyleBackColor = true;
            this.btn_play_poker.Click += new System.EventHandler(this.btn_play_poker_Click);
            // 
            // lbl_welcome_horse1
            // 
            this.lbl_welcome_horse1.AutoSize = true;
            this.lbl_welcome_horse1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome_horse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_horse1.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_welcome_horse1.Location = new System.Drawing.Point(302, 107);
            this.lbl_welcome_horse1.Name = "lbl_welcome_horse1";
            this.lbl_welcome_horse1.Size = new System.Drawing.Size(236, 24);
            this.lbl_welcome_horse1.TabIndex = 13;
            this.lbl_welcome_horse1.Text = "Welcome to Horse Racing!";
            // 
            // lbl_welcome_horse2
            // 
            this.lbl_welcome_horse2.AutoSize = true;
            this.lbl_welcome_horse2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome_horse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_horse2.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_welcome_horse2.Location = new System.Drawing.Point(302, 131);
            this.lbl_welcome_horse2.Name = "lbl_welcome_horse2";
            this.lbl_welcome_horse2.Size = new System.Drawing.Size(239, 24);
            this.lbl_welcome_horse2.TabIndex = 14;
            this.lbl_welcome_horse2.Text = "Each bet is $30. Good luck!";
            // 
            // lbl__winLoss
            // 
            this.lbl__winLoss.AutoSize = true;
            this.lbl__winLoss.BackColor = System.Drawing.Color.Transparent;
            this.lbl__winLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__winLoss.ForeColor = System.Drawing.Color.Lavender;
            this.lbl__winLoss.Location = new System.Drawing.Point(622, 29);
            this.lbl__winLoss.Name = "lbl__winLoss";
            this.lbl__winLoss.Size = new System.Drawing.Size(146, 24);
            this.lbl__winLoss.TabIndex = 15;
            this.lbl__winLoss.Text = "Net Win/Loss:  $";
            // 
            // lbl_winLoss_data
            // 
            this.lbl_winLoss_data.AutoSize = true;
            this.lbl_winLoss_data.BackColor = System.Drawing.Color.Transparent;
            this.lbl_winLoss_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winLoss_data.ForeColor = System.Drawing.Color.White;
            this.lbl_winLoss_data.Location = new System.Drawing.Point(774, 29);
            this.lbl_winLoss_data.Name = "lbl_winLoss_data";
            this.lbl_winLoss_data.Size = new System.Drawing.Size(24, 25);
            this.lbl_winLoss_data.TabIndex = 16;
            this.lbl_winLoss_data.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "The Betting Game!";
            // 
            // lbl_welcome_powerball1
            // 
            this.lbl_welcome_powerball1.AutoSize = true;
            this.lbl_welcome_powerball1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome_powerball1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_powerball1.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_welcome_powerball1.Location = new System.Drawing.Point(12, 131);
            this.lbl_welcome_powerball1.Name = "lbl_welcome_powerball1";
            this.lbl_welcome_powerball1.Size = new System.Drawing.Size(204, 24);
            this.lbl_welcome_powerball1.TabIndex = 18;
            this.lbl_welcome_powerball1.Text = "Welcome to Powerball!";
            // 
            // lbl_welcome_powerball2
            // 
            this.lbl_welcome_powerball2.AutoSize = true;
            this.lbl_welcome_powerball2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome_powerball2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_powerball2.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_welcome_powerball2.Location = new System.Drawing.Point(12, 179);
            this.lbl_welcome_powerball2.Name = "lbl_welcome_powerball2";
            this.lbl_welcome_powerball2.Size = new System.Drawing.Size(183, 24);
            this.lbl_welcome_powerball2.TabIndex = 19;
            this.lbl_welcome_powerball2.Text = "Each ticket cost is $2";
            // 
            // lbl_welcome_powerball3
            // 
            this.lbl_welcome_powerball3.AutoSize = true;
            this.lbl_welcome_powerball3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome_powerball3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_powerball3.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_welcome_powerball3.Location = new System.Drawing.Point(12, 155);
            this.lbl_welcome_powerball3.Name = "lbl_welcome_powerball3";
            this.lbl_welcome_powerball3.Size = new System.Drawing.Size(246, 24);
            this.lbl_welcome_powerball3.TabIndex = 20;
            this.lbl_welcome_powerball3.Text = "The jackpot is: $400,000,000";
            // 
            // lbl_welcome_poker1
            // 
            this.lbl_welcome_poker1.AutoSize = true;
            this.lbl_welcome_poker1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome_poker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_poker1.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_welcome_poker1.Location = new System.Drawing.Point(622, 131);
            this.lbl_welcome_poker1.Name = "lbl_welcome_poker1";
            this.lbl_welcome_poker1.Size = new System.Drawing.Size(170, 24);
            this.lbl_welcome_poker1.TabIndex = 21;
            this.lbl_welcome_poker1.Text = "Welcome to Poker!";
            // 
            // lbl_welcome_poker2
            // 
            this.lbl_welcome_poker2.AutoSize = true;
            this.lbl_welcome_poker2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome_poker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_poker2.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_welcome_poker2.Location = new System.Drawing.Point(622, 155);
            this.lbl_welcome_poker2.Name = "lbl_welcome_poker2";
            this.lbl_welcome_poker2.Size = new System.Drawing.Size(166, 24);
            this.lbl_welcome_poker2.TabIndex = 22;
            this.lbl_welcome_poker2.Text = "Each hand cost $5";
            // 
            // lbl_welcome_poker3
            // 
            this.lbl_welcome_poker3.AutoSize = true;
            this.lbl_welcome_poker3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome_poker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_poker3.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_welcome_poker3.Location = new System.Drawing.Point(622, 179);
            this.lbl_welcome_poker3.Name = "lbl_welcome_poker3";
            this.lbl_welcome_poker3.Size = new System.Drawing.Size(168, 24);
            this.lbl_welcome_poker3.TabIndex = 23;
            this.lbl_welcome_poker3.Text = "Reward is doubled";
            // 
            // lbl_welcome_horse3
            // 
            this.lbl_welcome_horse3.AutoSize = true;
            this.lbl_welcome_horse3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome_horse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_horse3.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_welcome_horse3.Location = new System.Drawing.Point(302, 155);
            this.lbl_welcome_horse3.Name = "lbl_welcome_horse3";
            this.lbl_welcome_horse3.Size = new System.Drawing.Size(168, 24);
            this.lbl_welcome_horse3.TabIndex = 24;
            this.lbl_welcome_horse3.Text = "Reward is doubled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(621, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "3";
            // 
            // lbl_winningHorse
            // 
            this.lbl_winningHorse.AutoSize = true;
            this.lbl_winningHorse.BackColor = System.Drawing.Color.Transparent;
            this.lbl_winningHorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winningHorse.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_winningHorse.Location = new System.Drawing.Point(158, 485);
            this.lbl_winningHorse.Name = "lbl_winningHorse";
            this.lbl_winningHorse.Size = new System.Drawing.Size(191, 24);
            this.lbl_winningHorse.TabIndex = 26;
            this.lbl_winningHorse.Text = "The winning horse is:";
            // 
            // winningHorseData
            // 
            this.winningHorseData.AutoSize = true;
            this.winningHorseData.BackColor = System.Drawing.Color.Transparent;
            this.winningHorseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winningHorseData.ForeColor = System.Drawing.Color.Lavender;
            this.winningHorseData.Location = new System.Drawing.Point(355, 485);
            this.winningHorseData.Name = "winningHorseData";
            this.winningHorseData.Size = new System.Drawing.Size(0, 24);
            this.winningHorseData.TabIndex = 27;
            // 
            // btn_play_horse
            // 
            this.btn_play_horse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play_horse.Location = new System.Drawing.Point(342, 203);
            this.btn_play_horse.Name = "btn_play_horse";
            this.btn_play_horse.Size = new System.Drawing.Size(142, 34);
            this.btn_play_horse.TabIndex = 28;
            this.btn_play_horse.Text = "Play Horse Race";
            this.btn_play_horse.UseVisualStyleBackColor = true;
            this.btn_play_horse.Click += new System.EventHandler(this.btn_play_horse_Click);
            // 
            // BettingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BettingGame.Properties.Resources.green_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 552);
            this.Controls.Add(this.btn_play_horse);
            this.Controls.Add(this.winningHorseData);
            this.Controls.Add(this.lbl_winningHorse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_welcome_horse3);
            this.Controls.Add(this.lbl_welcome_poker3);
            this.Controls.Add(this.lbl_welcome_poker2);
            this.Controls.Add(this.lbl_welcome_poker1);
            this.Controls.Add(this.lbl_welcome_powerball3);
            this.Controls.Add(this.lbl_welcome_powerball2);
            this.Controls.Add(this.lbl_welcome_powerball1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_winLoss_data);
            this.Controls.Add(this.lbl__winLoss);
            this.Controls.Add(this.lbl_welcome_horse2);
            this.Controls.Add(this.lbl_welcome_horse1);
            this.Controls.Add(this.btn_play_poker);
            this.Controls.Add(this.powerballWinnings);
            this.Controls.Add(this.horseWinnings);
            this.Controls.Add(this.lbl_horseResult);
            this.Controls.Add(this.btn_race);
            this.Controls.Add(this.horse5);
            this.Controls.Add(this.horse4);
            this.Controls.Add(this.horse3);
            this.Controls.Add(this.horse2);
            this.Controls.Add(this.horse1);
            this.Controls.Add(this.horseLabel);
            this.Controls.Add(this.Lbl_pbWinner);
            this.Controls.Add(this.Btn_Powerball);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BettingGame";
            this.Text = "Betting Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Powerball;
        private System.Windows.Forms.Label Lbl_pbWinner;
        private System.Windows.Forms.Label horseLabel;
        private System.Windows.Forms.RadioButton horse1;
        private System.Windows.Forms.RadioButton horse2;
        private System.Windows.Forms.RadioButton horse3;
        private System.Windows.Forms.RadioButton horse4;
        private System.Windows.Forms.RadioButton horse5;
        private System.Windows.Forms.Button btn_race;
        private System.Windows.Forms.Label lbl_horseResult;
        private System.Windows.Forms.Label horseWinnings;
        private System.Windows.Forms.Label powerballWinnings;
        private System.Windows.Forms.Button btn_play_poker;
        private System.Windows.Forms.Label lbl_welcome_horse1;
        private System.Windows.Forms.Label lbl_welcome_horse2;
        private System.Windows.Forms.Label lbl__winLoss;
        private System.Windows.Forms.Label lbl_winLoss_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_welcome_powerball1;
        private System.Windows.Forms.Label lbl_welcome_powerball2;
        private System.Windows.Forms.Label lbl_welcome_powerball3;
        private System.Windows.Forms.Label lbl_welcome_poker1;
        private System.Windows.Forms.Label lbl_welcome_poker2;
        private System.Windows.Forms.Label lbl_welcome_poker3;
        private System.Windows.Forms.Label lbl_welcome_horse3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_winningHorse;
        private System.Windows.Forms.Label winningHorseData;
        private System.Windows.Forms.Button btn_play_horse;
    }
}

