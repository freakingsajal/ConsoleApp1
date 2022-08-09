namespace perimeter_and_area_of_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, perimeterOfCircle,area;
            double PI = 3.14;
            Console.WriteLine("Input the radius of the circle : ");
            radius = Convert.ToDouble(Console.ReadLine());
            perimeterOfCircle = 2 * PI * radius;
            Console.WriteLine("Perimeter of Circle : " +  perimeterOfCircle);
            area = PI * radius * radius;
            Console.WriteLine("Area of a circle : " + area);
            
        }
    }
}