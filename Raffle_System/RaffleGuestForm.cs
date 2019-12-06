using System;
using System.Media;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Raffle_System
{
    public partial class RaffleGuestForm : Form
    {
        List<List<string>> data; //data on who's in event
        SoundPlayer player;

        MainForm mainform;

        public RaffleGuestForm(DatabaseConnect conn, string tableName, MainForm mf)
        {
            InitializeComponent();
            mainform = mf;
            data = conn.GuestAttendanceData(tableName);

            lblRandomSchool.BackColor = Color.FromArgb(200, lblRandomSchool.BackColor);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void btnRaffleStart_Click(object sender, EventArgs e)
        {
            //Music plays
            player = new System.Media.SoundPlayer("gg1.wav");
            player.Play();
            timeRandom.Start();
            btnRaffleStart.Visible = false;
        }

        private void btnRaffleStart_MouseEnter(object sender, EventArgs e)
        {
            btnRaffleStart.BackColor = Color.FromArgb(20, 80, 80);
        }

        private void btnRaffleStart_MouseLeave(object sender, EventArgs e)
        {
            btnRaffleStart.BackColor = Color.FromArgb(36, 116, 116);
        }

        private void timeRandom_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int index = rand.Next(data.Count);
            
            lblRandomGuest.Text = $"{data[index][2]}, {data[index][1]}";
            lblRandomSchool.Text = data[index][3];
            pbRandomGuest.Increment(1);

            if (pbRandomGuest.Value == 52)
            {
                lblRandomGuest.Text = $"{data[index][2]}, {data[index][1]}";
                player.Stop();
                timeRandom.Stop();
                btnRaffleStart.Visible = true;
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
