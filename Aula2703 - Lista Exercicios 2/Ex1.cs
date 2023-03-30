using System.ComponentModel.Design;

namespace Ex1

    //DUPLA: ENRICO E SAMIRA
{
    internal class Ex1
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int numeroPar = 0;
            int numeroImpar = 0;

            
            do //vai fazer o que está dentro da condiçao
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0 && numero < 1001 && numero % 2 == 0) //checando e somando numeros pares
                {
                    numeroPar += numero;
                }

                else if (numero > 0 && numero < 1001 && numero % 2 != 0) //checando e somando numeros impares
                {
                    numeroImpar += numero;
                }               


            } while (numero > 0 && numero <= 1000); //condição

            Console.WriteLine("A soma dos pares é: " + (numeroPar));
            Console.WriteLine("A soma dos impares é: " + (numeroImpar));



        }
    }
}