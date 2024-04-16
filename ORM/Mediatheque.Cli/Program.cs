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
            service.AddCd(new Core.Model.CD("Smash", "Offspring"));
            service.AddCd(new Core.Model.CD("Nevermind", "Nirvana"));
            service.AddCd(new Core.Model.CD("Smels Like Teen Spirit", "Nirvana"));

            Console.WriteLine(service.GetCDs());

            service.EditCd(18, "Smells Like Teen Spirit");

            Console.WriteLine(service.GetCdById(10));

            service.DeleteCd(18);

            Console.WriteLine(service.GetCDs());

            Console.WriteLine(service.GetCdsByGroupe("Nirvana"));
        }
    }
}