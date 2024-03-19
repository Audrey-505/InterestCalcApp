
namespace InterestCalcApp;

public class InterestCalc
{
    public string PromptPrinciple()
    {
        Console.WriteLine("Please enter principle amount");
        string response = Console.ReadLine();
        ValidatePrinciple(response);
        return response;
    }

    public string PromptInterest()
    {
        Console.WriteLine("Please enter interest amount");
        string response = Console.ReadLine();
        ValidateInterest(response);
        return response;
    }

    public string PromptLength()
    {
        Console.WriteLine("Please enter the length of rate in years");
        string response = Console.ReadLine();
        ValidateLength(response);
        return response;
    }

    public int ValidatePrinciple(string UserInput)
    {
        //string principle = PromptPrinciple();
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
        //string interest = PromptInterest();
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
        //string length = PromptLength();
        if (!string.IsNullOrEmpty(UserInput) && UserInput.All(char.IsDigit))
        {
            int value = int.Parse(UserInput);
            return value;
        }
        Console.WriteLine("Invalid input please enter a number value");
        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        InterestCalc calculator = new();
        string principle = calculator.PromptPrinciple();

        Console.WriteLine($"Entered principle amount: {principle}");
    }
}
