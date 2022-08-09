namespace eligibilty_criteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maths, chem, phy;
            Console.Write("Input the number in maths : ");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number in chem : ");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number in phy : ");
            phy = Convert.ToInt32(Console.ReadLine());
               if(maths<0 || chem<0 || phy < 0)
                {
                Console.Write("Number cannot be less then zero");
                }
               if (maths >= 65 && phy >= 55 && chem >= 50 && ((maths + phy + chem) >= 180 || (maths + phy) >= 140))
               {

                Console.Write("The candidate is eligible for enrollment.");
                }
               else
                {
                Console.Write("The candidate is NOT eligible for enrollment.");
                }

            
           

        }
    }
}