namespace Ex7
// DUPLA: ENRICO E SAMIRA
{
    internal class ex7
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.Write("Digite um numero entre 1 e 4: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero < 1 || numero >4) //condição para o usuario digitar o numero valido
            {
                Console.Write("Numero invalido, digite novamente: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

          
            Console.WriteLine("O numero digitado foi: " + numero);
            


        }
    }
}