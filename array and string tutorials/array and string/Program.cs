namespace array_and_string
{
    internal class Program
    {

        public class student
        {
            /* public student(int a, int b)
             {
                 Console.WriteLine("constructor is called");
                 Console.WriteLine(a+b);

             }*/
            public int id, age;
            public string name;


            public static string collgeName = "IKGPTU";
            public student(int id,int age, string name)
            {
                this.id = id;
                this.age = age;
                this.name = name;
                //this.collgeName = collgeName;
            }
            public void showinfo()
            {
                Console.WriteLine(id + " " + name + " " + age + " " + collgeName);   
                
            }
        }
        static void Main(string[] args)
        {
            /*int[] ints = { 1, 2, 3 };
            int[] ints2 = new int[3];
            ints2[0] = 4;
            ints2[1] = 5;
            ints2[2] = 6;*/
            /*for(int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }*/

            /* int[,] Arr = new int[3,3];
             Arr[0,0] = 1;
             Arr[0,1] = 2;
             Arr[0,2] = 3;
             Arr[1,0] = 4;
             Arr[1,1] = 5;
             Arr[1,2] = 6;
             Arr[2,0] = 7;
             Arr[2,1] = 8;
             Arr[2,2] = 9;
             for(int i = 0; i < 3; i++)
             {
                 for(int j = 0; j < 3; j++)
                 {
                     Console.Write(Arr[i,j] + " ");
                 }
                 Console.WriteLine();
             }*/
            /* int[][] arr = new int[3][];
             arr[0] = ints;
             arr[1] = ints;
             arr[2] = ints2;
             for(int i = 0; i < arr.Length; i++)
             {
                 for(int j = 0; j < arr.Length; j++)
                 {
                     Console.Write(arr[i][j] + " ");
                 }
                 Console.WriteLine();

             }*/
            student student1 = new student(1,20,"sajal");
            student student2 = new student(2, 30, "sajal1");
            student1.showinfo();
            student2.showinfo();
            
            

        }

    }
}