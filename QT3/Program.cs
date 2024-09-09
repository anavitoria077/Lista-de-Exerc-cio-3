/*-------------------------------------------------------------------
Questão 3: Gerenciamento de Inventário com Limite e Tipos de 
Itens
Contextualização
Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua 
quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1. Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no 
inventário.
2. Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3. Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está 
dentro da capacidade máxima, informando se está excedido ou não.
@Lista: 03 - Laçoes de repetição
@Autor: Ana Vitoria
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
  static void Main(string[] args)
  {
    int inventario, itens, quantos, totaldeItens = 0;
    string? nivel;
    
    Console.WriteLine("Quantos tipos diferents de itens você deseja armazenar no inventario? ");
    int.TryParse(Console.ReadLine(), out itens);

    Console.WriteLine("Qual a capacidade maxima no inventario?");
    int.TryParse(Console.ReadLine(), out inventario);
    for (int i = 0; i < itens;i++)
    {
     Console.WriteLine("Informe o nome do item ");
     nivel = Console.ReadLine();

     Console.WriteLine("Informe quantos itens possui ");
     int.TryParse(Console.ReadLine(), out quantos);
     totaldeItens += quantos;
    }
    if(totaldeItens <= inventario )


    {
        Console.WriteLine($"O {totaldeItens} de itens, dentro da capacidade ");
        
            }
    
    else
    {
        Console.WriteLine($"O {totaldeItens} de itens, fora da capacidade");
    }
  

  }
}

