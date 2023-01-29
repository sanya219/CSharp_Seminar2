//Задача 1
/* 
int MaxNumber (int number)
{
    int number1 = number / 10;
    int number2 = number % 10;
    int result;
    if (number1 > number2)
        result = number1;
    else    
        result = number2;
    return result;
}

int number = new Random().Next(10,100);
Console.WriteLine("Maximal number is " + MaxNumber(number));
*/
//Задача 2
/*
bool IsDivisible (int number1, int number2)
{
    return ((number2 % number1) == 0);
}

Console.Write("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsDivisible(number1, number2));
*/
//Задача 3
bool IsSquare (int number1, int number2)
{
    return (number1 == number2 * number2 || number2 == number1 * number1);    
}

Console.Write("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsSquare(number1, number2));
