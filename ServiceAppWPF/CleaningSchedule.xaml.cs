using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Booking.Data;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SharedModels.Models;

namespace ServiceAppWPF
{
    /// <summary>
    /// Interaction logic for CleaningSchedule.xaml
    /// </summary>
    public partial class CleaningSchedule : Window
    {
        private readonly BookingContext context;
        public CleaningSchedule(BookingContext c)
        {
            InitializeComponent();
            context = c;

            LoadCleaningData();
        }

        private void LoadCleaningData()
        {
            var cleaningData = context.Room
                .Where(r => r.IsCleaned == false)
                .Select(r => new
                {
                    RoomNumber = r.Id,
                    Occupied = r.IsAvailable ? "No" : "Yes",
                    Cleaned = r.IsCleaned ? "Yes" : "No",
                    Status = r.CleaningStatus,
                    TextContent = r.CleaningStatus.Contains("Progress") ? "Finish cleaning" : "Start cleaning",
                    ButtonColor = r.CleaningStatus.Contains("Progress") ? "Green" : "Red",
                    IsRedColor = r.CleaningStatus.Contains("Progress") ? false : true,
                })
                .OrderByDescending(r => r.IsRedColor)
                .ToList();
            
            CleaningGrid.ItemsSource = cleaningData;

        }

        private void MarkAsCleande_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int roomnumber = (int)button.CommandParameter;

            

            var room = context.Room
                .Where(r => r.Id == roomnumber)
                .FirstOrDefault();



            if (room != null)
            {

                if (room.CleaningStatus.Contains("Progress"))
                {
                    room.IsCleaned = true;
                    room.CleaningStatus = "Finished";
                    context.SaveChanges();
                    LoadCleaningData();
                    MessageBox.Show($"Room {roomnumber} has been marked as cleaned and removed from your list.");
                }
                else
                {
                    room.IsCleaned = false;
                    room.CleaningStatus = "In Progress";
                    context.SaveChanges();
                    LoadCleaningData();
                    MessageBox.Show($"Room {roomnumber} has startet cleaning progress.");
                }

            }
        }
    }
}
