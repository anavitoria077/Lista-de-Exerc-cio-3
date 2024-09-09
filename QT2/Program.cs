/*-------------------------------------------------------------------
Questão 2: Cálculo de Pontuação por Missão com Níveis de Dificuldade
Contextualização:
Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade. Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando:
Desenvolva um programa em C# que:
1.
Pergunte ao jogador quantas missões ele completou.
2.
Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3.
Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
•
Fácil: 50 pontos por inimigo
•
Médio: 100 pontos por inimigo
•
Difícil: 150 pontos por inimigo
O programa deve calcular e exibir a pontuação total acumulada pelo jogador
@Lista: 03 - Laços de Repetição
@Autor: Ana Vitoria 
@Data: 03/09/2024
---------------------------------------------------------------------*/

using System;
using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args)
    {
        string? nivel;
       int missao,inimigo,final =0, final1 =0, final2 =0, final3 =0;

    Console.WriteLine("Quantas missões você completou?");
    int.TryParse(Console.ReadLine(), out missao);
    for (int i = 0; i < missao; i++)
    {

    Console.WriteLine("Qual o nivel de dificuldade pra cada missão? ");
    nivel = Console.ReadLine();
    if (nivel == "facil")
 {
                Console.WriteLine("Quantos inimigos você derrotados nessa missão?");
                int.TryParse(Console.ReadLine(), out inimigo);
                final = 50 * inimigo;
            }
         else if (nivel == "medio")
            {

         Console.WriteLine("Quantos inimigos você derrotados nessa missão?");
                int.TryParse(Console.ReadLine(), out inimigo);
                final1 = 100 * inimigo;
            }
            else if (nivel == "dificil")
            {
                Console.WriteLine("Quantos inimigos você derrotados nessa missão?");
                int.TryParse(Console.ReadLine(), out inimigo);
                final2 = 150 * inimigo;
            }
             final3= final + final1 + final2;

            }
    Console.WriteLine($"A sua pontuação total é {final3}");
    }
   
    
    }
