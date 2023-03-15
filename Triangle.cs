

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int k ,i, j, n;
            Console.Write("Enter the height of triangle : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n ; i++)
            {
                for (j = n; j > i; j--)
                {

                    Console.Write(" ");
                }

                for (k = 1; k<=2*i-1; k++){

                    Console.Write("*");

                }
                Console.WriteLine();

            }

        }
    }
}
