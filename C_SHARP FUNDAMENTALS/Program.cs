namespace C_SHARP_FUNDAMENTALS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = 50;
            int b = 200;
            //Console.WriteLine(a+b);

            float A = 2.5f;
            float B = 2.5f;
           // Console.WriteLine(A+B);

            double c = 2.3;
            double d = 2.3;
            //Console.WriteLine(c + d);

            //Console.WriteLine(A/B);
            //Console.WriteLine(a-b);
            //Console.WriteLine(a * c);

            if (a < b)
            {
                if (A != B || c!=d)
                {
                    Console.WriteLine("Sucess");
                }
                else
                {
                    Console.WriteLine("A is equal to B");
                }
            }
            else
            {
                Console.WriteLine("False");
            }


           /* int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                case 3:
                    Console.WriteLine("case 3");
                    break;
                default:
                    Console.WriteLine("False");
                    break;
            }*/


            //int i;
            //int j;
            //for(i=0; i <= 5; i++)
            //{
            //   for (j = 0; j <= 5; j++)
            //   {
            // Console.WriteLine("j= "+j);
            //   }
            //Console.WriteLine("i= "+i);
            //   }

            // int i=0;
            // while (i < 5)
            //{
            //  Console.WriteLine(i);
            //  i++;
            //}

            // int i = 0;
            // do
            // {
            //    Console.WriteLine(i);
            //   i++;
            //  }
            // while (i < 0);

           /* int age = 10;
            
            if (age > 18)
            {
                goto g;
            }
            else
            {
                Console.WriteLine(" you can not vote");
            }

            g:
            {
                Console.WriteLine(" you can vote ");
            }*/
            


        }
    }
}