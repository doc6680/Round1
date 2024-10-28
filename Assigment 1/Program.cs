namespace Assigment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers : ");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            int largeNum;

            if (num1 > num2) 
            { 
                if (num1 > num3) 
                {
                    largeNum = num1;
                }
                else 
                {
                    largeNum = num3;
                }
            }
            else
            {
                if (num2 > num3) 
                {
                    largeNum = num2;
                }
                else
                {
                    largeNum = num3;
                }
            }

            Console.WriteLine("Largest is :" + largeNum);

        }
    }
}