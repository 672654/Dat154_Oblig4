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
using Microsoft.EntityFrameworkCore.Diagnostics;
using SharedModels.Models;

namespace DesktopApp
{
    public partial class CreateNewReservation : Form
    {

        BookingContext context;

        public CreateNewReservation(BookingContext c)
        {
            InitializeComponent();
            context = c;

            LoadData();

            dataGridView1_Rooms.CellContentClick += dataGridView1_Rooms_CellContentClick;
        }

        private void LoadData()
        {
            dateTimeFrom.Value = DateTime.Now;
            dateTimeTo.Value = DateTime.Now;
        }

        private void button1_Search_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimeFrom.Value.Date;
            DateTime dateTo = dateTimeTo.Value.Date;

            if (dateFrom > dateTo)
            {
                MessageBox.Show("From date must be before To date");
                return;
            }
            else {
                var reservedRooms = context.Reservation
                    .Where(r => r.StartDate < dateTo && r.EndDate > dateFrom)
                    .Select(r => r.RoomId);

                var availableRooms = context.Room
                    .Where(r => !reservedRooms.Contains(r.Id) && r.IsAvailable);

                var listOfAvailableRooms = availableRooms.Select(room => new
                {
                    Roomnumber = room.Id,
                    Navn = room.Name,
                    room.Capacity,
                    Available = room.IsAvailable,
                    cleaned = room.IsCleaned
                });

                dataGridView1_Rooms.DataSource = listOfAvailableRooms.ToList();

                if (!dataGridView1_Rooms.Columns.Contains("Book"))
                { 
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn()
                    {
                        Name = "Book",
                        HeaderText = "Book",
                        Text = "Book Now",
                        UseColumnTextForButtonValue = true,
                    };

                    dataGridView1_Rooms.Columns.Add(buttonColumn);
                }

            }

        }



        private void dataGridView1_Rooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sjekk om klikket var i "Book Now"-kolonnen
            if (e.ColumnIndex == dataGridView1_Rooms.Columns["Book"].Index && e.RowIndex >= 0)
            {
                int roomId = (int)dataGridView1_Rooms.Rows[e.RowIndex].Cells["Roomnumber"].Value;
                    
                string customerName = textBox1_CustomerName.Text;
                if(customerName == "" || customerName == "Please enter a customer name")
                {
                    textBox1_CustomerName.Text = "Please enter a customer name";
                    textBox1_CustomerName.ForeColor = Color.Red;
                    textBox1_CustomerName.Focus();
                    return;
                }

                string notes = richTextBox1_Notes.Text;

                SaveReservationAndCustomer(roomId, customerName, notes);



                var user = context.User
                    .Where(u => u.Name == customerName).Select(u => u.Name)
                    .FirstOrDefault();
                MessageBox.Show($"Room {roomId} booked! {user}");

            }
        }

        private void SaveReservationAndCustomer(int roomId, string customerName, string notes)
        {
            User newUser = new User();
            newUser.Name = customerName;
            context.Add(newUser);
            context.SaveChanges();


            DateTime dateFrom = dateTimeFrom.Value.Date;
            DateTime dateTo = dateTimeTo.Value.Date;

            Reservation newReservation = new Reservation()
            {
                StartDate = dateFrom,
                EndDate = dateTo,
                UserId = newUser.Id,
                RoomId = roomId,
                Status = "Confirmed",
                Notes = notes
            };

            context.Add(newReservation);
            context.SaveChanges();

        }
    }
}
