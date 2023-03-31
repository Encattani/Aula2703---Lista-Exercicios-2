namespace Ex9
//DUPLA: ENRICO E SAMIRA
{
    internal class ex9
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int somaImpar = 0;
            do
            {
                numero++;

                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                }

            } while (numero <= 99);

            
        }
    }
}