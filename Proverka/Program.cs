﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Въведете възрастта си:");
int age = int.Parse(Console.ReadLine());

if (age > 18)
{
    Console.WriteLine("Пълнолетен!");
}
else 
{
    Console.WriteLine("Непълнолетен!");
}

