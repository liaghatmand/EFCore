using EFCoreInAction;
using Microsoft.EntityFrameworkCore;

static void ListAll() 
{
    using (var db = new AppDbContext())
    {
        foreach (var book in db.Books.AsNoTracking()
            .Include(book => book.Author)) 
        {
            var webUrl = book.Author.WebUrl == null ? "- no web Url was given-" : book.Author.WebUrl;
            Console.WriteLine($"{book.Title} by {book.Author.Name}");
            Console.WriteLine(" " + "Published on " + $"{book.PublishedOn:dd-MMM-yyyy}" + $". {webUrl}");
        }
    }
}
static void ChangeUrl()
{
    Console.WriteLine("New Quantom Networking WebUrl > ");
    var newWebUrl = Console.ReadLine();
    using (var db = new AppDbContext())
    {
        var singleBook = db.Books
        .Include(book => book.Author)
        .Single(book => book.Title == "Quantum Networking");
        singleBook.Author.WebUrl = newWebUrl;
        db.SaveChanges();
        Console.WriteLine("... SavedChanges called.");
    }
    ListAll();
}

Console.WriteLine("start");
ListAll();
ChangeUrl();