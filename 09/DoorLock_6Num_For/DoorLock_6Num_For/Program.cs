int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };  //정수형 배열 - 비밀번호 값 생성
//int[] userInput = new int[6];

int passcodeLength = 6;                        //정수형 변수 선언
int[] userInput = new int[passcodeLength];     //정수형 배열 선언 - passcodeLength 값 만큼의 배열을 만든다. 사용자 입력값을 받기위한 변수

while (true)
{
    for(int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++) 
    {
        Console.Write(passcodeIndex);
        Console.WriteLine("번째 숫자를 넣어주세요.");
        userInput[passcodeIndex] = int.Parse(Console.ReadLine());    //passcodeIndex번째의 입력값을 받고 배열에 저장한다.
    }

    bool isPasswordCorrect = true;
    for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
    {
        if (userInput[passcodeIndex] != passcodeNumbers[passcodeIndex])     // 유저가 받은 첫번째 배열의 값과 passcodeNumbers의 첫번째 배열의 값을 비교하고 틀리면 조건문을 실행한다.
        {
            isPasswordCorrect = false;
            Console.WriteLine("비밀번호가 틀렸습니다.");
            break;
        }
    }
    if(isPasswordCorrect)         //유저가 받은 값이 참인 경우 조건문을 실행한다.
    {
        Console.WriteLine("문이 열렸습니다.");
        break;
    }
}