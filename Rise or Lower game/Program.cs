bool repeat;
do
{

Random random = new Random();
int secretNumber = random.Next(1, 101);
int attempts = 0;
int guess;


Console.WriteLine("Попробуй угадать число от 1 до 100");


bool success = int.TryParse(Console.ReadLine(), out guess);
if (success)
{
    attempts += 1;
}

while (guess != secretNumber)
{
    if (!success)
    {
        Console.WriteLine("Введите допустимое число");
        success = int.TryParse(Console.ReadLine(), out guess);
        if (success)
        {
            attempts += 1;
        }
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
Console.WriteLine($"Количество попыток: {attempts}");
Console.WriteLine("Хотите повторить? (да/нет)");
string input = Console.ReadLine().Trim().ToLower();
repeat = (input == "да" || input == "y");
}
while (repeat);
Console.WriteLine("Программа завершена.");