using OnlineBookStore.Data;

namespace OnlineBookStore.Models
{
    public class Cart
    {
        private readonly OnlineBookStoreContext _context;

        public Cart(OnlineBookStoreContext context)
        {
            _context = context;
        }   

        public string Id { get; set; }

        public List<CartItem> Items { get; set; }   

        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context=services.GetService<OnlineBookStoreContext>();
            string cartId=session.GetString(key:"Id") ?? Guid.NewGuid().ToString();

            session.SetString(key:"Id", value:cartId);
            return new Cart(context) { Id = cartId };
        }

       // public List<CartItem> GetAllCartItem()
       
    }
}
