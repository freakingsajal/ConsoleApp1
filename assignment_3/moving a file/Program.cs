namespace moving_a_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sfileName = "D:\\backend trainning asp.net\\example5.txt";
            string tfileName = "D:\\backend trainning asp.net\\example6.txt";
            if (File.Exists(sfileName))
            {
                File.Delete(sfileName);
            }
            if (File.Exists(tfileName))
            {
                File.Delete(tfileName);
            }
            using (StreamWriter fileStr = File.CreateText(sfileName))
            {
                fileStr.WriteLine(" Hello and Welcome");
                fileStr.WriteLine(" It is the first content");
                
            }
            using (StreamReader sr = File.OpenText(sfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", sfileName);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
            System.IO.File.Move(sfileName, tfileName); 
            Console.WriteLine(" The file has successfully moved to the same directory.", sfileName, tfileName);
        }
    }
}