// See https://aka.ms/new-console-template for more information
int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };
int[] userInput = new int[6];
int passCodeIndex = 0;  

while (passCodeIndex <= 5)
{
    Console.Write(passCodeIndex + 1);   
    Console.WriteLine( "번째 숫자를 넣어주세요.");
    userInput[0] = int.Parse(Console.ReadLine());
    passCodeIndex = passCodeIndex + 1;

    {
        if (userInput[0] == passcodeNumbers[0] && userInput[1] == passcodeNumbers[1] && userInput[2] == passcodeNumbers[2] && userInput[3] == passcodeNumbers[3] && userInput[4] == passcodeNumbers[4] && userInput[5] == passcodeNumbers[5])
        {
            Console.WriteLine("문이 열렸습니다.");
            break;
        }

        else
        {
            Console.WriteLine("비밀번호가 틀렸습니다.");
        }
    }
}
