
// 4.4 Searching an array using a loop
// Using a while loop to search an array for a specific element. 

class Program
{
    static void Main(string[] args)
    {
        int[] validId = { 10, 20, 30, 40 };
        int userInput;
        bool isValid = false;
        int count = 0;

        Console.WriteLine("Please enter your valid ID number below: ");
        userInput = Convert.ToInt32(Console.ReadLine());

        while (count < validId.Length && userInput != validId[count])
            count++;
        if (count != validId.Length)
        {
            isValid = true;
        }
        if (isValid)
        {
            Console.WriteLine("The ID number {0} is valid.", userInput); 
        }
        else
        {
            Console.WriteLine("The ID number {0} is not valid, sorry!", userInput);
        }
    }
}