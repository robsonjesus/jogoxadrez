using System;
using tabuleiro;
using xadrez;

namespace JogoXadrex {
    class Program {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));

            Tela.imprimirTabuleiro(tab);

        }
    }
}
