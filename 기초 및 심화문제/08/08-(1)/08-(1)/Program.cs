int[] scores = new int[5];
int index = 0;

while(index < 5)
{
    Console.Write(index);
    Console.WriteLine("번째 과목의 성적을 입력하세요");
    scores[index] = int.Parse(Console.ReadLine());  
    index = index + 1;  
}

Console.Write("총점은 ");
Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
Console.WriteLine("점입니다.");

