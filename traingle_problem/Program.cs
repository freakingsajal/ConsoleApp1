namespace traingle_problem
{
    internal class Program
    {
        static void checkTriangle(int x, int y, int z)
        {

           
            if (x == y && y == z)
                Console.WriteLine("Equilateral Triangle");

            
            else if (x == y || y == z || z == x)
                Console.WriteLine("Isosceles Triangle");

           
            else
                Console.WriteLine("Scalene Triangle");
        }
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter the side's of the traingle");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
           
            
            checkTriangle(x, y, z);
        }
    }
}