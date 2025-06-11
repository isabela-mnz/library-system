using LibrarySystem.Files;

// Book Reservation System in a Library:
class Program
{
    public static void Main(string[] args)
    {
        Book book1984 = new Book("1984", "George Orwell", "0141182954", 15);
        Book lordOfTheRings = new Book("The Lord of the Rings", "J.R.R. Tolkien", "978-0618260274", 15);
        Book harryPotter = new Book("Harry Potter and the Half-Blood Prince", "J.K Rowling", "0-7475-8108-8", 15);
        Book jurassicPark = new Book("Jurassic Park", "Michael Crichton", "0-394-58816-9", 15);

        User user1 = new User(1, "Peter Oliveira", "Rua A, 123", "PeterOliv@gmail.com");
        User user2 = new User(2, "Maria Pereira", "Rua B, 456", "MariaPer@gmail.com");

        Console.WriteLine("---Available Books---");
        Console.WriteLine(book1984.GetBookInfo());
        Console.WriteLine(lordOfTheRings.GetBookInfo());
        Console.WriteLine(harryPotter.GetBookInfo());
        Console.WriteLine(jurassicPark.GetBookInfo());
        Console.WriteLine("---Making Reservations---");

        Reservation? mariaReservation = null;
        if (book1984.AvailableCopies > 0)
        {
            mariaReservation = new Reservation(101, book1984, user2, DateTime.Now, DateTime.Now.AddDays(7), Reservation.Status.Active);
            book1984.DecrementAvailableCopy();
            Console.WriteLine($"Reservation {mariaReservation.Id} created for {mariaReservation.ReservingUser.Name} for the book '{mariaReservation.ReservedBook.Title}'.");
        }
        else
        {
            Console.WriteLine($"Could not reserve the book '{book1984.Title}'");
        }

        if (mariaReservation != null)
        {
            Console.WriteLine("\n---Returning Book---");
            mariaReservation.MarkAsReturned();
            Console.WriteLine(book1984.GetBookInfo());
        }
        else
        {
            Console.WriteLine("No reservation was made to be returned.");
        }

        Console.WriteLine("---End of Test---");
    }
}
