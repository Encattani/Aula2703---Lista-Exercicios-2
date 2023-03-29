using System;

namespace Ex2
//DUPLA: ENRICO E SAMIRA
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador = 0;
            int numfixo;
            int numeropar;
            int numeroimpar;



            Console.WriteLine("insira um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero < 0) //obriga o usuario a inserir um numero valido
            {
                Console.WriteLine("número inválido, insira novamente: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            numfixo = numero; //fixando o numero inserido numa variavel que nao mudará
            numeropar = numero; //fixando o numero inserido numa variavel pra calcular os proximos pares
            numeroimpar = numero; //fixando o numero inserido numa variavel pra calcular os proximos imppares


            do
            {


                if (numero % 2 == 0)
                {
                    if (contador > 0 && contador < 4) //aqui vai imprimir em sequencia os 3 primeiros pares se o numero inserido for par
                    {

                        Console.WriteLine("Os 3 números pares  após " + numfixo + " são: " + (numeropar += 2));

                    }

                    if (contador > 3 && contador < 7) //aqui vai imprimir em sequencia os 3 primeiros impares se o numero inserido for par
                    {
                        if (contador == 4) 
                        {
                            Console.WriteLine("Os 3 números impares após " + numfixo + " são: " + (numeroimpar += 1)); //fazendo o numero par se tornar impar com + 1
                        }

                        if (contador > 4)
                        {
                            Console.WriteLine("Os 3 números impares após " + numfixo + " são: " + (numeroimpar += 2)); //criando a sequencia de impar
                        }


                    }

                    
                    contador += 1;


                }

                if (numero % 2 != 0) //aqui vai imprimir em sequencia os 3 primeiros pares se o numero inserido for impar
                {
                    if (contador > 0 && contador < 4)
                    {
                        Console.WriteLine("Os 3 números impares após " + numfixo + " são: " + (numeroimpar += 2));

                        

                    }

                    if (contador > 3 && contador < 7) //aqui vai imprimir em sequencia os 3 primeiros impares se o numero inserido for impar
                    {
                        if (contador == 4)
                        {
                            Console.WriteLine("Os 3 números pares  após " + numfixo + " são: " + (numeropar += 1)); //fazendo o numero impar se tornar par
                        }

                        if (contador > 4)
                        {
                            Console.WriteLine("Os 3 números pares  após " + numfixo + " são: " + (numeropar += 2)); //criando a sequencia de impar
                        }

                    }
                        contador += 1;

                }

            } while (contador < 8); //repetição enquanto o contador for menor que 8



           


        }



    }
}


