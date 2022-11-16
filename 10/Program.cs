//  Напишите программу, которая принимает на вход трёхзначное число и 
//  на выходе показывает вторую цифру этого числа. Выполнить с помощью 
//  числовых операций (целочисленное деление, остаток от деления).

Console.Write("Введите трехзначное число:");
int sekondNum = Convert.ToInt32(Console.ReadLine());

if((sekondNum>99)&&(sekondNum<1000)){
Console.WriteLine(KillDigit(sekondNum));

int KillDigit(int num)
{
    int fitstStep = (num / 10)%10;
    int result = fitstStep;
    return result;
}

}else
Console.Write("Вы ввели не то число:");
if (sekondNum<0){
   Console.Write("число отрицательное"); 
}
 