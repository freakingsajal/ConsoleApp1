namespace even_and_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            bool bothNumbers;
            bool bothEven;
            Console.Write("Input First number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            if((n1 % 2 == 0) && (n2 % 2 == 0))
            {
                bothNumbers = true;
            }
            else
            {
                bothNumbers = false;
            }
           

            Console.WriteLine(bothNumbers ? "Both numbers are even":"Both numbers are odd");
        }
    }
}