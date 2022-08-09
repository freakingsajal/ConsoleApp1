namespace height_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float PerHeight;

            Console.Write("Input the height of the person in centimetres:");
            PerHeight = Convert.ToInt32(Console.ReadLine());

            if (PerHeight < 135.0)
                Console.Write("Short \n\n");
            else if ((PerHeight >= 135.0) && (PerHeight <= 180.0))
                Console.Write("Average \n\n");
            else if (PerHeight >= 180.0)
                Console.Write("Tall \n\n");
            else
                Console.Write("Abnormal height.\n\n");
        }
    }
}