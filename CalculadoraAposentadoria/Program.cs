using System;

namespace AposentadoriaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (FazerLogin())
            {
                CalcularAposentadoria();
            }
            else
            {
                Console.WriteLine("Login falhou. Tente novamente.");
            }
        }

        static bool FazerLogin()
        {
            Console.WriteLine("=== LOGIN ===");
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            return email == "rm550295@fiap.com.br" && senha == "RM550295";
        }

        static void CalcularAposentadoria()
        {
            Console.WriteLine("\n=== CALCULADOR DE APOSENTADORIA ===");

            int idade = LerIdade();
            char genero = LerGenero();

            int idadeAposentadoria = genero == 'M' ? 65 : 62;
            int tempoRestante = idadeAposentadoria - idade;

            Console.WriteLine(tempoRestante > 0 ?
                $"Faltam {tempoRestante} anos para sua aposentadoria" :
                "Você já pode se aposentar!");
        }

        static int LerIdade()
        {
            int idade;
            while (true)
            {
                Console.Write("Digite sua idade: ");
                if (int.TryParse(Console.ReadLine(), out idade) && idade > 0)
                    return idade;

                Console.WriteLine("Idade inválida! Tente novamente.");
            }
        }

        static char LerGenero()
        {
            while (true)
            {
                Console.Write("Gênero (M/F): ");
                char genero = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (genero == 'M' || genero == 'F')
                    return genero;

                Console.WriteLine("Opção inválida! Use M ou F.");
            }
        }
    }
}