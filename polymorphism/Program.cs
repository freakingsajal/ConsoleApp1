namespace polymorphism
{
    internal class Program
    {
        class students
        {
            public virtual void fun()
            {
                Console.WriteLine("hello parent class");
            }
        }
        class base_students : students
        {
            public override void fun() {
                Console.WriteLine("hello derived class");
            }


        }
       
        static void Main(string[] args)
        {
           // Console.WriteLine(add(10, 20));
           // Console.WriteLine(add(10, 20 ,30));

            //add(10, 20);
            //add(10, 20, 30);
            base_students student1 = new base_students();
            student1.fun();
        }
    }
}