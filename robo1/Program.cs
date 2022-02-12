using System;
/**
             
-Input:          |- Output esperado:
5 5              |1 3 N 
1 2 N            |5 1 L 
EMEMEMEMM        |
3 3 L            | 
MMDMMDMDDM       |
 
 */
namespace robo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int posicaoX = 3;
            int posicaoY = 3;
            char orientacaoInicial = 'L';
            string comando = "MMDMMDMDDM";
            char[] instrucoes = comando.ToCharArray();


            //Comandos: (E, D, M). E = 90° a esquerda, D = 90° a direita, M = Move pra frente
            for (int i = 0; i < instrucoes.Length; i++)
            {
                if (instrucoes[i] == 'E')
                {
                    if (orientacaoInicial == 'N')
                    {
                        orientacaoInicial = 'O';
                    }
                    else if (orientacaoInicial == 'S')
                    {
                        orientacaoInicial = 'L';
                    }
                    else if (orientacaoInicial == 'L')
                    {
                        orientacaoInicial = 'N';
                    }
                    else if (orientacaoInicial == 'O')
                    {
                        orientacaoInicial = 'S';
                    }
                }
                else if (instrucoes[i] == 'D')
                {
                    if (orientacaoInicial == 'N')
                    {
                        orientacaoInicial = 'L';
                    }
                    else if (orientacaoInicial == 'S')
                    {
                        orientacaoInicial = 'O';
                    }
                    else if (orientacaoInicial == 'L')
                    {
                        orientacaoInicial = 'S';
                    }
                    else if (orientacaoInicial == 'O')
                    {
                        orientacaoInicial = 'N';
                    }
                }
                else if (instrucoes[i] == 'M')
                {
                    if (orientacaoInicial == 'N')
                    {
                        posicaoY++;
                    }
                    else if (orientacaoInicial == 'S')
                    {
                        posicaoY--;
                    }
                    else if (orientacaoInicial == 'L')
                    {
                        posicaoX++;
                    }
                    else if (orientacaoInicial == 'O')
                    {
                        posicaoX--;
                    }
                }

            }
            Console.WriteLine($"-posicao x: {posicaoX}\n-posicao y: {posicaoY}\n-orientação: {orientacaoInicial}");

            Console.ReadLine();
        }
    }
}
