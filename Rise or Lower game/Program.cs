Random random = new Random();
int secretNumber = random.Next(1, 101);
int attempts = 1;
int guess;


Console.WriteLine("Попробуй угадать число от 1 до 100");


bool success = int.TryParse(Console.ReadLine(), out guess);
while (guess != secretNumber)
{
    if (!success)
    {
        Console.WriteLine("Введите число");
        success = int.TryParse(Console.ReadLine(), out guess);
    }

    else
    {
        if (guess > secretNumber)
        {
            Console.WriteLine("Попробуй меньше");
            success = int.TryParse(Console.ReadLine(), out guess);
            if (success)
            {
                attempts += 1;
            }
        }

        else if (guess < secretNumber)
        {
            Console.WriteLine("Попробуй больше");
            success = int.TryParse(Console.ReadLine(), out guess);
            if (success)
            {
                attempts += 1;
            }
        }
    }
}
Console.WriteLine("Ты угадал");