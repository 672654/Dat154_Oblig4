using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Booking.Data;
using Microsoft.EntityFrameworkCore;
using SharedModels.Models;

namespace ServiceAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BookingContext context;
        public MainWindow()
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookingContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookingContext-4b688890-71eb-4e92-936e-455d29dedbb6;Trusted_Connection=True;");

            context = new BookingContext(optionsBuilder.Options);
            InitializeComponent();
        }

        private void Cleaning_Click(object sender, RoutedEventArgs e)
        {
            CleaningSchedule cleaningSchedule = new CleaningSchedule(context);
            cleaningSchedule.Show();
        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {
            Service service = new Service(context);
            service.Show();
        }

        private void Maintenance_Click(object sender, RoutedEventArgs e)
        {
            Maintenance maintenance = new Maintenance(context);
            maintenance.Show();
        }

       
    }
}