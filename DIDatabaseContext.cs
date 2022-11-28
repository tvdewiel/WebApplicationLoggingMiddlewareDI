namespace WebApplicationLoggingMiddlewareDI
{
    public class DIDatabaseContext
    {
        static readonly Random _rand=new Random();
        public int RowCount { get; }
        public DIDatabaseContext()
        {
            RowCount=_rand.Next(1,1000);
        }
    }
}
