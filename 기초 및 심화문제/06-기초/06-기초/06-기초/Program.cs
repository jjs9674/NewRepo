﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("등수를 입력하세요.");
int rank = int.Parse(Console.ReadLine());

Console.WriteLine("점수를 입력하세요.");
int score = int.Parse(Console.ReadLine());  

if (rank <= 10 && score >= 90)
{
    Console.WriteLine("A입니다.");
}

else
{
    Console.WriteLine("A가 아닙니다.");
}