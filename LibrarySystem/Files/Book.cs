using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Files
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }

        public Book(string title, string author, string isbn, int totalCopies)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            TotalCopies = totalCopies;
            AvailableCopies = totalCopies;
        }

        public void DecrementAvailableCopy()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                Console.WriteLine($"Copy of '{Title}' reserved. Available in stock: {AvailableCopies}");
            }
            else
            {
                Console.WriteLine($"No copies of '{Title}' are available.");
            }
        }

        public void IncrementAvailableCopy()
        {
            if (AvailableCopies < TotalCopies)
            {
                AvailableCopies++;
            }
        }

        public string GetBookInfo()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {Isbn}, Total Copies: {TotalCopies} and Available: {AvailableCopies}.";
        }
    }
}
