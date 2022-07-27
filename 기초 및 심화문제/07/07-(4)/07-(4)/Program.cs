string[] subjects = { "국어", "영어", "수학" };
int[] score = new int[3];

Console.Write(subjects[0]);
Console.WriteLine(" 점수를 입력하세요.");
score[0] = int.Parse(Console.ReadLine());

Console.Write(subjects[1]);
Console.WriteLine(" 점수를 입력하세요.");
score[1] = int.Parse(Console.ReadLine());

Console.Write(subjects[2]);
Console.WriteLine(" 점수를 입력하세요.");
score[2] = int.Parse(Console.ReadLine());

Console.Write(subjects[0]);
Console.Write(" 점수: ");
Console.WriteLine(score[0]);

Console.Write(subjects[1]);
Console.Write(" 점수: ");
Console.WriteLine(score[1]);

Console.Write(subjects[2]);
Console.Write(" 점수: ");
Console.WriteLine(score[2]);





