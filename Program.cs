
// 11.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число: {number}");

int numberTwo = (number %100/10);

Console.WriteLine(numberTwo);

//////////////////////////////////////////////////////////////////////////////
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//  является ли этот день выходным.


Console.Write("Введите число:");
 int number = Convert.ToInt32(Console.ReadLine());

 if ( number>=1 && number<=5){
    Console.Write("Будний день");
 }
 if ( number>=6 && number<=7){
    Console.Write("Выходной");
 }
 else {
    Console.Write("Некорректные данные");
 }
