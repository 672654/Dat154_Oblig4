using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SharedModels.Models;

namespace Booking.Data
{
    public class BookingContext : DbContext
    {
        public BookingContext (DbContextOptions<BookingContext> options)
            : base(options)
        {
        }

        public DbSet<SharedModels.Models.Reservation> Reservation { get; set; } = default!;
        public DbSet<SharedModels.Models.User> User { get; set; } = default!;
        public DbSet<SharedModels.Models.Room> Room { get; set; } = default!;
    }
}
