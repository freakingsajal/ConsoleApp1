namespace filehandling
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            /*using (TextWriter tw = File.CreateText("D:\\backend trainning asp.net\\example1.txt"))
            {
                tw.WriteLine("hello sajal");
            }*/
            // Console.WriteLine("Hello, World!");
            // FileStream fileStream = new FileStream("D:\\backend trainning asp.net\\example.txt", FileMode.OpenOrCreate);
            /*StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("hello");
            //fileStream.WriteByte(65);
            writer.Close();
            fileStream.Close();
            Console.WriteLine("done");*/
            // StreamReader reader = new StreamReader(fileStream);
            //string str = reader.ReadLine();
            // Console.WriteLine("reading from a file : " + str);
            // reader.Close();
            //  fileStream.Close();

            // TextWriter writer = new TextWriter(fileStream);


            /* using (TextReader tr = File.OpenText("D:\\backend trainning asp.net\\example1.txt"))
             {
                 //Console.WriteLine(tr.Read());
                 //Console.WriteLine(tr.ReadLine());
                 Console.WriteLine(tr.ReadToEnd());

             }*/

            /*String filename = "D:\\backend trainning asp.net\\example2.txt";
            using (BinaryWriter bw =new BinaryWriter(File.Open(filename, FileMode.Create)))
            {
                bw.Write(65);
                //bw.Write("Hello");
            }
            using(BinaryReader br =new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                Console.WriteLine(br.ReadString());
            }*/



            /* string longtext = "today is thursday tomorrow is friday";
             StringBuilder sb = new StringBuilder();
             StringWriter sw = new StringWriter(sb);
             sw.WriteLine(longtext);
             sw.Close();
             StringReader sr = new StringReader(sb.ToString());
             while (sr.Peek() != -1)
             {
                 Console.WriteLine(sr.ReadLine());
             }*/

           //FileInfo fw = new FileInfo("D:\\backend trainning asp.net\\example3.txt");
           //fw.Delete();

           DirectoryInfo dw = new DirectoryInfo("D:\\backend trainning asp.net\\backend");
           dw.Delete();



        }
    }
}