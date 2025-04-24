using Booking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        }

        private void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Manage"].Index && e.RowIndex >= 0)
            {
                //Id for reservasjon eller rom.
                int Id;
                if (dataGridView1.Columns["Reservationnumber"] != null)
                {

                    Id = (int)dataGridView1.Rows[e.RowIndex].Cells["Reservationnumber"].Value;
                    var reservation = context.Reservation.Find(Id);

                    ReservationManagement reservationManagement = new ReservationManagement(context, reservation);
                    reservationManagement.ShowDialog();

                }
                else if (dataGridView1.Columns["RoomNumber"] != null)
                {
                    Id = (int)dataGridView1.Rows[e.RowIndex].Cells["RoomNumber"].Value;
                    var room = context.Room.Find(Id);

                    RoomManagement roomManagement = new RoomManagement(context, room);
                    roomManagement.ShowDialog();

                }
            }
        }

        private void allReservations_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            var reservation = context.Reservation
                .Include(res => res.User) // Sørg for at reservasjonen har riktig navigasjon til User
                .ToList();

            var reservationAndRoom = context.Reservation
                .Join(context.Room, res => res.RoomId, room => room.Id, (res, room) => new
                {
                    Reservationnumber = res.Id,
                    Customer = res.User != null ? res.User.Name : "Ingen bruker",
                    RoomNumber = res.RoomId,
                    RoomName = room.Name,
                    From = res.StartDate,
                    To = res.EndDate,
                    Notes = res.Notes,
                    Status = res.Status
                })
                .OrderBy(r => r.From)
                .ToList();


            CustomDataGridView();
            dataGridView1.DataSource = reservationAndRoom;
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
            dataGridView1.Columns.Clear();
            var rooms = context.Room.ToList();

            var viewRooms = rooms.Select(room => new
            {
                RoomNumber = room.Id,
                RoomName = room.Name,
                Capacity = room.Capacity,
                IsAvailable = room.IsAvailable,
                Cleaned = room.IsCleaned
            })
                .OrderBy(room => room.RoomNumber)
                .ToList();

            dataGridView1.DataSource = viewRooms;
            Manage(sender, e);
        }


        private void Manage(object sender, EventArgs e)
        {
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "Manage";
            edit.Text = "Edit";
            edit.Name = "Manage";
            edit.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(edit);
        }

        private void button2_CreateNewRoom_Click(object sender, EventArgs e)
        {
            CreateNewRoom createNewRoom = new CreateNewRoom(context);
            createNewRoom.ShowDialog();
        }

        private void button2_NewReservation_Click(object sender, EventArgs e)
        {
            CreateNewReservation createNewReservation = new CreateNewReservation(context);
            createNewReservation.ShowDialog();
        }
    }
}
