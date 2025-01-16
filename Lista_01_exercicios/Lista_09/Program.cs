/*9. Dia da Semana (usando if-else)
o Objetivo: Praticar a utilização de múltiplas condições com if, else if e else.
o Descrição: Desenvolva um programa que peça um número de 1 a 7 e exiba
o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira",
etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de
erro.
o Exemplo de Saída: "Domingo", "Segunda-feira", etc., ou "Número inválido.
Digite um número de 1 a 7."*/

Console.WriteLine("Digite um número de 1 a 7");
int num1 = int.Parse(Console.ReadLine());


if (num1 == 1)
{
    Console.WriteLine("Domingo");
}
else if (num1 == 2)
{
    Console.WriteLine("Segunda");
}
else if (num1 == 3)
{
    Console.WriteLine("Terça");
}
else if (num1 == 4)
{
    Console.WriteLine("Quarta");
}
else if (num1 == 5)
{
    Console.WriteLine("Quinta");
}
else if (num1 == 6)
{
    Console.WriteLine("Sexta");
}
else if (num1 == 7)
{
    Console.WriteLine("Sábado");
}
else
{
    Console.WriteLine("Digite de 1 a 7");
}
