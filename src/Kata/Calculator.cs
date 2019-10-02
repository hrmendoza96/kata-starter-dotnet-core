using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number = "")
        {
            if(string.IsNullOrEmpty(number))
                return 0;

            char delimiter;
            if (number.StartsWith("//"))
            {
                var newNumberArray = number.Remove(0, 2).Split('\n'); // Removes the first two "//"
                delimiter = Convert.ToChar(newNumberArray[0]);
                newNumberArray = newNumberArray[1].Split(delimiter);
                return newNumberArray.Sum(numberString => int.Parse(numberString));
            }
            
            var numberArray = number.Split(',', '\n').Select(numberString => int.Parse(numberString)).ToArray();
            return numberArray.Sum(); 
            
            

        }
        
        
    }
}