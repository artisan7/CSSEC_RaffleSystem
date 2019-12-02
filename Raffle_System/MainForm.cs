using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Raffle_System
{
    public partial class MainForm : Form
    {
        int eventId;

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
            if(cmbEvents.Text != "")
            {
                string tableName = eventData[eventId][4];
                RaffleAddu rsInitialize = new RaffleAddu(connect, tableName, this);
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
            if (cmbEvents.Text != "")
            {
                string tableName = eventData[eventId][5];
                RaffleGuestForm rgfInitialize = new RaffleGuestForm(connect, tableName, this);
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
