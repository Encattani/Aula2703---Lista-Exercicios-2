namespace Ex14
 //DUPLA: ENRICO E SAMIRA
{
    internal class ex14
    {
        static void Main(string[] args)
        {
            double velocidade;
            int escolha;

            do //cria um looping enquanto as escolhas forem 1 ou 2
            {
                Console.WriteLine("Qual conversão deseja fazer?");
                Console.WriteLine("1 - Km/h para m/s.");
                Console.WriteLine("2 - m/s para Km/h");
                Console.WriteLine("3 - Sair.");
                escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1) //condicao de esolha 1 para converter km/h em m/s
                {
                    Console.Write("Insira a velocidade em km/h: ");
                    velocidade = Convert.ToDouble(Console.ReadLine());   
                    Console.WriteLine();
                    Console.WriteLine($"A velocidade em m/s é: {velocidade * 3.6} ");
                }

                else if (escolha ==2) //condicao de escolha 2 para converter m/s em km/h
                {
                    Console.Write("Insira a velocidade em m/s: ");
                    velocidade = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"A velocidade em km/h é: {velocidade / 3.6} ");
                }

                

            } while (escolha == 1 || escolha == 2);

            Console.WriteLine();
        }
    }
}