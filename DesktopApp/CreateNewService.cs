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
    public partial class CreateNewService : Form
    {
        private readonly BookingContext context;
        private Room room;
        public CreateNewService(BookingContext c, Room room)
        {
            InitializeComponent();
            context = c;
            this.room = room;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service service = new()
            {
                ServiceMessage = textBox_ServiceMessage.Text,
                RoomId = room.Id,
                ServiceStatus = "Pending",
            };
            context.Add(service);
            context.SaveChanges();
            MessageBox.Show($"Service Created in room {room.Name}");
            this.Close();
        }
    }
}
