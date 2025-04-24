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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharedModels.Models;

namespace DesktopApp
{
    public partial class CreateNewMaintenance : Form
    {
        private readonly BookingContext bookingContext;
        private Room room;

        public CreateNewMaintenance(BookingContext bookingContext, Room room)
        {
            InitializeComponent();
            this.bookingContext = bookingContext;
            this.room = room;

        }

        private void button1_CreateMaintenance_Click(object sender, EventArgs e)
        {
            string maintenanceMessage = textBox1_Maintanance.Text;

            if(maintenanceMessage is null || maintenanceMessage == "" || maintenanceMessage == "Write maintenance here")
            {
                textBox1_Maintanance.Text = "Write maintenance here";
                textBox1_Maintanance.ForeColor = Color.Red;
                return;
            }
            Maintenance NewMaintenance = new()
            {
                Description = maintenanceMessage,
                RoomId = room.Id,
                Status = "Pending",
            };
            bookingContext.Add(NewMaintenance);
            bookingContext.SaveChanges();
            MessageBox.Show($"Maintenance Created in room {room.Name}");
            this.Close();



        }
    }
}
