namespace RefatoracaodiamantedeX.ConsoleApp1
{
 
        internal class Program
        {
            static void Main(string[] args)
            {
                int espacos, x;
                int numero = Menu();

                x = 1;
                espacos = (numero - 1) / 2;

                DesenharParteSuperior(ref espacos, ref x);
                DesenharParteInferior(ref espacos, ref x);
            }

            static int Menu()
            {
                int numero;
                Console.WriteLine("Digite um número impar: ");
                numero = int.Parse(Console.ReadLine());

                while (numero % 2 == 0)
                {
                    Console.WriteLine("Este numero é par, tente novamente...");
                    Console.WriteLine();
                    Console.WriteLine("Digite um número impar: ");
                    numero = int.Parse(Console.ReadLine());
                }

                return numero;
            }
            static void DesenharParteSuperior(ref int espacos, ref int x)
            {
                for (int linha = 1; espacos > 0; linha++)
                {
                    for (int count = 1; count <= espacos; count++)
                    {
                        Console.Write(" ");
                    }

                    for (int count = 1; count <= x; count++)
                    {
                        Console.Write("x");
                    }
                    espacos--;
                    x += 2;
                    Console.WriteLine();
                }
            }

            static void DesenharParteInferior(ref int espacos, ref int x)
            {
                    for (int linha = 1; x > 0; linha++)
                    {
                        for (int count = 1; count <= espacos; count++)
                        {
                            Console.Write(" ");
                        }

                        for (int count = 1; count <= x; count++)
                        {
                            Console.Write("x");
                        }

                        espacos++;
                        x -= 2;
                        Console.WriteLine();
                    }
            }

        }
    
}
    
