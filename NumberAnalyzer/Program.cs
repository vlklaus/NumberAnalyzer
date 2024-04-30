//How can if statements be used to cover multiple situations? Can you show an example.

/*
example:

if (some condition)
{
 some function
} else if (some other condition)
{
some other function
} else
{
only thing left to do
}

*/




Console.Write("Please enter your name: ");
string name = Console.ReadLine();

bool loop = true;
while (loop)
{
    Console.Write("Please enter an integer between 1 and 100: ");
    int num = int.Parse(Console.ReadLine());

    if (num > 100 || num < 1)
    {
        Console.WriteLine($"{num} isn't in the range. Enter a valid number");
        continue;
    }

    if (num % 2 != 0)
    {
        if (num < 60)
        {
            Console.WriteLine($"{name}, your integer is {num}. It is odd and less than 60");
        }
        else
        {
            Console.WriteLine($"{name}, your integer is {num}: It is odd and greater than 60");
        }
    }
    else
    {
        if (num % 2 == 0)
        {
            if (num < 60)
            {
                Console.WriteLine($"{name}, your integer is {num}. It is even and less than 60");
            }
            else if (num > 60)
            {
                Console.WriteLine($"{name}, your integer is {num}. It is even and greater than 60");
            }
            else if (num >= 2 && num <= 24)
            {
                Console.WriteLine($"{name}, your integer is {num}. It is even and less than 25");
            }
            else
            {
                Console.WriteLine($"{name}, your integer is {num}. It is even and between 26 and 60 inclusive");
            }
        }

    }
    while (true)
    {
        Console.WriteLine("Do you want to enter a new integer? Yes or No ");
        string loopAns = Console.ReadLine().ToLower();
        if (loopAns == "yes") 
        {
            break;
        } else if (loopAns == "no")
        {
            loop = false;
            break;
        } else
        {
            Console.WriteLine("I don't understand. Yes or No?");
        }
    }
}
