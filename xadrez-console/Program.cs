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
            while (!partida.terminada)
            {

                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);
                Console.WriteLine();
                Console.WriteLine("Turno: " + partida.turno);
                Console.WriteLine("Esperando jogada de: " + partida.jogadorAtual);

                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                bool[,] posicoesPossiveis = partida.tab.Peca(origem).movimentosPossiveis();

                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                Console.WriteLine();
                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                partida.realizaJogada(origem, destino);
            }

        }
    }
}
