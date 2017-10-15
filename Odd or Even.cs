using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // number styles and Cultre info use this

namespace ConsoleApplication3
{
    class Program
    {
        public int LeftOver; // remainder if its 0 then its odd if its even it will not be so I can test this to see if RandNo is EventArgs or odd
        public int RandNo; //this is my inputted mystery number
        public string Input; //whatever before deciding if number
        double num;
        static void Main(string[] args)
        {


            Console.Write("Check whether a number is even or odd any decimal places will be ignored:\n");    // well just realised if you enter anything but an integer it crashes with an exception google how does parsing work
            Console.Write("------------------------------------------------------------------------:\n");
            Console.Write("--------------- ----Enter Number to be judged --------------------------:\n");
            Console.Write("------------------------------------------------------------------------:\n");
            Console.Write("--------------------Alternatively Q quits ------------------------------:\n"); //lies

            string Input = Console.ReadLine();

         
            double num;
           
            if (double.TryParse(Input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out num))
            {

                int RandNo;// dunno why I have to call this here as I have it as a public int above but it was throwing errors without it
                int LeftOver;

                RandNo = Convert.ToInt32(double.Parse(Input)); // think parsing it as an double is uneeded but seemed to stop exeptions with 1.3 2.6 etc .... convert to int using the convert functions I learnt about trying to do the Hackaday thing


                //google found a guy on stackoverflow who pointed to https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/modulus-operator
                //explains that % is the remainder operator u use it to duuh find the remainder after dividing 2 numbers ie 5 / 2 = 2.5 but you want solid numbers so its
                //also 2 and 1 remainder so 5 % 2 gives you that leftover bit if its not odd then their will be remainder

                LeftOver = RandNo % 2; // remainder when split in 2
                if (LeftOver != 0)  //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/not-equal-operator
                    Console.WriteLine(" {0}) is odd", RandNo);
                // Console.WriteLine("{RandNo} is odd"); wrong
                else // do I not put ; here or next to the if is it all treated as one line
                    Console.WriteLine(" {0}) is Even", RandNo);



                //      // It's a number!
            }
           
            else
                Console.WriteLine("Come on man thats not a number"); //want it to jump to begining like the old JMP command
            Console.ReadKey(); //wait
            

        }
    }
}


//challenge make a console app that filters by odd or even
