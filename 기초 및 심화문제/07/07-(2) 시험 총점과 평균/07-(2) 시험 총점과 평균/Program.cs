// See https://aka.ms/new-console-template for more information
Console.WriteLine("각 과목의 시험 점수를 입력하세요");

int[] score = new int[5];

Console.WriteLine("국어");
score[0] = int.Parse(Console.ReadLine());

Console.WriteLine("수학");
score[1] = int.Parse(Console.ReadLine());

Console.WriteLine("사회");
score[2] = int.Parse(Console.ReadLine());

Console.WriteLine("과학");
score[3] = int.Parse(Console.ReadLine());

Console.WriteLine("영어");
score[4] = int.Parse(Console.ReadLine());

Console.Write("총점 : ");
Console.WriteLine(score[0] + score[1] + score[2] + score[3] + score[4]);

Console.Write("평균 : ");
Console.WriteLine((score[0] + score[1] + score[2] + score[3] + score[4])/5);








