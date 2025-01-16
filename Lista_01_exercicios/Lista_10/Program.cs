/*10. Cálculo do Desconto
o Objetivo: Aplicar condições para cálculos.
o Descrição: Escreva um programa que peça o valor de uma compra e
verifique se o valor é maior que 100. Se sim, aplique um desconto de 10%
no valor e mostre o valor final. Caso contrário, exiba o valor original.
o Exemplo de Saída: "Valor com desconto: [valor final]." ou "Valor original:
[valor]*/

Console.WriteLine("Valor dá compra");
double valor = double.Parse(Console.ReadLine());

if (valor > 100)
{
    double desconto = valor * 0.10;
    double valorfinal = valor - desconto;
    Console.WriteLine("Valor com desconto: " + valorfinal);
}
else
{
    Console.WriteLine("valor original: " + valor);
}