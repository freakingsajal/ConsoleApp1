namespace reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstLetter, secondLetter1, thirdLetter2;

            Console.Write("Input first letter: ");
            firstLetter = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second letter: ");
            secondLetter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input third letter: ");
            thirdLetter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", thirdLetter2, secondLetter1, firstLetter);
        }
    }
}