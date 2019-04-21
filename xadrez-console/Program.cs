using System;
using tabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            
            Tela.imprimirTabuleiro(partida.tab);
        }
    }
}
