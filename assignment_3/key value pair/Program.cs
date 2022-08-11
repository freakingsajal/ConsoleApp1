namespace key_value_pair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> StudentInfo = new Dictionary<int,int>();


            StudentInfo.Add(1, 40);
            StudentInfo.Add(2, 90);
            StudentInfo.Add(3, 80);
            StudentInfo.Add(4, 95);


            foreach (KeyValuePair<int,int> item in StudentInfo)
            {
                Console.WriteLine("Id : " + item.Key + " Marks : " + item.Value);
            }
        }
    }
}