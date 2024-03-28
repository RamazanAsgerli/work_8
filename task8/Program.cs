namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("saas", "asds", "asdsa", 15, 12);
            Book book1= new Book("as", "sa", "asd", 10, 21);

            Library library = new Library();
            library.AddBook(book);
            library.AddBook(book1);
            library.ShowAllBooks();

         }
    }

    class Library
    {
        public Book[] Books = new Book[] {};
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public void ShowAllBooks()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine($"{Books[i].GetFullData()}");
            }
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] filteredBooks = new Book[] { };
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre == genre)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = Books[i];
                }

            }
            return filteredBooks;
        }

        public Book[] GetFilteredBooks(byte minPrice, byte maxPrice)
        {
            Book[] filteredBooks = new Book[] { };
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price > minPrice && Books[i].Price < maxPrice)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = Books[i];
                }
            }
            return filteredBooks;
        }




    }
}
