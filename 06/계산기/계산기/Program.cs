// See https://aka.ms/new-console-template for more information
Console.WriteLine("첫 번째 숫자를 입력하세요.");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("두 번째 숫자를 입력하세요.");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("연산자를 입력하세요.");
string inputOperator = Console.ReadLine();

Console.Write(number1);
Console.Write(inputOperator);
Console.Write(number2);
Console.Write(" = ");
//Console.WriteLine(number1 inputOperator number2);

if (inputOperator == "+")
{
    Console.WriteLine(number1 + number2);
}

if (inputOperator == "-") 
{
    Console.WriteLine(number1 - number2);
}

if (inputOperator == "*")
{
    Console.WriteLine(number1 + number2);
}

if(inputOperator == "/")
{
    Console.WriteLine(number1 / number2);   
}