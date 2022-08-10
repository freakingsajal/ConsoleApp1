namespace exception
{
    internal class Exceptionhandling
    {
        public static void validage(int age)
        {
            if (age < 18)
            {
                throw new underageexception("message");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                //  int a = 10;
                // int b = 0;
                //  Console.WriteLine(a / b);
                validage(15);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("code is resumed");
            }
        }
    }
}
public class underageexception : Exception
{
    public underageexception(String message):base(message)
    {

    }
}