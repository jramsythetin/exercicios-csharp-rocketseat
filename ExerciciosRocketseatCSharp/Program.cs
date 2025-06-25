using System.Globalization;

namespace ExerciciosRocketseatCSharp;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("===== MENU DE EXERCÍCIOS =====");
            Console.WriteLine("1 - Boas-vindas");
            Console.WriteLine("2 - Nome completo");
            Console.WriteLine("3 - Operações matemáticas");
            Console.WriteLine("4 - Contar caracteres");
            Console.WriteLine("5 - Validar placa");
            Console.WriteLine("6 - Exibir data/hora");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("==============================");

            int numeroExercicio = int.Parse(Console.ReadLine());

            if (numeroExercicio == 0)
            {
                Console.WriteLine("Saindo do programa...");
                break;
            }

            switch (numeroExercicio)
            {
                case 1: // Exercício número 1
                {
                    Console.Clear();

                    Console.WriteLine("Digite seu nome: ");
                    string usuario = Console.ReadLine();

                    Console.WriteLine("Digite uma mensagem de boas vindas: ");
                    string mensagem = Console.ReadLine();

                    string boasVindas = ($"Olá, {usuario}! {mensagem}!");

                    Console.WriteLine(boasVindas);
                }
                    break;

                case 2: // Exercício número 2
                {
                    Console.Clear();

                    Console.WriteLine("Digite seu nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digte seu sobrenome: ");
                    string sobrenome = Console.ReadLine();

                    Console.WriteLine($"{nome} {sobrenome}");
                }
                    break;

                case 3: // Exercício número 3
                {
                    Console.Clear();

                    Console.WriteLine("Digite o primeiro valor: ");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo valor: ");
                    double n2 = double.Parse(Console.ReadLine());

                    // Resultados
                    Console.WriteLine("----- RESULTADOS ------");

                    Console.WriteLine();

                    Console.WriteLine($"A soma é: {n1 + n2}");

                    Console.WriteLine($"A subtração é: {n1 - n2}");

                    Console.WriteLine($"A multiplicação é: {n1 * n2}");
                    if (n2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero (resultado será infinito).");
                        Console.WriteLine($"A divisão por zero é: {n1 / n2}"); // Número infinito
                    }
                    else
                    {
                        Console.WriteLine($"A divisão é: {n1 / n2}");
                    }

                    Console.WriteLine($"A média dos dois números é: {(n1 + n2) / 2}");
                }
                    break;

                case 4: // Exercício número 4
                {
                    Console.Clear();

                    Console.WriteLine("Digite uma ou mais palavras: ");
                    string palavra = Console.ReadLine();

                    Console.WriteLine($"Número de caracteres = {palavra.Length}");
                }
                    break;

                case 5: // Exercício número 5
                {
                    Console.Clear();

                    Console.WriteLine("Digite o número da sua placa seguindo o padrão brasileiro:");
                    string placa = Console.ReadLine();
                    Console.WriteLine();

                    bool validacao;

                    if (placa.Length != 7)
                    {
                        validacao = false;
                        Console.WriteLine($"A placa deve ter exatamente 7 caracteres. {validacao}");
                    }
                    else if (placa.Substring(0, 3).All(char.IsLetter) && placa.Substring(3, 4).All(char.IsDigit))
                    {
                        validacao = true;
                        Console.WriteLine($"Placa válida! {validacao}");
                    }
                    else
                    {
                        validacao = false;
                        Console.WriteLine(
                            $"Formato inválido: os 3 primeiros devem ser letras e os 4 últimos números. {validacao}");
                    }
                }
                    break;

                case 6: // Exercicio número 6
                {
                    Console.Clear();

                    DateTime agora = DateTime.Now;

                    Console.WriteLine("=== FORMATOS DE DATA E HORA ===");

                    Console.WriteLine();

                    // 1. Formato completo: dia da semana, dia do mês, mês, ano, hora, minutos, segundos
                    string formatoCompleto = agora.ToString("dddd, dd 'de' MMMM 'de' yyyy - HH:mm:ss",
                        new CultureInfo("pt-BR"));
                    Console.WriteLine("Formato completo:");
                    Console.WriteLine(formatoCompleto);
                    Console.WriteLine();

                    // 2. Apenas a data no formato "01/03/2024"
                    string dataPadrao = agora.ToString("dd/MM/yyyy");
                    Console.WriteLine("Data padrão:");
                    Console.WriteLine(dataPadrao);
                    Console.WriteLine();

                    // 3. Apenas a hora no formato 24 horas
                    string hora24 = agora.ToString("HH:mm:ss");
                    Console.WriteLine("Hora no formato 24h:");
                    Console.WriteLine(hora24);
                    Console.WriteLine();

                    // 4. Data com o mês por extenso (ex: 25 de junho de 2025)
                    string dataExtenso = agora.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));
                    Console.WriteLine("Data com mês por extenso:");
                    Console.WriteLine(dataExtenso);
                }
                    break;
            }
        }
    }
}


