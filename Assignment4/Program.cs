namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between  2-9");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                int result = 0;
                result =  number * i;
                Console.Write( number + " * " + i + " = "  + result +" , ");

            }

        }
    }
}