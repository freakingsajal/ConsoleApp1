namespace height_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float PersonHeight;

            Console.Write("Input the height of the person in centimetres:");
            PersonHeight = Convert.ToInt32(Console.ReadLine());

            if (PersonHeight < 135.0)
                Console.Write("Short \n\n");
            else if ((PersonHeight >= 135.0) && (PersonHeight <= 180.0))
                Console.Write("Average \n\n");
            else if (PersonHeight >= 180.0)
                Console.Write("Tall \n\n");
            else
                Console.Write("Abnormal height.\n\n");
        }
    }
}