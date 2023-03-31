namespace Ex11

//DUPLA: ENRICO E SAMIRA
{
    internal class ex11
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numero;
            int[] listaNum;
            int numeroMaior = 0;

            while (contador < 10)
            {
                Console.WriteLine("Insira um numero: ");
                numero= Convert.ToInt32(Console.ReadLine());

                if (numeroMaior < numero) //condição criada para atribuir o maior valor à variavel numeroMaior
                {
                    numeroMaior = numero;
                }

                contador++;

            }

            Console.WriteLine("O maior numero inserido foi "+numeroMaior);


        }
    }
}