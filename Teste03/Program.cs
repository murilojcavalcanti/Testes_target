
using Newtonsoft.Json;
using Teste03.Models;
using System.Text.Json;
using System.Text.Json;
using System.Globalization;

//Questão 3:
/*

3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;
*/


//@"C:\Users\Murilo Cavalcanti\Documents\00 Programação\C#\Testes_Target\Teste03\dados.json"

List<VendaDia> faturamento = null;
 

using(StreamReader stream = new StreamReader(@"C:\Users\Murilo Cavalcanti\Documents\00 Programação\C#\Testes_Target\Teste03\dados.json"))
    {
        string jsonString = stream.ReadToEnd();
         faturamento = JsonConvert.DeserializeObject<List<VendaDia>>(jsonString);
    }



double menorFaturamento=double.MaxValue, maiorFaturamento= double.MinValue, mediaFaturamento=0,totalFaturado=0;
int diasFauramentoSuperiorMedia=0,diasComFaturamento=0;

foreach (var dia in faturamento)
{
    if(dia.valor>0)
    {
        if(dia.valor>maiorFaturamento)
        {
            maiorFaturamento=dia.valor;
        }

        if(dia.valor<menorFaturamento)
        {
            menorFaturamento=dia.valor;
        }
        diasComFaturamento++;
        totalFaturado+=dia.valor;
    }
}


    mediaFaturamento= totalFaturado/diasComFaturamento;
    
    foreach (var faturamentodia in faturamento)
    {
       if(faturamentodia.valor>mediaFaturamento){
            diasFauramentoSuperiorMedia++;
        }
    }



System.Console.WriteLine($"Dias com faturamento: {diasComFaturamento}");
System.Console.WriteLine($" faturamento Total : {totalFaturado.ToString("C2")}");
System.Console.WriteLine("==================================");
System.Console.WriteLine($"Maior faturamento: {maiorFaturamento.ToString("C2")}");
System.Console.WriteLine($"Menor faturamento: {menorFaturamento.ToString("C2")}");
System.Console.WriteLine($"========================================");
System.Console.WriteLine($"Media de faturamento: {mediaFaturamento.ToString("C2")}");
System.Console.WriteLine($"Quantidade de dias com faturamento superior a media: {diasFauramentoSuperiorMedia} Dias");
