
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
            principle = Prompt("principle");
            interest = Prompt("interest");
            length = Prompt("length of rate in years");
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
            Console.WriteLine("Invalid input please enter a number value");
            return 0;
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
