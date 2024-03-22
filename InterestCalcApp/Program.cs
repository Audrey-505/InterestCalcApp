
using System.Text.RegularExpressions;

namespace InterestCalcApp
{

    public class InterestCalc
    {
        public int principle;
        public int interest;
        public int length;

        public void PromptValues()
        {
            try
            {
                principle = Prompt("principle");
                interest = Prompt("interest");
                length = Prompt("length of rate in years");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                PromptValues();
            }
        }

        public static int Prompt(string promptMessage)
        {
            Console.WriteLine($"Please enter {promptMessage} amount");
            string? response = Console.ReadLine();
            return Validate(response);
        }

        public static int Validate(string userInput)
        {
            if (!string.IsNullOrEmpty(userInput) && userInput.All(char.IsDigit))
            {
                return int.Parse(userInput);
            }
            throw new ArgumentException("Invalid input. Please enter a valid number value.");
        }

        public int Calculate()
        {
            int result = principle + (principle * interest / 100 * length);
            return result;

        }

        public int CompoundInterest()
        {
            int compound = Calculate() - principle;
            return compound;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InterestCalc calculator = new();
            calculator.PromptValues();
            int total = calculator.Calculate();
            int compoundInterest = calculator.CompoundInterest();
            Console.WriteLine($"total compound interest: {compoundInterest}, total after interest: {total}");
        }
    }
}
