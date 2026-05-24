
namespace AtividadeSala
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite X: ");
                int x = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite Y: ");
                int y = int.Parse(Console.ReadLine()!);
           
           //caso 1 
           int resultado = 0;
           for(int i = 1; i <= y; i++)
           {
                resultado += y;
           }
            Console.WriteLine("Produto: " + resultado);

           //caso 2
           int resultado2 = 1;
           for(int i = 1; i <= y; i++)
            {
                resultado2 *= x;
            }
            Console.WriteLine("Potencia: " + resultado2);

            //caso 3
            int resultado3 = 1;
            for(int i = 1; i <= y; i++)
            {
                resultado3 *= x;
            }
            Console.WriteLine("Fatorial: " + resultado3);

        }
    }
}

