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
    public partial class ReservationManagement : Form
    {
        private readonly BookingContext context;
        private readonly Reservation reservation;

        public ReservationManagement(BookingContext c, Reservation r)
        {
            InitializeComponent();
            context = c;
            reservation = r;

            LoadReservationData();
        }

        private void LoadReservationData()
        {

            richTextBox1_Reservation.Text = "Update Reservation.\nCheck in/out customer, or cancel the reservation.\nCancel will not delete, just notify the customer of cancellation";
            Reservation_CheckIn.Checked = false;
            Reservation_CheckOUT.Checked = false;
            Reservation_Cancel.Checked = false;
        }

        private void button1_UpdateReservation_Click(object sender, EventArgs e)
        {
            Room room = context.Room.FirstOrDefault(r => r.Id == reservation.RoomId);

            if (Reservation_Cancel.Checked)
            {
                reservation.Status = "Cancelled";
                context.SaveChanges();
            }
            else
            {
                reservation.Status = "Confirmed";
                context.SaveChanges();
            }

            if (room != null)
            {
                if (Reservation_CheckIn.Checked)
                {

                    room.CheckedIn = true;
                    room.CheckedOut = false;
                    room.IsAvailable = false;

                    context.SaveChanges();
                }
                if (Reservation_CheckOUT.Checked)
                {

                    room.CheckedOut = true;
                    room.CheckedIn = false;
                    room.IsCleaned = false;
                    room.IsAvailable = true;

                    context.SaveChanges();
                }
            }
            MessageBox.Show("Reservasjon oppdatert");
            this.Close();
        }

        private void button1_DeleteReservation_Click(object sender, EventArgs e)
        {
            context.Remove(reservation);
            context.SaveChanges();
            MessageBox.Show("Reservasjon slettet");
            this.Close();
        }
    }
}
