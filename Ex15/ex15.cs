namespace Ex15
//DUPLA: ENRICO E SAMIRA
{
    internal class ex15
    {
        static void Main(string[] args)
        {
            double aumento = 1.015;
            double salarioInicial = 2030 * aumento;

            for (int ano = 2007; ano < 2024; ano++) //o ano serve de variavel de controle
            {
            aumento =  aumento * 2; //ajustando o aumento a cada ano
            
                Console.WriteLine($"O salário em {ano} é de R${salarioInicial * aumento}");
            }
        }


    }
}