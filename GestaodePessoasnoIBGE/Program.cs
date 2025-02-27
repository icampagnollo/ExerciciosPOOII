int idade = 1;
float A = 0, B = 0, C = 0, D = 0, E = 0, Total = 0;
do
{
    Console.WriteLine("Seja bem vindo! Por favor, digite a idade, ou para finalizar, digite '0' para encerrar o programa! :) ):");
    string idadeString = Console.ReadLine();
    idade = int.Parse(idadeString);

    switch (idade)
    {
        case > 0 and < 16:
            A++;
            Total++;
            break;

        case > 15 and < 31:
            B++;
            Total++;
            break;

        case > 30 and < 46:
            C++;
            Total++;
            break;

        case > 45 and < 61:
            D++;
            Total++;
            break;

        case > 60:
            E++;
            Total++;
            break;
    }
} while (idade > 0);

Console.WriteLine($"Porcentagem de A (1 - 15 anos): {(A / Total) * 100:F0}%, {A} pessoas de {Total}.");
Console.WriteLine($"Porcentagem de B (16 - 30 anos): {(B / Total) * 100:F0}%, {B} pessoas de {Total}.");
Console.WriteLine($"Porcentagem de C (31 - 45 anos): {(C / Total) * 100:F0}%, {C} pessoas de {Total}.");
Console.WriteLine($"Porcentagem de D (46 - 60 anos): {(D / Total) * 100:F0}%, {D} pessoas de {Total}.");
Console.WriteLine($"Porcentagem de E (61 + anos): {(E / Total) * 100:F0}%, {E} pessoas de {Total}.");
