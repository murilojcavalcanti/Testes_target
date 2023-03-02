//Questão 5
/*
5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;
*/

System.Console.Write("Digite a palavra que você deseja: ");
string palavra = Console.ReadLine();
string inverso = "";
for (int i =0; i<palavra.Length;i++){
    char letra = palavra[i];
    inverso = letra+inverso;
    System.Console.WriteLine(inverso);
}
System.Console.WriteLine($"A palavra ao inverso é: {inverso}");
