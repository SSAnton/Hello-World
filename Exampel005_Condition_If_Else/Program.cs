﻿Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") 
{
   Console.WriteLine("Ура, это Маша!");
}
else
{
    Console.Write("Приыет,  ");
    Console.WriteLine(username);
}
