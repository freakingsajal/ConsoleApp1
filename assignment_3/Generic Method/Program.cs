namespace Generic_Method
{
    internal class Program
    {
        public class genrics
        {
            public void Generic<T, X, Y>(T id, X name, Y result_status)
            {
                Console.WriteLine("id: " + id + " name: " + name + " Result_Status :" + result_status);

            }
        }
        static void Main(string[] args)
        {
            genrics genericObj = new genrics();
            genericObj.Generic(12, "Rahul", 'Y');
            genericObj.Generic(14, "Kiran", 'N');
            genericObj.Generic(23, "sajal", 'Y');
            genericObj.Generic(40, "Ram", 'Y');
            genericObj.Generic(31, "shyam", 'N');
        }
    }
}