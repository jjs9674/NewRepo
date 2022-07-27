Console.WriteLine("학생 숫자를 입력하세요.");
int studentCount = int.Parse(Console.ReadLine());

int[] ages = new int[studentCount];
string[] names = new string[studentCount];
double[] height = new double[studentCount];
double[] weight = new double[studentCount];

Console.WriteLine("몇 번째 학생의 정보를 추가할까요?");
int studentNumber = int.Parse(Console.ReadLine());

if (studentNumber >= 0 && studentNumber <= studentCount - 1)

{
    Console.WriteLine("나이를 입력하세요.");
    ages[studentNumber] = int.Parse(Console.ReadLine());

    Console.WriteLine("이름을 입력하세요.");
    names[studentNumber] = Console.ReadLine();

    Console.WriteLine("키를 입력하세요.");
    height[studentNumber] = double.Parse(Console.ReadLine());

    Console.WriteLine("몸무게를 입력하세요.")
    weight[studentNumber] = double.Parse(Console.ReadLine());

    Console.Write(studentNumber);
    Console.WriteLine("번째 학생");
    Console.Write("이름: ");
    Console.WriteLine(names[studentNumber]);
    Console.Write("키: ");
    Console.WriteLine(height[studentNumber]);
    Console.Write("나이");
    Console.WriteLine(ages[studentNumber]);
    Console.Write("몸무게")
    Console.WriteLine(weight[studentNumber]);
}

else
{
    Console.Write("0에서 ");
    Console.Write(studentCount - 1);
    Console.WriteLine("사이의 숫자를 입력하세요.");
}