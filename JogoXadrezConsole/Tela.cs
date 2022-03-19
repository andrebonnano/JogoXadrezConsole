using System;
using tabuleiro;

namespace JogoXadrezConsole
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int l = 0; l < tab.linhas; l++)
            {
                Console.Write(8 - l + "  ");
                for (int c = 0; c < tab.colunas; c++)
                {
                    if (tab.peca(l, c) == null)
                    {
                        Console.Write("_ ");
                    }
                    else
                    {
                        Tela.imprimirPeca(tab.peca(l, c));
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("   a b c d e f g h");
            Console.WriteLine();
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor _corOriginal = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = _corOriginal;
            }
        }
    }
}
