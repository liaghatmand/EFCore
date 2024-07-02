using EFCoreInAction;
using EFCoreInAction.Data;
using Microsoft.EntityFrameworkCore;

static void ListAll() 
{
    using (var db = new AppDbContext())
    {
        foreach (var book in db.Books.AsNoTracking()
            .Include(book => book.Reviews)) 
        {
            foreach (var review in book.Reviews) 
            {
                var user = review.UserName;
                var star = review.NumStars;
                var Comment = review.Comment;
                Console.WriteLine($"user = {user}, star = {star}, Comment = {Comment}");
            }
            
        }
    }
}
static void AddReview()
{
    using (var db = new AppDbContext())
    {
        var book = new Book
        {
            Reviews = new List<Review>
            {
                new Review
                {
                    NumStars = 1,
                    UserName = "Liaghatmand",
                    Comment = "Great Book!"
                }
            }
        };
        db.Add(book);
        db.SaveChanges();
        ListAll();
    }
}
Console.WriteLine("start");
ListAll();
AddReview();