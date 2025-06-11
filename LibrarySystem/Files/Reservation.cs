using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Files
{
    public class Reservation
    {
        public int Id { get; set; }
        public Book ReservedBook { get; set; }
        public User ReservingUser { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public Status ReservationStatus { get; set; }

        public enum Status
        {
            Active,
            Canceled,
            Returned
        }

        public Reservation(int id, Book reservedBook, User reservingUser, DateTime reservationDate, DateTime expectedReturnDate, Status status)
        {
            Id = id;
            ReservedBook = reservedBook;
            ReservingUser = reservingUser;
            ReservationDate = reservationDate;
            ExpectedReturnDate = expectedReturnDate;
            ReservationStatus = status;
        }

        public void CancelReservation()
        {
            if (ReservationStatus == Status.Active)
            {
                ReservationStatus = Status.Canceled;
                ReservedBook.IncrementAvailableCopy();
                Console.WriteLine($"Reservation {Id} canceled. Copy of book '{ReservedBook.Title}' returned.");
            }
            else
            {
                Console.WriteLine($"Reservation {Id} cannot be canceled. Current status: {ReservationStatus}.");
            }
        }

        public void MarkAsReturned()
        {
            if (ReservationStatus == Status.Active)
            {
                ReservationStatus = Status.Returned;
                ReservedBook.IncrementAvailableCopy();
                Console.WriteLine($"Reservation {Id} returned. Copy of book '{ReservedBook.Title}' returned to stock.");
            }
            else
            {
                Console.WriteLine($"Reservation {Id} cannot be returned. Current status: {ReservationStatus}.");
            }
        }
    }
}
