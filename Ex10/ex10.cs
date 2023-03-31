using System.Xml;

namespace Ex10
//DUPLA: ENRICO E SAMIRA
{
    internal class ex10
    {
        static void Main(string[] args)
        {
            int alunosQtd;
            int alunosQtd2 = 0;
            double notaAluno = 0;
            double media;
            double totalNotas = 0;

            Console.WriteLine("Quantos alunos há na sala?");
            alunosQtd = Convert.ToInt32(Console.ReadLine());

            do
            {
                alunosQtd2++; //variavel de controle para autoincrementada para encerrar o loop quando
                              //igualar o numero de alunos
                Console.WriteLine("Insira a nota do aluno "+alunosQtd2+":");
                notaAluno = Convert.ToDouble(Console.ReadLine());

                totalNotas += notaAluno; //Vai somando as notas numa variavel totalNotas

            }while (alunosQtd2 < alunosQtd); //condiçao para encerrar o loop

            media = totalNotas / alunosQtd; //calculo da media

            Console.WriteLine("A média aritmetica da turma é: " + media);
        }
    }
}