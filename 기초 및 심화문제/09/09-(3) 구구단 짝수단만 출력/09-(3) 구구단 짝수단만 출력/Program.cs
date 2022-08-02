for (int i = 2; i <= 8; i = i + 2) // i를 2만큼 증가시키려면 i = i + 2를 사용
{
    Console.Write(i);
    Console.WriteLine("단");
    for (int j = 1; j <= 9; j++)
    {
        Console.Write(i);
        Console.Write("x");
        Console.Write(j);
        Console.Write("=");
        Console.Write(i * j);
        Console.Write(" ");
    }
    Console.WriteLine();
}