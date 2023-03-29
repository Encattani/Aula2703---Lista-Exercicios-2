namespace Ex3
//DUPLA: ENRICO E SAMIRA
{
    internal class ex3
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            int produto = numero1 * numero2;
            Console.WriteLine("O produto da multiplicação dos números é: " + produto);

            do //cria um looping ate que o numero3 seja 0
            {
                Console.Write("Digite um numero novo: ");
                numero3 = Convert.ToInt32(Console.ReadLine());

                produto = produto * numero3; //incrementa o produto antigo ao novo

                Console.WriteLine(produto);

            } while (numero3 > 0);




        }
    }
}