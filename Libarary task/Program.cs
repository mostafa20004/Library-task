namespace Libarary_task
{
    class Book
    {
        public string title;
        public string author;
        public string insbn;
        public bool avilabl;
        public List<Library> libs;

        public Book(string title = "non", string auther = "non", string insbn = "123", bool avilabl = true)
        {
            this.title = title;
            this.author = auther;
            this.insbn = insbn;
            this.avilabl = avilabl;
            this.libs = new List<Library>();

        }

        public string GetTitle() { return title; }
        public string GetAuther() { return author; }
        public string GetInsbn() { return insbn; }
        public bool GetAvilabl() { return avilabl; }

        public void SetTitle(string title) { this.title = title; }
        public void SetAuhor(string author) { this.author = author; }
        public void SetInsbn(string insbn) { this.insbn = insbn; }
        public void SetAvilabl(bool avilabl) { this.avilabl = avilabl; }



    }
    class Library
    {
        public string title;
        public string author;
        public string insbn;
        public bool avilabl;
        public List<Book> books = new List<Book>();
        //Add
        public void AddBook(Book book)
        {
            Library libs = new Library();
            books.Add(book);
            Console.WriteLine($"Book ({book.title}) added successfully");
        }
        // SearchBook
        public void SearchBook(string search)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == search || books[i].author == search)
                {
                    avilabl = true;
                    if (books.Count > 0)
                    {
                        Console.WriteLine("Books found:");
                        for (int j = 0;j<books.Count;j++)
                        {
                            books.Add((Book)books[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No books found with that query.");
                    }

                }
                else
                {
                    Console.WriteLine("non");
                }

            }
        }
        //BorrowBook
        public void BorrowBook(string brrValue)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == brrValue || books[i].author == brrValue)
                {
                   
                    avilabl = false;
                    Console.WriteLine($"you borrow {brrValue} book author is {books[i].author}");
                    break;
                }
                
            }
            Console.WriteLine("not avilable");
        }
        //ReturnBook
        public void ReturnBook(string brrValue)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == brrValue || books[i].author == brrValue)
                {
                    avilabl = true;
                    Console.WriteLine($"you return  {brrValue} book ");
                    break;
                }
                  
                
            }
            Console.WriteLine("not avilable");
        }

}
        internal class Program
        {
            static void Main(string[] args)
            {
                Library library = new Library();
                library.AddBook(new Book("The Great Gatsby", "F.Scott Fitzgerald", "9780743273565"));
                library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
                library.AddBook(new Book("1984", "George Orwell", "9780451524935"));
            Console.WriteLine("=============================================================");
                Console.WriteLine("Searching and borrowing books...");
                library.BorrowBook("The Great Gatsby");
                library.BorrowBook("To Kill a Mockingbird");
                library.BorrowBook("1984");
                library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("To Kill a Mockingbird");
            library.ReturnBook("1984");
            library.ReturnBook("Harry Potter"); // This book is not borrowed

            Console.ReadLine();


            }
        }
    
}
