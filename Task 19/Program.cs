/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите любое пятизначное число");
int num = int.Parse(Console.ReadLine());
while (num>99999 || num<=9999)
{
    Console.WriteLine("Вы ввели некорректное число");
    return;
}

if (num/10000==num%10 && num/1000%10==num/10%10)
{
Console.WriteLine("Да");}
else 
{
    Console.WriteLine("Нет");
}


