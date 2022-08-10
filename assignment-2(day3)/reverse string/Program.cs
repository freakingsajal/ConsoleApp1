namespace reverse_string
{
    internal class Program
    {
        public static string Reverse(string Input)
        {


            char[] charArray = Input.ToCharArray();


            string reversedString = String.Empty;


            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }

            return reversedString;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string reversedString = Console.ReadLine();
            Console.Write("Reversed String : ");
            Console.WriteLine(Reverse(reversedString));


        }
    }
}