using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class patterns
    {
        int num1 { get; set; }
        int num2 { get; set; }


        public void NumberFromUser1()
        {
            Console.WriteLine("Please enter any number");
            num1=Convert.ToInt32(Console.ReadLine());
        }
        public int NumberFromUser2() 
        {
            Console.WriteLine("Please Enter Any Number");
            num2=Convert.ToInt32(Console.ReadLine());
            return num2;
        }
        public static void Pattern1()
        {
          patterns PattObj= new patterns();
            PattObj.NumberFromUser2();


            for (int A = 1; A <= PattObj.num1; A++)
            {
                for( int B = 1; B<= PattObj.num1; B++)
                {
                    Console.WriteLine(B + " ");
                }
            }
            
        }
        public void Pattern2() 
        {
            NumberFromUser1();

            for (int E = num1; E >= 1; E--)
            {
                for (int F = num1; F >= 1; F--)
                {
                    Console.Write(" " + Convert.ToChar(64 + F));
                }

                Console.WriteLine();

            }
        }
        
    }
}
