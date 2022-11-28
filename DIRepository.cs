namespace WebApplicationLoggingMiddlewareDI
{
    public class DIRepository
    {
        private readonly DIDatabaseContext _context;

        public DIRepository(DIDatabaseContext context)
        {
            _context = context;
        }

        public int RowCount => _context.RowCount;

    }
}
