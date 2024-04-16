using Mediatheque.Core.Service;

namespace Mediatheque.Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new Core.DAL.ApplicationDbContext();
            var service = new MediathequeService(null, db);

            service.AddCd(new Core.Model.CD("Spice world", "Spice"));
        }
    }
}