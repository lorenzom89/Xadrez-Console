using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            QteMovimentos++;
        }
    }
}
