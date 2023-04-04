namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double exerc13numero, exerc13quadrado, exerc13cubo, exerc13raiz;

            do
            {
                Console.WriteLine("Insira um número para receber seus quadrado, cubo e raiz: ");
                exerc13numero = Convert.ToDouble(Console.ReadLine());

                exerc13quadrado = exerc13numero * exerc13numero;

                exerc13cubo = exerc13numero * exerc13numero * exerc13numero;

                exerc13raiz = Math.Sqrt(exerc13numero);

                Console.WriteLine("O quadrado de: " + exerc13numero + " é: " + exerc13quadrado);

                Console.WriteLine("O cubo de: " + exerc13numero + " é: " + exerc13cubo);

                Console.WriteLine("A raiz de: " + exerc13numero + " é: " + exerc13raiz);

            } while (exerc13numero > 0);
        }

    }
}