// 1 - Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
int idade = 35;
Console.WriteLine(idade);

// 2 - Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.

string nome = "Maria";
Console.WriteLine(nome);

// 3 - Crie uma variável chamada altura e atribua a ela o valor 3.45.

double altura = 3.45;
Console.WriteLine(altura);

// 4  - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
 
const int ano = 12;
Console.WriteLine(ano);

// 5 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor
    
double? nota = 7.80;
Console.WriteLine(nota);

/* 6 - Quais as diferenças entre os tipos por valor e os tipos por referência ?
Tipos por valor: São armazenados na pilha (stack). Exemplos incluem int, double, char, structs, etc.
Tipos por referência: São armazenados no heap (monte). Exemplos incluem string, arrays, classes, interfaces, etc.
*/


/* 7 - O que é um nullable type e qual a sua utilidade ?
Nullable Type:
Um nullable type em C# é um tipo de dados que pode armazenar valores do tipo normal do tipo de dados, bem como um valor nulo adicional.
Utilidade do Nullable Type:
A utilidade principal do nullable type é permitir que tipos por valor, que normalmente não aceitam valores nulos, possam armazenar valores nulos.
*/


/* 8 - O que é Camel Case ? Dê um exemplo de sua aplicação
Camel Case é uma convenção de nomenclatura onde várias palavras são unidas e a primeira palavra começa com uma letra minúscula, e cada palavra subsequente começa com uma letra maiúscula, sem espaços ou pontuação. 
Exemplo:
int quantidadeDeVacas;
double rendMensal;
string nomeFuncionario;
*/


/* 9 - O que é Pascal Case ? Dê um exemplo de sua aplicação
Pascal Case é outra convenção de nomenclatura onde várias palavras são unidas e a primeira letra de cada palavra é maiúscula, sem espaços ou pontuação.
Exemplo:
int QuantidadeDeVacas;
double RendMensal;
string NomeFuncionario;
É semelhante ao Camel Case, exceto que a primeira letra da primeira palavra também é maiúscula.
*/


// 10 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)

int x = 77;
int y = 66;
Console.WriteLine("A resposta é " + (y+x));

//Tde - Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
//bool: O valor padrão é 'false'.
//char: O valor padrão é '\0' (caractere nulo).
//int: O valor padrão é '0'.
//double: O valor padrão é '0.0'.
//float: O valor padrão é '0.0f'.
//decimal: O valor padrão é '0.0m'.
//string: O valor padrão é 'null'.
