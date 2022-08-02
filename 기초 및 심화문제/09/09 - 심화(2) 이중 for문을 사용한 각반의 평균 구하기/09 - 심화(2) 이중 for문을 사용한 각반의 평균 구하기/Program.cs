int classCount = 5;
int studentCount = 10;
double[] classScores = new double[classCount]; 

for (int i = 0; i < classCount; i++)
{
    Console.Write("3학년 ");
    Console.Write(i + 1);
    Console.WriteLine("반 성적을 입력합니다.");

    for (int j=0; j < studentCount; j++)
    {
        Console.Write(j + 1);
        Console.WriteLine("번째 학생의 성적을 입력해주세요.");
        classScores[i] = classScores[i] + double.Parse(Console.ReadLine()); 
    }

}

for (int i = 0; i < studentCount; i++)
{
    Console.Write("3학년 ");
    Console.Write(i + 1);
    Console.Write("반의 평균: ");
    Console.WriteLine(classScores[i] / studentCount);
}