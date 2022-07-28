Console.WriteLine("수업을 몇 과목 들었습니까?");
int subjectCount = int.Parse(Console.ReadLine());

int[] scores = new int[subjectCount];
int index = 0;
int total = 0;

while (index < subjectCount)    
{
    Console.Write(index);
    Console.WriteLine("번째 과목의 성적을 입력하세요.");
    scores[index] = int.Parse(Console.ReadLine());
    total = total + scores[index];  
    index = index + 1;  
}

Console.Write("평균은 ");
Console.Write(total / subjectCount);
Console.WriteLine("점입니다.");
