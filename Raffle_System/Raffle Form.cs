using System;
using System.Media;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Raffle_System
{
    public partial class RaffleAddu : Form
    {
        List<List<string>> data; //data on who's in event
        SoundPlayer player;// Music

        MainForm mainform;

        public RaffleAddu(DatabaseConnect conn, string tableName, MainForm mf)
        {
            InitializeComponent();
            mainform = mf;
            data = conn.AdduAttendanceData(tableName);
        }

        private void RaffleAddu_Load(object sender, EventArgs e)
        {
            this.pnlMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Preparing for Randoming
            Random rand = new Random();
            int index = rand.Next(data.Count);

            //Changing the Text
            lblRandom.Text = data[index][0];
            lblRandName.Text = $"{data[index][2]}, {data[index][1]}";
            pbRandom.Increment(1);

            if (pbRandom.Value == 52)
            {
                player.Stop();
                timeRandom.Stop();
                btnRaffleStart.Visible = true;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainform.Show();
            this.Close();
        }
    }
}
