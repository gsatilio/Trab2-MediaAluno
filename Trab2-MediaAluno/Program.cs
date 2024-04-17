/*
2 - faça um algoritmo que leia dois numeros reais (duas notas), calcule a sua média e informe a situação do aluno
baseado nos seguintes critérios
- se a média for <= 3 o aluno está reprovado
- se a média for > 3 ou <= 5 o aluno está de exame
- senão, o aluno está aprovado
*/

float n1, n2, media;
string nota;

Console.WriteLine("Por favor, informe a PRIMEIRA nota do aluno.");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Por favor, informe a SEGUNDA nota do aluno.");
n2 = float.Parse(Console.ReadLine());

if (n1 < 0 || n2 < 0 || n1 > 10 || n2 > 10)
{
    Console.WriteLine("Atencao: Informe um valor valido positivo de 0 a 10!");
}
else
{
    media = ((n1 + n2) / 2);
    nota = "Nota Media do aluno: " + media;

    if (media > 3)
    {
        if (media > 5)
        {
            Console.WriteLine("Aluno aprovado!\n" + nota);
        }
        else
        {
            Console.WriteLine("Aluno de exame!\n" + nota);
        }

    }
    else
    {
        Console.WriteLine("Aluno reprovado!\n" + nota);
    }
}

Console.ReadKey();