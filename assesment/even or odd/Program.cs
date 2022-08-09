namespace even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            bool bothnumbers;
            Console.Write("Input First number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            if((n1 % 2 == 0) && (n2 % 2 == 0))
            {
                bothnumbers = true;
            }
            else
            {
                bothnumbers = false;
            }
            

            Console.WriteLine(bothnumbers ? "Both numbers are Even" : "Both number are odd");
        }
    }
}