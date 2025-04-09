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

        private void UpdateListViewColumns(string type)
        {
            mylistViewGridView.Columns.Clear(); 

            switch (type)
            {
                case "Room":
                    mylistViewGridView.Columns.Add(new GridViewColumn
                    {
                        Header = "Roomnumber",
                        DisplayMemberBinding = new Binding("Id")
                    });
                    mylistViewGridView.Columns.Add(new GridViewColumn
                    {
                        Header = "Type",
                        DisplayMemberBinding = new Binding("Name")
                    });
                    mylistViewGridView.Columns.Add(new GridViewColumn
                    {
                        Header = "Occupied",
                        DisplayMemberBinding = new Binding("Occupied")
                    });
                    mylistViewGridView.Columns.Add(new GridViewColumn
                    {
                        Header = "Cleaned",
                        DisplayMemberBinding = new Binding("Cleaned")
                    });

                    break;
                case "Reservation":
                    mylistViewGridView.Columns.Add(new GridViewColumn
                    {
                        Header = "Booking ID",
                        DisplayMemberBinding = new Binding("Id")
                    });
                    mylistViewGridView.Columns.Add(new GridViewColumn
                    {
                        Header = "Customer Name",
                        DisplayMemberBinding = new Binding("customerName")
                    });
                    
                    break;
            }
        }

        private void RoomList_Click(object sender, RoutedEventArgs e)
        {
            var r = context.Room
                .OrderBy(x => x.Id)
                .ToList();

            UpdateListViewColumns("Room");
            

            foreach (var room in r)
            {
                myListView.Items.Add(new
                {
                    Id = room.Id,
                    Name = room.Name,
                    Occupied = room.IsAvailable ? "No" : "Yes",
                    Cleaned = room.IsCleaned ? "Yes" : "No"
                });
            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}