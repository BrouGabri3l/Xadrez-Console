using System;
using tabuleiro;
using xadrez;
namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos.ToPosicao());
        }
    }
}
