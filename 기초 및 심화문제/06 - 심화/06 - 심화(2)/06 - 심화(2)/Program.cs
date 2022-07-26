// See https://aka.ms/new-console-template for more information
Console.WriteLine("21, 24, 27, 30을 입력해보세요.");
int userInput = int.Parse(Console.ReadLine());  
if (userInput >= 3 && userInput %3 == 0)
{
    Console.WriteLine("20보다 큰 3의 배수입니다.");
}

