namespace eligibility_of_admission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Maths, Chem, Phy;
            Console.Write("Input the number in maths:");
            Maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number in Chem");
            Chem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number in Phy");
            Phy = Convert.ToInt32(Console.ReadLine());
            if(Maths <0 || Phy<0 || Chem < 0)
            {
                Console.Write("Inputs cannot be a negative number");
            }
            else if (Maths >= 65 && Phy >= 55 && Chem >= 50 && ((Maths + Phy + Chem) >= 180 || (Maths + Phy) >= 140))
            {
                
                Console.Write("The candidate is eligible for enrollment.");
            }
            else
            {
                Console.Write("The candidate is not eligible for enrollment.");
            }
        }
    }
}