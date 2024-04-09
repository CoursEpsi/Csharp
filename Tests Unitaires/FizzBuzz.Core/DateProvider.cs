namespace FizzBuzz.Core
{
    public class DateProvider : IDateProvider
    {
        public DateTime GetNow()
        {
            return DateTime.Now;
        }
    }
}