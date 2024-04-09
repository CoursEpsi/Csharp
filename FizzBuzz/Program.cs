using FizzBuzz.Core;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(worker.GetFizzBuzz(i));
            }

            Console.WriteLine("Entrez votre date de naissance :");
            string input = Console.ReadLine();
            var dateNaissance = DateTime.Parse(input);
            var ageCalculator = new AgeCalculator(new DateProvider());
            Console.WriteLine($"Vous avez {ageCalculator.GetAge(dateNaissance)} ans.");
        }
    }
}
