// See https://aka.ms/new-console-template for more information
using System;

namespace Consolewrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WriteLine을 쓰면");
            Console.WriteLine("한줄씩 나옵니다.");
            Console.Write("Write는 아닙니다.");
            Console.Write("이어져서 나오죠?");
            Console.WriteLine("Write뒤에 WriteLine을 썼습니다.");

            Console.Write("바구니 안에 담긴 사과의 개수: ");
            Console.WriteLine("12");

            Console.Write("사과 바구니의 무게: ");
            Console.WriteLine("3.12");

            Console.WriteLine("!!?%$&");

            Console.WriteLine("큰 따옴표\" 출력"); //큰따옴표를 출력
            Console.WriteLine("\\\'\"");
        }
    }
}
