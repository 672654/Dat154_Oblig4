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

namespace ServiceAppWPF
{
    /// <summary>
    /// Interaction logic for Maintenance.xaml
    /// </summary>
    public partial class Maintenance : Window
    {
        private readonly BookingContext context;
        public Maintenance(BookingContext c)
        {
            InitializeComponent();
            context = c;

            LoadAllMaintenance();
        }

        private void LoadAllMaintenance()
        {
            var maintenancedata = context.Maintenance
                .Select(s => new
                {
                    MaintenanceId = s.Id,
                    RoomNumber = s.RoomId,
                    Occupied = s.Room.IsAvailable ? "No" : "Yes",
                    Description = s.Description,
                    Status = s.Status,
                    TextContent = s.Status.Contains("Pending") ? "Start Service" : "Service Done",
                    ButtonColor = s.Status.Contains("Pending") ? "Red" : "Yellow",
                    IsRedColor = s.Status.Contains("Progress") ? false : true,
                })
                .OrderByDescending(s => s.IsRedColor)
                .ToList();

            MaintenanceGrid.ItemsSource = maintenancedata;
        }

        private void MaintenanceButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int maintenanceId = (int)button.CommandParameter;

            var maintenance = context.Maintenance
                .Where(s => s.Id == maintenanceId)
                .FirstOrDefault();

            if (maintenance != null)
            {
                if (maintenance.Status.Contains("Pen"))
                {
                    maintenance.Status = "In Progress";
                }
                else if (maintenance.Status.Contains("Prog"))
                {
                    maintenance.Status = "Done";
                }
               
                
                context.SaveChanges();
                LoadAllMaintenance();
            }

        }
    }
}
