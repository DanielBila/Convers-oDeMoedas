using ConversãoDeMoedas;

namespace ConversãoDeMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moedas moeda = new Moedas();
            Console.WriteLine("Escolha a moeda Nativa para ser convertido:");
            Console.WriteLine("1-Real");
            Console.WriteLine("2-Dolar");
            Console.WriteLine("3-Euro");
            Console.WriteLine("4-Pesos argentinos ");
            int escolhaDeMoedaNativa = int.Parse(Console.ReadLine());
            Console.Clear();
            //Moeda Nativa Real
            if(escolhaDeMoedaNativa == 1)
            {
                Console.WriteLine("Qual Seria a Moeda que sera convertida:");     
                Console.WriteLine("1-Dolar");
                Console.WriteLine("2-Euro");
                Console.WriteLine("3-Pesos argentinos ");
                int escolhaDeMoedaDeConversao = int.Parse(Console.ReadLine());
                Console.Clear();
                if(escolhaDeMoedaDeConversao == 1)
                {
                    Console.WriteLine("Qual Seria o Valor em Real para ser convertido em Dolar:");
                    double valorNatural  = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.RealParaDolar(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Real:{valorNatural}");
                    Console.WriteLine($"Em Dolar: {valorConvertido}");                
                }
                //Real para Euro
                else if (escolhaDeMoedaDeConversao == 2)
                {
                    Console.WriteLine("Qual Seria o Valor em Real para ser convertido em Euro:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.RealParaEuro(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Real:{valorNatural}");
                    Console.WriteLine($"Em Euro: {valorConvertido}");
                }
                //Real para Pesos argentinos
                else if (escolhaDeMoedaDeConversao == 3)
                {
                    Console.WriteLine("Qual Seria o Valor em Real para ser convertido em Pesos argentinos:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.RealParaPesos(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Real:{valorNatural}");
                    Console.WriteLine($"Em Pesos argentinos: {valorConvertido}");
                }
                else
                {
                    Console.WriteLine("Erro");
                    Task.Delay(1000).Wait();
                    Main(args);
                    Console.Clear();
                }
            }
            //Moeda Nativa Dolar 
            else if (escolhaDeMoedaNativa == 2)
            {
                Console.WriteLine("Qual Seria a Moeda que sera convertida:");
                Console.WriteLine("1-Real");
                Console.WriteLine("2-Euro");
                Console.WriteLine("3-Pesos argentinos ");
                int escolhaDeMoedaDeConversao = int.Parse(Console.ReadLine());
                Console.Clear();
                if (escolhaDeMoedaDeConversao == 1)
                {
                    Console.WriteLine("Qual Seria o Valor em Dolar para ser convertido em Real:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.DolarParaReal(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Dolar:{valorNatural}");
                    Console.WriteLine($"Em Real: {valorConvertido}");
                }
                else if (escolhaDeMoedaDeConversao == 2)
                {
                    Console.WriteLine("Qual Seria o Valor em Dolar para ser convertido em Euro:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.DolarParaEuro(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Dolar:{valorNatural}");
                    Console.WriteLine($"Em Euro: {valorConvertido}");
                }
                else if (escolhaDeMoedaDeConversao == 3)
                {
                    Console.WriteLine("Qual Seria o Valor em Dolar para ser convertido em Pesos argentinos:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.DolarParaPesos(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Dolar:{valorNatural}");
                    Console.WriteLine($"Em Pesos argentinos: {valorConvertido}");
                }
                else
                {
                    Console.WriteLine("Erro");
                    Task.Delay(1000).Wait();
                    Main(args);
                    Console.Clear();
                }
            }
            //Dolar Nativa Euro
            else if (escolhaDeMoedaNativa == 3)
            {
                Console.WriteLine("Qual Seria a Moeda que sera convertida:");
                Console.WriteLine("1-Real");
                Console.WriteLine("2-Dolar");
                Console.WriteLine("3-Pesos argentinos ");
                int escolhaDeMoedaDeConversao = int.Parse(Console.ReadLine());
                Console.Clear();
                if (escolhaDeMoedaDeConversao == 1)
                {
                    Console.WriteLine("Qual Seria o Valor em Euro para ser convertido em Real:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.EuroParaReal(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Euro:{valorNatural}");
                    Console.WriteLine($"Em Real: {valorConvertido}");
                }
                else if (escolhaDeMoedaDeConversao == 2)
                {
                    Console.WriteLine("Qual Seria o Valor em Euro para ser convertido em Dolar:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.EuroParaDolar(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Euro:{valorNatural}");
                    Console.WriteLine($"Em Dolar: {valorConvertido}");
                }
                else if (escolhaDeMoedaDeConversao == 3)
                {
                    Console.WriteLine("Qual Seria o Valor em Euro para ser convertido em Pesos argentinos:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.EuroParaPesos(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Euro:{valorNatural}");
                    Console.WriteLine($"Em Pesos argentinos: {valorConvertido}");
                }
                else
                {
                    Console.WriteLine("Erro");
                    Task.Delay(1000).Wait();
                    Main(args);
                    Console.Clear();
                }
            }
            //Pesso para outras moedas 
            else if (escolhaDeMoedaNativa == 4)
            {
                Console.WriteLine("Qual Seria a Moeda que sera convertida:");
                Console.WriteLine("1-Real");
                Console.WriteLine("2-Dolar");
                Console.WriteLine("3-Euro");
                int escolhaDeMoedaDeConversao = int.Parse(Console.ReadLine());
                Console.Clear();
                if (escolhaDeMoedaDeConversao == 1)
                {
                    Console.WriteLine("Qual Seria o Valor em Pesos argentinos  para ser convertido em Real:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.PesosParaReal(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Pesos argentinos:{valorNatural}");
                    Console.WriteLine($"Em Real: {valorConvertido}");
                }
                else if (escolhaDeMoedaDeConversao == 2)
                {
                    Console.WriteLine("Qual Seria o Valor em Pesos argentinos para ser convertido em Dolar:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.PesosParaDolar(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Pesos argentinos:{valorNatural}");
                    Console.WriteLine($"Em Dolar: {valorConvertido}");
                }
                else if (escolhaDeMoedaDeConversao == 3)
                {
                    Console.WriteLine("Qual Seria o Valor em Pesos argentinos para ser convertido em Euro:");
                    double valorNatural = double.Parse(Console.ReadLine());
                    double valorConvertido = moeda.PesosParaEuro(valorNatural);
                    Console.Clear();
                    Console.WriteLine($"Pesos argentinos:{valorNatural}");
                    Console.WriteLine($"Em Euro: {valorConvertido}");
                }
                else
                {
                    Console.WriteLine("Erro");
                    Task.Delay(1000).Wait();
                    Main(args);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Erro");
                Task.Delay(1000).Wait();
                Main(args);
                Console.Clear();
            }
        }
    }
}