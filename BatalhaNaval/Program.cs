using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BatalhaNaval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            string[,] grade = new string[11, 11];
            string[,] mapasecreto1 = new string[11, 11];
            string tiro = "X";
            
            preencherMatriz(grade);
            mapasecreto(mapasecreto1);
            int pontuacao = 0;
            int qntten = 0;
                                                                
            while (qntten < 5 && pontuacao < 3)
            {
                Console.WriteLine();
                listarMatriz(grade);
                qntten++;
                
                
                Console.WriteLine("Informe linha: ");
                int linha = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe Coluna: ");
                int coluna = int.Parse(Console.ReadLine());
                if (linha > 10 || coluna > 10)
                {
                    Console.Clear();
                    Console.WriteLine("Jogada invalida,Digite novamente: ");
                    continue;
                }
                if (mapasecreto1[linha,coluna] == "N" && grade[linha,coluna] != "N" && grade[linha,coluna] != "X")
                {
                    Console.Clear();
                    Console.WriteLine("Voce fez um ponto");
                    pontuacao++;
                    
                    grade[linha, coluna] = "N";
                    continue;
                }
                else if(mapasecreto1[linha,coluna] == "A" && grade[linha, coluna] != "A" && grade[linha, coluna] != "X")
                {
                    Console.Clear();
                    Console.WriteLine("Voce fez um ponto");
                    pontuacao++;
                    
                    grade[linha, coluna] = "A";
                    continue;
                }
                
              
                if(pontuacao == 3)
                {
                    Console.WriteLine("Voce ganhou");
                    Console.WriteLine($"Sua pontuação é de: {pontuacao}");
                }
                Console.Clear();
            }
            Console.WriteLine("Fim de jogo");
            Console.ReadKey();
        }
       
        
        static void preencherMatriz(string[,] matriz)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = " ";
                }
            }
            

        }
        static void listarMatriz(string[,] matriz)
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9 10 ");
            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                
                Console.WriteLine("==========================");
                Console.Write(linha);
                Console.Write("|");
                for(int coluna = 0;coluna < matriz.GetLength(1); coluna++)
                {
                   
                    Console.Write(matriz[linha,coluna] +"|");
                    
                    
                }
                
                Console.WriteLine();

            }
            Console.WriteLine("==========================");
        }
        static void mapasecreto(string[,] matriz)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = " ";
                }
            }
            //defini posição do navio 01
            Random lin = new Random();
            int linhaNavio1 = lin.Next(0, 10);
            Random col = new Random();
            int colunaNavio1 = col.Next(0, 10);
            matriz[linhaNavio1, colunaNavio1] = "N";
            Console.WriteLine($"barco na linha {linhaNavio1} e coluna {colunaNavio1}:");
            
            //defini posição do navio 02
            Random lin2 = new Random();
            int linhaNavio2 = lin.Next(0, 10);
            Random col2 = new Random();
            int colunaNavio2 = col.Next(0, 10);
            matriz[linhaNavio2, colunaNavio2] = "N";
            Console.WriteLine($"barco na linha {linhaNavio2} e coluna {colunaNavio2}:");
            //defini posição do Avião 01
            Random lin3 = new Random();
            int linhaAviao3 = lin.Next(0, 10);
            Random col3 = new Random();
            int colunaAviao3 = col.Next(0, 10);
            matriz[linhaAviao3, colunaAviao3] = "A";
            Console.WriteLine($"aviao na linha {linhaAviao3} e coluna {colunaAviao3}:");


        }
      
       
    }
}
