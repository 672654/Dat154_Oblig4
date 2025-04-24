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
    /// Interaction logic for Service.xaml
    /// </summary>
    public partial class Service : Window
    {
        private readonly BookingContext context;

        public Service(BookingContext c)
        {
            InitializeComponent();
            context = c;

            LoadAllServices();
        }

        private void LoadAllServices()
        {
            var servicedata = context.Service
                .Select(s => new
                {
                    ServiceId = s.Id,
                    RoomNumber = s.RoomId,
                    Occupied = s.Room.IsAvailable ? "No" : "Yes",
                    ServiceMessage = s.ServiceMessage,
                    Status = s.ServiceStatus,
                    TextContent = s.ServiceStatus.Contains("Pending") ? "Do Service" : "Service Done",
                    ButtonColor = s.ServiceStatus.Contains("Pending") ? "Red" : "Yellow",
                    IsRedColor = s.ServiceStatus.Contains("Progress") ? false : true,
                })
                .OrderByDescending(s => s.IsRedColor)
                .ToList();

            ServiceGrid.ItemsSource = servicedata;

        }

        private void DoService_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int serviceId = (int)button.CommandParameter;

            var service = context.Service
                .Where(s => s.Id == serviceId)
                .FirstOrDefault();

            if (service != null)
            {
                if (service.ServiceStatus.Contains("Pen"))
                {
                    service.ServiceStatus = "In Progress";
                    context.SaveChanges();
                    LoadAllServices();
                }
                else if (service.ServiceStatus.Contains("Prog"))
                {
                    service.ServiceStatus = "Finished";
                    context.SaveChanges();
                    LoadAllServices();
                }
                else
                {
                    MessageBox.Show($"Service for room {service.RoomId} is already finished.");
                    LoadAllServices();
                }
            }
        }
    }
}
