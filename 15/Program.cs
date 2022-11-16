//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число:");
int day = Convert.ToInt32(Console.ReadLine());

if ((day<8)&&(day>0)){
Console.WriteLine(Square(day) ? "выходной" : "рабочий");

bool Square (int dau1)
{
    return (day<8)&&(day>5);}
}
else
{
    Console.WriteLine($"Такого дня нет");
    
}
