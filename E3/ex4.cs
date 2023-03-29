namespace E3
//DUPLA: ENRICO E SAMIRA
{
    internal class ex4
    {
        static void Main(string[] args)
        {
            int numero;
            int multiplicador = 0;
            

            Console.Write("Insira um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            

            while (multiplicador <= 9)
            {
                multiplicador++;
                Console.WriteLine($"A tabuada do {numero} é: {numero} * {multiplicador} = {numero* multiplicador} ");
                
            }
        }
    }
}