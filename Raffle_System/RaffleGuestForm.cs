using System;
using System.Media;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Raffle_System
{
    public partial class RaffleGuest : Form
    {
        List<List<string>> data; //data on who's in event
        SoundPlayer player;
        float ticks;

        MainForm mainform;

        public RaffleGuest(List<List<string>> d, string tableName, float td, MainForm mf)
        {
            InitializeComponent();
            mainform = mf;
            data = d;
            ticks = td * 10;

            lblRandomSchool.BackColor = Color.FromArgb(200, lblRandomSchool.BackColor);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void RaffleGuest_Load(object sender, EventArgs e)
        {
            pnlMain.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
        }

        private void btnRaffleStart_Click(object sender, EventArgs e)
        {
            //Music plays
            player = new System.Media.SoundPlayer("gg1.wav");
            player.Play();
            timeRandom.Start();
            btnRaffleStart.Visible = false;
        }

        private void timeRandom_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int index = rand.Next(data.Count);
            
            lblRandomGuest.Text = $"{data[index][2]}, {data[index][1]}";
            lblRandomSchool.Text = data[index][3];
            pbRandomGuest.Increment(1);

            if (pbRandomGuest.Value >= ticks)
            {
                lblRandomGuest.Text = $"{data[index][2]}, {data[index][1]}";
                player.Stop();
                timeRandom.Stop();
                data.RemoveAt(index);
                btnRaffleStart.Visible = true;
                if (data.Count < 1)
                    btnRaffleStart.Enabled = false;
                pbRandomGuest.Value = 0;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainform.Show();
            this.Close();
        }
    }
}
