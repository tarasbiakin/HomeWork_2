// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Выполнить с помощью числовых операций 
//  (целочисленное деление, остаток от деления).

Console.Write("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1>99){
Console.WriteLine(KillDigit(num1));

int KillDigit(int num)
{
    int fitstStep = (num % 10);
    int result = fitstStep;
    return result;
   }
}
else if(num1>999){
Console.WriteLine(KillDigit(num1));

int KillDigit(int num)
{
    int fitstStep = (num % 100);
    int result = fitstStep;
    return result;
   }
}


else
Console.Write("Третьей цифры нет ");