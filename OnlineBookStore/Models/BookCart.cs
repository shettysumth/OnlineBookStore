using System.Collections.Generic;
using OnlineBookStore.Data;
namespace OnlineBookStore.Models
{
    public class BookCart
    {
        private readonly OnlineBookStoreContext _context;
        public BookCart(OnlineBookStoreContext context)
        {
            _context = context;
        }

        public string Id { get; set; }
        public List<CartItem> cartItems { get; set; }

        //public static CartItem GetCart(IServiceProvider services)
        
          
    }
}
