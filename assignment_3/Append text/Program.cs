namespace Append_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myfile = "D:\\backend trainning asp.net\\example4.txt";


            if (!File.Exists(myfile))
            {
                
                using (StreamWriter sw = File.CreateText(myfile))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("world");
                    
                }
            }

            
            using (StreamWriter sw = File.AppendText(myfile))
            {
                sw.WriteLine("I");
                sw.WriteLine("am");
                sw.WriteLine("sajal");
            }

            
            using (StreamReader sr = File.OpenText(myfile))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}