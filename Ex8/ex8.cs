namespace Ex8
//DUPLA: ENRICO E SAMIRA
{
    internal class ex8
    {
        static void Main(string[] args)
        {
            string nome1, nome2 = "";
            int i, reverse2;

            Console.Write("Digite um nome: ");
            nome1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            reverse2 = nome1.Length - 1;

            for (i = reverse2; i >=0; i--) 
            {
                nome2 = nome2 + nome1[i];
            }

            Console.WriteLine("Ao contrario fica: "+nome2);
        }
    }
}