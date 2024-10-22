// See https://aka.ms/new-console-template for more information

// #1
bool yesContinue = true;

do
{

    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue? (yes/no)");
    string response = Console.ReadLine().ToLower();
    if (response != "yes")
    {
        Console.WriteLine("Goodbye!");
        yesContinue = false;
    }
} while (yesContinue == true);


// #2
bool goAgain = true;

while (goAgain == true)
{
    Console.WriteLine("Please enter a number");
    int userNumber = int.Parse(Console.ReadLine());
    for (int i = userNumber; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    for (int j = 0; j <= userNumber; j++)
    {
        Console.WriteLine(j);
    }

    Console.WriteLine("Would you like to continue? (y/n)");
    string userChoice = Console.ReadLine().ToLower();
    if (userChoice != "y")
    {
        goAgain = false;
        Console.WriteLine("Goodbye!");
    }

}
// Keypad Question, #3 and #4
bool doorLocked = true;
int doorCode = 13579;
int guessCounter = 0;

while (doorLocked != false)
{
    Console.WriteLine("Please enter the passcode");
    int userCode = int.Parse(Console.ReadLine());
    if (userCode == doorCode)
    {
        Console.WriteLine("Password correct. Welcome!");
        doorLocked = false;
    }
    else
    {
        guessCounter++;
        Console.WriteLine($"Password incorrect. You have {5 - guessCounter} attempts remaining");
        if (guessCounter == 5)
        {
            Console.WriteLine("There were too many incorrect attempts. Try again later.");
            break;
        }
    }
}

// Keypad Question #5, using variables from previous question.

do
{
    Console.WriteLine("Please enter the passcode");
    int userCode = int.Parse(Console.ReadLine());
    if (userCode == doorCode)
    {
        Console.WriteLine("Password correct. Welcome!");
        doorLocked = false;
    }
    else
    {
        guessCounter++;
        Console.WriteLine($"Password incorrect. You have {5 - guessCounter} attempts remaining");
        if (guessCounter == 5)
        {
            Console.WriteLine("There were too many incorrect attempts. Try again later.");
            break;
        }
    }
} while (doorLocked);
