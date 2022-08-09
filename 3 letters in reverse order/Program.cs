namespace _3_letters_in_reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter, letter1, letter2;

            Console.Write("Input first letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input third letter: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
            
        }
    }
}