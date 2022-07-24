// See https://aka.ms/new-console-template for more information
Console.WriteLine("첫 번째 숫자를 입력하세요.");
string userInput1 = Console.ReadLine();
int number1 = int.Parse(userInput1);
Console.WriteLine("두 번째 숫자를 입력하세요.");
string userInput2 = Console.ReadLine();
int number2 = int.Parse(userInput2);
Console.Write(number1);
Console.Write(" + ");
Console.Write(number2);
Console.Write(" = ");
Console.WriteLine(number1 + number2);

