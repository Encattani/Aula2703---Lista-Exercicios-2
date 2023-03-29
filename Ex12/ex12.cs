namespace Ex12
//DUPLA: ENRICO E SAMIRA
{
    internal class ex12
    {
        static void Main(string[] args)
        {
            int contador;

            for (contador = 0; contador <= 100; contador++ )
            {
                Console.WriteLine(contador);
            }

            Console.WriteLine("-------------------------------");

            contador = 0;
            while(contador <= 100)
            {
                contador++;
                Console.WriteLine(contador);
            }

            Console.WriteLine("-------------------------------");

            contador = 0;
            do
            {
                contador++;
                Console.WriteLine(contador);
            }while(contador <= 99);
        }
    }
}