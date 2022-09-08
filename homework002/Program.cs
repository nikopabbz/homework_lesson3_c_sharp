﻿// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
const int XCOORD = 0;
const int YCOORD = 1;
const int ZCOORD = 2;

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] InsertCoords()
{
    int[] temp = new int[3];
    temp[XCOORD] = Prompt("Введите х > ");
    temp[YCOORD] = Prompt("Введите y > ");
    temp[ZCOORD] = Prompt("Введите z > ");
    return temp;
}

double Lenght(int[] firstCoord, int[] secondCoord)
{
    return Math.Sqrt(Math.Pow(firstCoord[XCOORD]-secondCoord[XCOORD], 2) 
    + Math.Pow(firstCoord[YCOORD]-secondCoord[YCOORD], 2)
    + Math.Pow(firstCoord[ZCOORD]-secondCoord[ZCOORD], 2));
}

int[] firstPoint = InsertCoords();
int[] secondPoint = InsertCoords();
System.Console.WriteLine($"Расстояние между точками {Lenght(firstPoint, secondPoint)}");