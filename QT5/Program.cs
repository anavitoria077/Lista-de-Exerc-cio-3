/*-------------------------------------------------------------------
Questão 5: Sistema de Recompensas Diárias com Limites e Bônus
Contextualização
Em um jogo online, os jogadores ganham recompensas diárias por logarem consecutivamente. 
A cada dia consecutivo, o valor da recompensa aumenta, mas há um limite diário. Além disso, 
se o jogador atingir certos marcos de dias, recebe bônus adicionais.
Comando
Crie um programa em C# que:
1. Pergunte ao jogador por quantos dias consecutivos ele logou no jogo.
2. Pergunte qual é a recompensa inicial em moedas no primeiro dia.
3. Pergunte qual é o incremento da recompensa a cada dia consecutivo.
4. (Opcional) Pergunte se o jogador deseja considerar bônus por marcos de dias 
(Sim/Não). Se sim, pergunte a cada quantos dias consecutivos há um bônus e qual o 
valor do bônus.
O programa deve calcular e exibir o total de moedas acumuladas pelo jogador, incluindo os 
bônus se aplicável.
Observações:
• Sem considerar bônus (Input 4 = Não): Apenas soma das recompensas diárias.
• Considerando bônus (Input 4 = Sim): Além da soma das recompensas diárias, 
adiciona o bônus a cada marco alcançado.
@Lista: 03 - Laçoes de repetição
@Autor: Ana Vitoria
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        string? diabonus;
        int dia, pontosdia, valor = 0, diaconsecutivo = 0, bonus = 0, final1 = 0, final2 = 0, final3 = 0;

        Console.WriteLine("Quantos dias consecutivo você jogou?");
        int.TryParse(Console.ReadLine(), out dia);

        Console.WriteLine("Qual é a recompensa inicial em moedas no primeiro dia?");
        int.TryParse(Console.ReadLine(), out pontosdia);


        Console.WriteLine("Qual é a recompensa a cada dia consecutivo?");
        int.TryParse(Console.ReadLine(), out diaconsecutivo);

        Console.WriteLine("Deseja considerar bônus por marcos de dias (Sim/Não)?");
        diabonus = Console.ReadLine();
    if (diabonus == "Sim")
        {
            Console.WriteLine("Qual o valor do bonus");
            int.TryParse(Console.ReadLine(), out valor);
            Console.WriteLine("Quantos dias consecutivos há um bônus?");
            int.TryParse(Console.ReadLine(), out bonus);
        }
        final3 =  bonus * valor;
 
        final1= dia*diaconsecutivo;
        final2= final1 + pontosdia + final3;

        Console.WriteLine($"Você ganhou {final2} moedas.");
    }


}


