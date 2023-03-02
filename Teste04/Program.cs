using Teste04.Models;

//Questão 4:
/* Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual
 de representação que cada estado teve dentro do valor total mensal da distribuidora. 
*/


double faturamentoSP=67836.43,faturamentoRJ=36678.66,faturamentoMG=29229.88,faturamentoES=27165.48,faturamentoOutros=19849.53;
double total=faturamentoSP+faturamentoRJ+faturamentoMG+faturamentoES+faturamentoOutros;
metodos m = new metodos();
System.Console.WriteLine("Percentual de São Paulo");
m.CalcularPercentual(total,faturamentoSP);

System.Console.WriteLine("Percentual de Rio De Janeiro");
m.CalcularPercentual(total,faturamentoRJ);

System.Console.WriteLine("Percentual de Minas Gerais");
m.CalcularPercentual(total,faturamentoMG);

System.Console.WriteLine("Percentual de Espirito Santo");
m.CalcularPercentual(total,faturamentoES);

System.Console.WriteLine("Percentual de Outros");
m.CalcularPercentual(total,faturamentoOutros);
