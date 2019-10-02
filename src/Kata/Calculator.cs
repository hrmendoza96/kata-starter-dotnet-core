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
            if (numberArray.Length > 1)
            {
                int sum = numberArray[0] + numberArray[1];
                return sum;
            }

            return numberArray[0];

        }
        
        
    }
}