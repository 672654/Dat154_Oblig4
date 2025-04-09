using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Booking.Data;
using SharedModels.Models;
using Microsoft.AspNetCore.Authorization;

namespace Booking.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly BookingContext _context;

        public ReservationsController(BookingContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> MakeReservation()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Search(DateTime checkInDate, DateTime checkOutDate)
        {
            var reservedRooms = await _context.Reservation
                .Where(r => (r.StartDate < checkOutDate && r.EndDate > checkInDate))
                .Select(r => r.RoomId)
                .ToListAsync();

            var availableRooms = await _context.Room
                .Where(r => !reservedRooms.Contains(r.Id) && r.IsAvailable)
                .ToListAsync();

            // Pass the check-in and check-out dates to the view
            ViewData["CheckInDate"] = checkInDate;
            ViewData["CheckOutDate"] = checkOutDate;
            ViewData["AvailableRooms"] = availableRooms;

            return View();
        }

        [Authorize]
        public async Task<IActionResult> Reserve(int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            ViewData["CheckInDate"] = checkInDate;
            ViewData["CheckOutDate"] = checkOutDate;

            var room = await _context.Room.FindAsync(roomId);
            ViewData["Room"] = room;


            return View();
        }
        [Authorize]
        public async Task<IActionResult> CreateNewReservation(int roomId, DateTime checkInDate, DateTime checkOutDate, string customerName, string notes)
        {
            User customer = new()
            {
                Name = customerName
            };
            _context.User.Add(customer);
            await _context.SaveChangesAsync();

            Room room = await _context.Room.FindAsync(roomId);

            if(notes == null)
            {
                notes = string.Empty;
            }
            var reservation = new Reservation
            {
                UserId = customer.Id,
                RoomId = roomId,
                StartDate = checkInDate,
                EndDate = checkOutDate,
                Status = "Confirmed Reservation",
                Notes = notes
            };

            if(customer.Reservations == null)
            {
                customer.Reservations = new List<Reservation>();
            }
            customer.Reservations.Add(reservation);

            _context.Reservation.Add(reservation);
           
            
            await _context.SaveChangesAsync();

            ViewData["Reservation"] = reservation;
            ViewData["Room"] = room;
            return View("ReservationDetails");
        }

        [Authorize]
        public async Task<IActionResult> ViewReservations()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> ViewReservationsForCustomer(string customerName)
        {
            var bookingContext = _context.Reservation
                .Include(r => r.User)
                .Where(r => r.User.Name == customerName);
            return View("Index",await bookingContext.ToListAsync());
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var bookingContext = _context.Reservation.Include(r => r.User);
            return View(await bookingContext.ToListAsync());
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "Name");
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,RoomId,StartDate,EndDate,Status,Notes")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "Name", reservation.UserId);
            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "Name", reservation.UserId);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,RoomId,StartDate,EndDate,Status,Notes")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "Name", reservation.UserId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservation.Remove(reservation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservation.Any(e => e.Id == id);
        }
    }
}
