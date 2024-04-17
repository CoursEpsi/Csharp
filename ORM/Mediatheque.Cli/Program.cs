using Mediatheque.Core.Model;
using Mediatheque.Core.Service;

namespace Mediatheque.Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new Core.DAL.ApplicationDbContext();
            var service = new MediathequeService(null, db);

            /*
            service.AddCd(new CD("Smash", "The Offspring"));
            service.AddCd(new CD("Nevermind", "Nirvana"));
            service.AddCd(new CD("The Wall", "Pink Floyd"));
            service.AddCd(new CD("The Dark Side of the Moon", "Pink Floyd"));

            List<CD> cds = service.GetCDs();
            foreach (CD cd in cds)
            {
                Console.WriteLine(cd.ToString());
            }
            
            service.EditCd(3, "Splinter");

            Console.WriteLine(service.GetCdById(3).ToString());
            
            service.DeleteCd(3);

            List<CD> cds = service.GetCDs();
            foreach (CD cd in cds)
            {
                Console.WriteLine(cd.ToString());
            }
            
            List<CD> cdsPinkFloyd = service.GetCdsByGroupe("Pink Floyd");
            foreach (CD cd in cdsPinkFloyd)
            {
                Console.WriteLine(cd.ToString());
            }
            */
        }
    }
}