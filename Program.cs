using ConsoleApp4;

namespace CallingFunctionsEx
{
    internal class Program
    {
        static void Main()
        {
           // patterns.Pattern1();


            //patterns pattobj1 = new patterns();

          //  pattobj1.Pattern2();
            pattern3();
        }
        public int num3 { get; set; }

        public int  NumberFromUser3()
        {
            patterns pattobj2 = new patterns();
            Console.WriteLine("Please enter any number ");
          num3 = Convert.ToInt32(Console.ReadLine());
            return num3;


        }
        public static void pattern3()
        {
            Program abcobj= new Program();
            abcobj.NumberFromUser3();
            for (int G = 1; G <= abcobj.num3; G++)
            {
                for (int H = 1; H <= abcobj.num3; H++)
                {
                    Console.Write(H + " ");
                }

                Console.WriteLine();
            }
        }




    }

}