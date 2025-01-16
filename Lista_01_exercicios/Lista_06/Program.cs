/*6. Classificação de Notas
o Objetivo: Aprender a usar múltiplas condições em uma estrutura de
decisão.
o Descrição: Crie um programa que peça a nota de um aluno e classifique a
nota em categorias: "Excelente" (nota >= 9), "Boa" (7 <= nota < 9), "Regular"
(5 <= nota < 7) e "Baixa" (nota < 5). Exiba a classificação na tela.
o Exemplo de Saída: "Excelente", "Boa", "Regular" ou "Baixa".*/

Console.WriteLine("Digite a Nota");
float num1 = float.Parse(Console.ReadLine());

if (num1 >= 9)
{
    Console.WriteLine("Excelente");
}
else if (num1 < 9 && num1 >= 7)
{
    Console.WriteLine("Boa");
}
else if (num1 < 7 && num1 >= 6)
{
    Console.WriteLine("Regular");
}
else if (num1 < 6)
{
    Console.WriteLine("Baixa");
}