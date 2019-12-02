using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Raffle_System
{
    public partial class RaffleAddu : Form
    {
        public List<string> eventRow; // Getting the rows for Event
        List<List<string>> data; //data on who's in event

        DatabaseConnect connect; // for class database
        MainForm mainform;

        Random rand;
        int index;

        System.Media.SoundPlayer player;// Music

        public RaffleAddu(DatabaseConnect conn, string tableName, MainForm mf)
        {
            InitializeComponent();
            mainform = mf;
            connect = conn;
            data = conn.AdduAttendanceData(tableName);

            lblRandom.BackColor = Color.FromArgb(200, lblRandom.BackColor);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Preparing for Randoming
            rand = new Random();
            index = rand.Next(data.Count);

            //Changing the Text
            lblRandom.Text = data[index][0];
            lblRandName.Text = $"{data[index][2]}, {data[index][1]}";
            pbRandom.Increment(1);

            if (pbRandom.Value == 40)
            {
                //Stop the Music
                player.Stop();
                //Placing the complete name
                lblRandName.Text = $"{data[index][2]}, {data[index][1]}";
                //Stop the Timer
                timeRandom.Stop();
                //Enabling Buttons
                btnRaffleStart.Visible = true;
                //Resetting the value to zero to restart
                pbRandom.Value = 0;
            }
        }

        private void btnRaffleStart_Click(object sender, EventArgs e)
        {
            //Music plays
            player = new System.Media.SoundPlayer("gg1.wav");
            player.Play();

            timeRandom.Start();
            btnRaffleStart.Visible = false; ;
        }

        private void btnRaffleStart_MouseEnter(object sender, EventArgs e)
        {
            btnRaffleStart.BackColor = Color.FromArgb(20, 80, 80);
        }

        private void btnRaffleStart_MouseLeave(object sender, EventArgs e)
        {
            btnRaffleStart.BackColor = Color.FromArgb(36, 116, 116);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainform.Show();
            this.Close();
        }
    }
}
