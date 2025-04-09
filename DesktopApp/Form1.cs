using Booking.Data;
using Microsoft.EntityFrameworkCore;
using SharedModels.Models;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        private readonly BookingContext context;

        public Form1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookingContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookingContext-4b688890-71eb-4e92-936e-455d29dedbb6;Trusted_Connection=True;");

            context = new BookingContext(optionsBuilder.Options);

            InitializeComponent();
        }

        private void allReservations_Click(object sender, EventArgs e)
        {

            var reservation = context.Reservation
                .Include(res => res.User) // Sørg for at reservasjonen har riktig navigasjon til User
                .ToList();

            var viewReservation = reservation.Select(res => new
            {
                Reservationnumber = res.Id,
                UserName = res.User != null ? res.User.Name : "Ingen bruker",
                RoomNumber = res.RoomId,
                res.StartDate,
                res.EndDate,
                res.Notes,
                res.Status
            })
                .OrderBy(res => res.StartDate)
                .ToList();


            CustomDataGridView();
            dataGridView1.DataSource = viewReservation;
            Manage(sender, e);


        }

        private void CustomDataGridView()
        {
            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

        }

        private void AllRooms_Click(object sender, EventArgs e)
        {
            var rooms = context.Room.ToList();

            var viewRooms = rooms.Select(room => new
            {
                RoomNumber = room.Id,
                RoomName = room.Name,
                Capacity = room.Capacity,
                IsAvailable = room.IsAvailable
            })
                .OrderBy(room => room.RoomNumber)
                .ToList();

            dataGridView1.DataSource = viewRooms;
        }

        private void Manage(object sender, EventArgs e)
        {
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "Manage";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;

            //legg til event til knappen!
            //bruk num til å sende til korrekt nye view da flere editors skal brukes.
            // 1 = manage reservations
            // 2 = manage rooms
            // 3 = manage service

            dataGridView1.Columns.Add(edit);
        }

        


    }
}
