
namespace InterestCalcApp;

public class InterestCalc
{
    public int principle;
    public int interest;
    public int length;

    public void PromptValues()
    {
        PromptPrinciple();
        PromptInterest();
        PromptLength();
    }

    public string PromptPrinciple()
    {
        Console.WriteLine("Please enter principle amount");
        string response = Console.ReadLine();
        principle = ValidatePrinciple(response);
        return response;
    }

    public string PromptInterest()
    {
        Console.WriteLine("Please enter interest amount");
        string response = Console.ReadLine();
        interest = ValidateInterest(response);
        return response;
    }

    public string PromptLength()
    {
        Console.WriteLine("Please enter the length of rate in years");
        string response = Console.ReadLine();
        length = ValidateLength(response);
        return response;
    }

    public int ValidatePrinciple(string UserInput)
    {
        if (!string.IsNullOrEmpty(UserInput) && UserInput.All(char.IsDigit))
        {
            int value = int.Parse(UserInput);
            return value;
        }
        Console.WriteLine("Invalid input please enter a number value");
        return 0;
    }

    public int ValidateInterest(string UserInput)
    {
        if (!string.IsNullOrEmpty(UserInput) && UserInput.All(char.IsDigit))
        {
            int value = int.Parse(UserInput);
            return value;
        }
        Console.WriteLine("Invalid input please enter a number value");
        return 0;
    }

    public int ValidateLength(string UserInput)
    {
        if (!string.IsNullOrEmpty(UserInput) && UserInput.All(char.IsDigit))
        {
            int value = int.Parse(UserInput);
            return value;
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
