using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number = "")
        {
            if(string.IsNullOrEmpty(number))
                return 0;

            var numberArray = number.Split(',').Select(numberString => int.Parse(numberString)).ToArray();
            return numberArray.Sum();

        }
        
        
    }
}