// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Tables of 5");
int num = 5;
for(int i=1; i<10; i++)
{
    Console.WriteLine("{0} * {1} = {2}", num, i, (num * i)); 
}