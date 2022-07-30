Console.WriteLine("학생 숫자를 입력하세요.");
int studentNumbers = int.Parse(Console.ReadLine());

int[] KukuhScore = new int[studentNumbers];
int[] EnglishScore = new int[studentNumbers];
int[] Math = new int[studentNumbers];

int number = 0;

while(number < studentNumbers)
{
    Console.Write(number + 1);
    Console.WriteLine("번째 학생의 국어 점수를 입력하세요");
    KukuhScore[number] = int.Parse(Console.ReadLine());

    Console.Write(number + 1);
    Console.WriteLine("번째 학생의 영어 점수를 입력하세요");
    EnglishScore[number] = int.Parse(Console.ReadLine());

    Console.Write(number + 1);
    Console.WriteLine("번째 학생의 국어 점수를 입력하세요");
    Math[number] = int.Parse(Console.ReadLine());

    number = number + 1;    
}

Console.Write("전체 학생의 국어 평균 : ");









