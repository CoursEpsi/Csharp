namespace FizzBuzz.Core
{
    public class Worker
    {
        const string FIZZ = "Fizz";
        const string BUZZ = "Buzz";
        public string GetFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return FIZZ + BUZZ;
            }
            if (number % 3 == 0)
            {
                return FIZZ;
            }
            if (number % 5 == 0)
            {
                return BUZZ;
            }
            return number.ToString();
        }
    }
}
