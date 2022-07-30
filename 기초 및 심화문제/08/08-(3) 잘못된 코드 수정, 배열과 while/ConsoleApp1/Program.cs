// See https://aka.ms/new-console-template for more information
Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
int friendCount = int.Parse(Console.ReadLine()); 

int[] appleNumbers = new int[friendCount];
int index = 0; // int index = 1; <- 수정
int total = 0; // int total = 0 <- 추가

while (index < friendCount)
{
    Console.Write(index);
    Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
    appleNumbers[index] = int.Parse(Console.ReadLine());    
    total = total + appleNumbers[index];    
    index = index + 1;  // 다음 올 질문을 제시하기 위해서 마지막에 index + 1을 추가했다. 그렇지 않으면 0에서 맴돌게 되기 때문에 코드가 무한반복된다. 따라서 1씩 증가하는 값을 넣어준다. 이 코드를 적으면 index가 friendCound의 값에 달하기 전까지 1이 증가하며 값이 같아지는 순간 while에서 빠져나오게 된다.
}

Console.Write("친구들에게 ");
Console.Write(total);
Console.WriteLine("개의 사과를 나눠줬습니다.");
