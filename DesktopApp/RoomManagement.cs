using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booking.Data;
using SharedModels.Models;

namespace DesktopApp
{
    public partial class RoomManagement : Form
    {
        private readonly BookingContext context;
        private readonly Room room;
        public RoomManagement(BookingContext context, Room room)
        {
            InitializeComponent();
            this.context = context;
            this.room = room;

            LoadRoomData();
        }

        private void LoadRoomData()
        {
            RoomName.Text = room.Name;
            capasity.Value = room.Capacity;
            isAvailable.Checked = room.IsAvailable;
            isCleaned.Checked = room.IsCleaned;
        }

        private void buttonChangeRoom_Click(object sender, EventArgs e)
        {
            room.Name = RoomName.Text;
            room.Capacity = (int)capasity.Value;
            room.IsAvailable = isAvailable.Checked;
            room.IsCleaned = isCleaned.Checked;
            if (room.IsCleaned)
            {
                room.CleaningStatus = "Finished";
            }
            else
            {
                room.CleaningStatus = "New";
            }

            context.SaveChanges();

            MessageBox.Show("Rominformasjon oppdatert!");
            this.Close();

        }

        private void button1DeleteRoom_Click(object sender, EventArgs e)
        {
            context.Remove(room);
            context.SaveChanges();
            MessageBox.Show("Rom slettet");
            this.Close();
        }

        private void button1NewRoom_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateNewRoom createNewRoom = new CreateNewRoom(context);
            createNewRoom.ShowDialog();
            
        }
    }
}
