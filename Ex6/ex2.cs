namespace Ex6
//DUPLA: ENRICO E SAMIRA
{
    internal class ex2
    {
        static void Main(string[] args)
        {
            int contador1 = 0;
            int contador2 = 0;
            int idade;
            do
            {
                Console.WriteLine("Insira a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade < 21 && idade > 0) //condicao para contar pessoas abaixo de 21 anos
                {
                    contador1 += 1;
                }

                else if (idade > 50) // condicao para contar pessoas acima de 50 anos
                {
                    contador2 += 1;
                }


            } while (idade != -99);

            Console.WriteLine($"Foram registradas {contador1} pessoas com menos de 21 anos.");
            Console.WriteLine($"Foram registradas {contador2} pessoas com mais de 50 anos.");
        }
    }
}