using System;

//Qustão 2:
/*
 Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
 (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, 
 ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
*/
int Fibonacci=1;
int numeroAnterior=0;
List<int> listaFibonacci = new List<int>();
bool pertence=false;


System.Console.WriteLine("Digite um valor");
int.TryParse(Console.ReadLine(), out int valor);

int contador=0;
while(Fibonacci<=valor){
    Fibonacci=Fibonacci+numeroAnterior;
    System.Console.WriteLine(Fibonacci);

    listaFibonacci.Add(Fibonacci);

    numeroAnterior++;
    contador++;
}

foreach (int fibo in listaFibonacci)
{
if(fibo==valor){
    pertence=true;
    break;
}else{
    pertence=false;
}

}

if(pertence==true){
    System.Console.WriteLine($"O valor {valor} pertence a sequencia de fibonacci");
}else{
    System.Console.WriteLine($" O valor {valor} não pertence a sequencia de fibonacci");
}