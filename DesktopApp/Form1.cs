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

        private void button1_Click(object sender, EventArgs e)
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
    }
}
