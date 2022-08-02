Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
int friendCount = int.Parse(Console.ReadLine()); // 정수형변수 선언 , 인원수 입력

int[] appleNumbers = new int[friendCount];  // 정수형변수 배열생성 , 인원수 만큼의 배열

for(int index=0; index<friendCount; index++)    //배열의 각 자리에 값을 입력
{
    Console.Write(index + 1);
    Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
    appleNumbers[index] = int.Parse(Console.ReadLine()); 
}

for(int index=0; index<friendCount; index++)    //배열의 각 자리에 입력된 값을 출력
{
    Console.Write(index + 1);
    Console.Write("번째 친구가 가져간 사과의 개수는");
    Console.Write(appleNumbers[index]);
    Console.WriteLine("개입니다.");
}
