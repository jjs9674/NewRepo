// See https://aka.ms/new-console-template for more information
Console.WriteLine("주머니에는 동전이 10개 들어 있습니다.");
Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요?");
string number1 = Console.ReadLine();
int momPocket = int.Parse(number1);
Console.WriteLine("아람이는 몇 개의 동전을 꺼냈나요?");
string number2 = Console.ReadLine();
int ahRamCoin = int.Parse(number2);
Console.WriteLine("우람이는 몇 개의 동전을 꺼냈나요?");
string number3 = Console.ReadLine();
int wooRamCoin = int.Parse(number3);

Console.Write("주머니에 남아 있는 동전의 개수는 ");
Console.Write(momPocket - ahRamCoin - wooRamCoin);
Console.WriteLine("입니다.");

