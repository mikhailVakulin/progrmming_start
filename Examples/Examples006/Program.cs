﻿int numberA = new Random().Next(1,1000);
int numberB = new Random().Next(1,1000);
int numberC = new Random().Next(1,1000);
int numberD = new Random().Next(1,1000);
int numberG = new Random().Next(1,1000);
int numberE = new Random().Next(1,1000);
Console.Write(numberA);
Console.Write(numberB);
Console.Write(numberC);
Console.Write(numberD);
Console.Write(numberG);
Console.WriteLine(numberE);
int max;
max = numberA;
if (numberB>max) max = numberB;
if (numberC>max) max = numberC;
if (numberD>max) max = numberD;
if (numberG>max) max = numberG;
if (numberE>max) max = numberE;
Console.Write(max);
