namespace Generics
{
    internal class Program
    {
        public class GenericExample
        {
            public void show<T>(T msg)
            {
                Console.WriteLine(msg);
            }
           /* public GenericExample(T msg)
            {
                Console.WriteLine(msg);
            }*/
        }
        static void Main(string[] args)
        {
            // GenericExample<string> genericExample = new GenericExample<string>("this is the message");
            // Console.WriteLine("Hello, World!");
            // GenericExample<int> genericExampleInt = new GenericExample<int>(24);
            //GenericExample<char> genericExamplechar = new GenericExample<char>('S');
            GenericExample genericExample1 = new GenericExample();
            genericExample1.show("generics for methods");
            genericExample1.show(23);

        }
    }
}