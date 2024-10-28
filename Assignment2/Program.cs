namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter degree (A, B, C, D, E) : ");
            string studentDegree = Console.ReadLine();
            if (studentDegree == "A") 
            {
                Console.WriteLine("Excellent");
            }
            else if (studentDegree == "B") 
            {
                Console.WriteLine("Very Good");
            }
            else if (studentDegree == "C")
            {
                Console.WriteLine("Good");
            }
            else if (studentDegree == "D")
            {
                Console.WriteLine("Fair");
            }
            else if (studentDegree == "E")
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}