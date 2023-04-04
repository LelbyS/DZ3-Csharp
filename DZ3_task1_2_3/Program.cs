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
    int Polyndrom = IntRead("five digit number");

    if (FiveDigit(Polyndrom))
    {
        if (Polyndrom/1000 == ((Polyndrom%100)/10 + (Polyndrom%10)*10)) Console.WriteLine("It's polyndrom");
        else Console.WriteLine("It's not polyndrom");
    }
}

bool FiveDigit(int number)
{
    if (number > 9999 && number < 100000)
    {
        return true;
    }
    Console.WriteLine("It's not five digit number");
    return false;
}

// Напишите программу которая на вход принимает координаты двух точек и находит их расстояние между ними в 3D пространстве
void Task002()
{
    int x1 = IntRead("x1");
    int y1 = IntRead("y1");
    int z1 = IntRead("z1");
    int x2 = IntRead("x2");
    int y2 = IntRead("y2");
    int z2 = IntRead("z2");

    double result = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));

    Console.WriteLine($"Cut length: {result}");
}

// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N
void Task003()
{ 
    int N = IntRead("N");
    double resault = 1;

    for (int i = 1; i <= N; i++)
    {
        resault = Math.Pow(i, 3);
        Console.Write(resault+" ");
    }
    Console.WriteLine();
}

int IntRead(string argument)
{
    int number;
    Console.WriteLine($"input {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!!! Try again: ");
    }
    return number;
} 