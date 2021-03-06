﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao =null;
            this.cor = cor;
            this.qteMovimento = 0;
            this.tab = tab;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimento++;
        }
    }
}
