
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

    //public int CompoundInterest()
    //{
    //    string principlePromptResult = PromptPrinciple();
    //    int principle = ValidatePrinciple(principlePromptResult);
    //    string interestPromptResult = PromptInterest();
    //    int interest = ValidateInterest(interestPromptResult);
    //    string lengthPromptResult = PromptLength();
    //    int length = ValidateLength(lengthPromptResult);
    //    int result = principle * interest / 100 * length;
    //    return result;
    //}

    public int Calculate()
    {
        string principlePromptResult = PromptPrinciple();
        int principle = ValidatePrinciple(principlePromptResult);
        string interestPromptResult = PromptInterest();
        int interest = ValidateInterest(interestPromptResult);
        string lengthPromptResult = PromptLength();
        int length = ValidateLength(lengthPromptResult);
        int result = principle + (principle * interest / 100 * length);
        //CompoundRound2(principle);
        return result;

    }

    public int CompoundRound2(int principle)
    {
        int total = Calculate();
        int compound = total - principle;
        return compound;
    }
}

class Program
{
    static void Main(string[] args)
    {
        InterestCalc calculator = new();
        //string userInputString = calculator.PromptPrinciple();
        //int userInputNum = calculator.ValidatePrinciple(userInputString);
        //int compoundInterest = calculator.CompoundRound2(userInputNum);
        int total = calculator.Calculate();
        Console.WriteLine($"total after interest: {total}, total compound interest:");
    }
}
