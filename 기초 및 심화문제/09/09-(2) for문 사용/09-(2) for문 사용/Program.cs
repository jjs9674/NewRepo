int[] score = new int[5];
for(int i=0; i<5; i++)
{
    Console.Write(i + 1);
    Console.WriteLine("번째 과목의 성적을 입력하세요.");
    score[i] = int.Parse(Console.ReadLine());
}

Console.Write("총점은 ");
int sum = score.Sum(); //배열의 합
Console.Write(sum);
Console.WriteLine("점입니다.");
