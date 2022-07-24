int coin = 10;
Console.Write("주머니 속 동전의 개수 : ");
Console.WriteLine(coin);    

int aramCoin = (coin / 2);
aramCoin = aramCoin - 1 ;
Console.Write("아람이가 가져간 동전의 개수 : ");
Console.WriteLine(aramCoin);

coin = coin - aramCoin;

int wooCoin = (coin / 2);
wooCoin = wooCoin + 2;
Console.Write("우람이가 가져간 동전의 개수 : ");
Console.WriteLine(wooCoin);

coin = coin - wooCoin;

Console.Write("주머니 속 남은 동전의 개수 : ");
Console.WriteLine(coin) ;

