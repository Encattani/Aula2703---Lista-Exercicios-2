namespace Ex5
{
    internal class ex5
    {
        static void Main(string[] args)
        {
            int numero;
            int maior = int.MaxValue;
            int menor = int.MinValue;

            for(int i = 0; i < 15; i++)
            {

                Console.WriteLine("Insira um numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > maior)
                    maior = numero;

                if (numero < menor)
                    menor = numero;

            }

            Console.WriteLine($"O maior é {maior}, e o menor é {menor}");
        }
    }
}