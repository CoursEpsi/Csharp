using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public class AgeCalculator
    {
        public AgeCalculator(IDateProvider dateProvider)
        {
            DateProvider = dateProvider;
        }

        public IDateProvider DateProvider { get; set; }

        public int GetAge(DateTime dateNaissance)
        {
            var dateTimeNow = DateProvider.GetNow();
            var nombreAnnees = dateTimeNow.Year - dateNaissance.Year;

            if (dateTimeNow.Month < dateNaissance.Month || (dateTimeNow.Month == dateNaissance.Month && dateTimeNow.Day < dateNaissance.Day))
            {
                nombreAnnees--;
            }
            return nombreAnnees;
        }
    }
}
