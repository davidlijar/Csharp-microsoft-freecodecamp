public class CodeProject1
{

    public void Func()
    {
        string? inputVal;
        int inputInt;
        bool validInt = false;
        bool isStop = false;

        do
        {
            Console.WriteLine("Input between 5 and 10:");

            inputVal = Console.ReadLine();
            validInt = int.TryParse(inputVal, out inputInt);
            if (validInt)
            {
                if (inputInt < 5 || inputInt > 10)
                {
                    Console.WriteLine($"You entered {inputVal}. Please enter a number between 5 and 10.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Your input value {inputInt} has been accepted");
                    isStop = true;
                }
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again");
            }
        } while (isStop == false);
    }

}