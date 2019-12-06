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
        float ticks;

        MainForm mainform;

        public RaffleAddu(List<List<string>> d, string tableName, float td, MainForm mf)
        {
            InitializeComponent();
            mainform = mf;
            data = d;
            ticks = td*10;
        }

        private void RaffleAddu_Load(object sender, EventArgs e)
        {
            pnlMain.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
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

            if (pbRandom.Value >= ticks)
            {
                player.Stop();
                timeRandom.Stop();
                data.RemoveAt(index);
                btnRaffleStart.Visible = true;
                if (data.Count < 1)
                    btnRaffleStart.Enabled = false;
                pbRandom.Value = 0;
            }
        }

        private void btnRaffleStart_Click(object sender, EventArgs e)
        {
            //Music plays
            player = new System.Media.SoundPlayer("gg1.wav");
            player.Play();

            timeRandom.Start();
            btnRaffleStart.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainform.Show();
            this.Close();
        }
    }
}
