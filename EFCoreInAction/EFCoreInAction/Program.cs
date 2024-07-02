using EFCoreInAction;
using EFCoreInAction.Data;
using Microsoft.EntityFrameworkCore;

static void ListAll() 
{
    using (var db = new AppDbContext())
    {
        foreach (var book in db.Books.AsNoTracking()
            .Include(book => book.Authors)) 
        {
            if (book != null)
            {
                Console.WriteLine($"{book.Title}");
                if (book.Authors.Count > 0)
                {
                    Console.WriteLine($"{book.Authors.FirstOrDefault().Name}");
                }
            }
            else
                Console.WriteLine("no book was found!");
        }
    }
}
static void AddWithPreExistingAuthor()
{
    using (var db = new AppDbContext())
    {
        var foundAuthor = db.Author.
            SingleOrDefault(author => author.Name == "zahra");
        var book = new Book() { Title = "MyBook"};
        if (foundAuthor != null)
        {
            book.Authors.Add(foundAuthor);
        }
        if (book != null)
        {
            db.Add(book);
        }
        db.SaveChanges();
        ListAll();
    }
}
Console.WriteLine("start");

AddWithPreExistingAuthor();