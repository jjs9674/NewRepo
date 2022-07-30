// See https://aka.ms/new-console-template for more information
string userInput = "";

while (true)
{
    Console.WriteLine("아무 글자나 입력하세요. 끝내려면 \'끝\'을 입력하세요.");
    userInput = Console.ReadLine();

    if (userInput == "끝")
    {
        Console.WriteLine("종료되었습니다.");
        break;
    }

}

