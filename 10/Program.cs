//  Напишите программу, которая принимает на вход трёхзначное число и 
//  на выходе показывает вторую цифру этого числа. Выполнить с помощью 
//  числовых операций (целочисленное деление, остаток от деления).

Console.Write("Введите трехзначное число:");
int sekondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(KillSecondDigit(sekondNum));

int KillSecondDigit(int num)
{
    int fitstStep = (num / 10)%10;
    int result = fitstStep;
    return result;
}
