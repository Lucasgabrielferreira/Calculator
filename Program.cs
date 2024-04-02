// See https://aka.ms/new-console-template for more information

Menu();

static void Menu()
{
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("-----------");
    Console.Write("Selecione uma opção: ");
    short res = short.Parse(Console.ReadLine());

    switch(res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}


static void Soma()
{
       Console.Clear();

    Console.Write("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    float Resultado = v1 + v2;

    Console.WriteLine($"O resultado da soma é {Resultado}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.Write("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    float Resultado = v1 - v2;

    Console.WriteLine($"O resultado da subtração é {Resultado}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.Write("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    float Resultado = v1 / v2;

    Console.WriteLine($"O resultado da Divisão é {Resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.Write("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    float Resultado = v1 * v2;

    Console.WriteLine($"O resultado da Multiplicacão é {Resultado}");
    Console.ReadKey();
    Menu();
}
