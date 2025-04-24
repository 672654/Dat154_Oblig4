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
    public partial class CreateNewRoom : Form
    {
        private readonly BookingContext context;
        public CreateNewRoom(BookingContext context)
        {
            InitializeComponent();
            this.context = context;

            LoadNewRoomData();
        }

        private void LoadNewRoomData()
        {
            string info = "Fill in Room Name and Capasity." +
                "\nA new room will by default set availability and cleaned to false.";
            richTextBox1.Text = info;

            newRoomName.Text = "Put room name here!";
        }

        private void button1SaveNewRoom_Click(object sender, EventArgs e)
        {
            if (newRoomName.Text == "" || (int)newRoomCapasity.Value <= 0)
            {
                string feilmelding = "Error.\nPlease fill in Room Name and Capasity.";
                richTextBox1.Text = feilmelding;

            }
            else
            {

                Room newRoom = new Room();

                newRoom.Name = newRoomName.Text;
                newRoom.Capacity = (int)newRoomCapasity.Value;
                newRoom.IsAvailable = false;
                newRoom.IsCleaned = false;
                newRoom.CheckedIn = false;
                newRoom.CheckedOut = false;

                context.Add(newRoom);
                context.SaveChanges();
                MessageBox.Show("Nytt rom er opprettet");

                this.Close();

            }
            



        }
    }
}
