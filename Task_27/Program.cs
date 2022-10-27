/*Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int remains = 0;
int sum = 0;
for (int i = 0; number >= 1; i++)
{
    remains = number%10;
    number = number/10;
    sum += remains;
}
Console.WriteLine(sum);
