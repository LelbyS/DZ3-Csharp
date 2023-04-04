Main();

void Main()
{
    bool Working = true;
    while (Working)
    {
        Console.WriteLine("Enter task number or exit");
        string task_number = Console.ReadLine();
        switch(task_number)
        {
            case "1": Task001();
            break;

            case "2": Task002();
            break;

            case "3": Task003();
            break;

            case "exit": Working = false;
            break;

            default: Console.WriteLine("Invalid input. Repeat");
            break;
        }
        
    }
}

// Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом
void Task001()
{

}

void Task002()
{

}

void Task003()
{

}

int IntRead(string argument)
{
    int number;
    Console.WriteLine($"input digit: ");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!!! Try again: ");
    }
    return number;
} 