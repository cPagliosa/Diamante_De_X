namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Entrada();
                Console.WriteLine("\nRedesenhar:  qualquer tecla\nSair:0");
                string x = Console.ReadLine();
                if (x == "0")
                {
                    break;
                }else Console.Clear();
            }
        }

        static void Entrada()
        {
            Console.WriteLine("\n** Desenhar Diamante **\n");
            Console.WriteLine("Informer um numero impar para desenhar o diamante:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (Impar(x))
            {

                Desenhar(x);
            }
            else
            {
                Console.WriteLine($"{x} não é um numero impar!!\nPara desenhar o x tem que ser IMPAR!!\n");
                Console.WriteLine("-----------------------------\n");

            }
        }

        static Boolean Impar(int x)
        {
            if (x % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        static void Desenhar(int n)
        {
            string borda = "\n";
            for (int i = 0;i <= n; i++)
            {
                borda += "-";
            }
            Console.WriteLine(borda);

            int espacosAntesDepois = n / 2;

            Console.WriteLine(new string(' ', espacosAntesDepois) + "x");

            for (int i = 1; i <= n / 2; i++)
            {
                espacosAntesDepois--;
                Console.WriteLine(new string(' ', espacosAntesDepois) + new string('x', i * 2 + 1));
            }

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                espacosAntesDepois++;
                Console.WriteLine(new string(' ', espacosAntesDepois) + new string('x', i * 2 + 1));
            }
            Console.WriteLine(borda);
        }
    }
}
