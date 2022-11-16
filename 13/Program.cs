// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Выполнить с помощью числовых операций 
//  (целочисленное деление, остаток от деления).

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if ( number>99){

Console.WriteLine(ThirdDigit(number));

}
else

Console.Write("Третьей цифры нет ");

int ThirdDigit(int num)
        {int result = 0;
        if (num >99){
            while (num> 999){num = num / 10;}
            result = num % 10;}
            return result;}