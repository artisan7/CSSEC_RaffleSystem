using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Raffle_System
{
    public partial class MainForm : Form
    {
        int eventId;
        List<List<string>> adduList = new List<List<string>>();
        List<List<string>> guestList = new List<List<string>>();

        public MainForm()
        {
            InitializeComponent();
        }

        DatabaseConnect connect;
        List<List<string>> eventData;
        private void MainForm_Load(object sender, EventArgs e)
        {
            connect = new DatabaseConnect();
            eventData = connect.EventData();

            for (int i = 0; i < eventData.Count; i++)
                cmbEvents.Items.Add(eventData[i][1]);
        }

        private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string eventChosen = cmbEvents.Text;
            lblEventName.Text = eventChosen;
            if (eventChosen != "")
            {
                string tableName = eventData[eventId][5];
                guestList = connect.GuestAttendanceData(tableName);
                tableName = eventData[eventId][4];
                adduList = connect.AdduAttendanceData(tableName);
            }

            for (int i = 0; i < eventData.Count; i++)
            {
                if(eventData[i][1] == eventChosen)
                {
                    eventId = i;
                }
            }
        }

        private void btnEventRaffle_Click(object sender, EventArgs e)
        {
            if(cmbEvents.Text != "" && adduList.Count > 0)
            {
                string tableName = eventData[eventId][4];
                float timerDuration = (float) npDuration.Value;
                RaffleAddu rsInitialize = new RaffleAddu(adduList, tableName, timerDuration, this);
                rsInitialize.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Event/s available", "NO EVENTS");
            }
            
        }

        private void btnGuestRaffle_Click(object sender, EventArgs e)
        {
            if (cmbEvents.Text != "" && guestList.Count > 0)
            {
                string tableName = eventData[eventId][5];
                float timerDuration = (float)npDuration.Value;
                RaffleGuest rgfInitialize = new RaffleGuest(guestList, tableName, timerDuration, this);
                rgfInitialize.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Event/s available", "NO EVENTS");
            }
        }
    }
}
