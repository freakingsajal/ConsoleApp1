namespace calculate_speed_in_kmp_and_mph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float distance;
            float hour, min, sec;

            float timeSec;
            
            float kilometerPerHour, milePerHour;

            Console.Write("Input distance In metres): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
           
            kilometerPerHour = (distance / 1000.0f) / (timeSec / 3600.0f);
            milePerHour = kilometerPerHour / 1.609f;

           
            Console.WriteLine("Your speed in kilometres per hour is " + kilometerPerHour);
            Console.WriteLine("Your speed in miles per hour is " +  milePerHour);
        }
    }
}