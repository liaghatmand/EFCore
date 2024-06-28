using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreInAction.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string publisher { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime PublishedOn { get; set; }
        public int AuthorId { get; set; }
        public PriceOffer? Promotion { get; set; }
        public required Author Author { get; set; }
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
