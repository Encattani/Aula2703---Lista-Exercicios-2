namespace Ex5
{
    internal class ex5
    {
        static void Main(string[] args)
        {
            int[] listanumeros = new int[15];

            Console.WriteLine(listanumeros.Length);

            foreach (int item in listanumeros)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            for (int i = 0; ; i < listanumeros.Length; i)
                { }
        }
    }
}