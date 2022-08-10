namespace String1
{
    internal class Program
    {
       /* public static string Concat(string str1,string str2)
        {
            return str1 + str2;
            
        }*/
        public static void Main(string[] args)
        {
            //string str1 = "welocome to india";
            string str2 = "sajal";
           
           // char[] chars = str1.ToCharArray();
            //Console.WriteLine(chars);
            // str1 = str1.TrimEnd(new Char[] { '0' });
            // Console.WriteLine(str1.Substring(3,9));


            // Console.WriteLine(Concat(str1,str2));
            Console.WriteLine("NewString: " + str2.Replace('a','A'));

        }
    }
}