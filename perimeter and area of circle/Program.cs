namespace perimeter_and_area_of_circle
{
    internal class Program
    {

       
        static void Main(string[] args)
            
        {
            double radius,Perimeter,Area;
            double PI = 3.14;
            Console.WriteLine("Enter the radius of a circle");
            radius = Convert.ToDouble(Console.ReadLine());
            Perimeter = 2 * PI * radius;
            Console.WriteLine("Perimeter of the circle is " + Perimeter);
            Area = PI * radius * radius;
            Console.WriteLine("Area of the circle is " + Area);

        }
    }
}