using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PASS_WK3
{
    internal class Program
    {

        static private string hello = "Hello World";

        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to ISE PASS wk3");

            /*TODO LIST:
             *
             *  ----- 5min intro/setup -----
             *
             *  compare todo list to Assessment
             *
             *  ----- 25min to go through this -----
             *
             *  1. console in/out
             *  2. variable & operations
             *   a. math on numbers
             *   b. string concatination
             *   c. enums (me don't like this one)
             *   d. understanding scope and object permanance
             *  
             *  ----- 5 min Break -----
             *
             *  Go make a coffee and get some biscuits maybe??
             *
             *  ----- 25min to go through this -----
             *
             *  3. LOOPS
             *  4. Conditions / logic (if, else if, else, Switch)
             *  5. show is alpha num??             
             * 
             *  ----- 10 min Q&A -----
             * 
             *  maybe discuss some programming langauges??
             *  
             *  ----- Form/Survey(anon) -----
             *  
            */


            //next week, go through switch, and is alpha num. 



            Console.WriteLine("Input: ");
            int i = Console.Read();
            Console.WriteLine("Input: ");
            int j = Console.Read();

            Console.WriteLine($"addition:{i}+{j}={i+j}");
            Console.WriteLine($"multipl:{i}+{j}={i+j}");

            string tempPassword = "Password1!";


            bool password = false;
            do {
                Console.Write("Input Password: ");
                password = tempPassword == Console.ReadLine();
                //function in here
                //Console.Clear();

                
            } while(!password);


            //loop types
            //while, do while, for, for each, 

            int[] newarry = new int[1];

            for (int k = 0; k < 100; k++)
            {
                Console.WriteLine(k);
            }
            
            while (true)
            {

                break;
            }

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(4);
            list.Add(7);

            foreach (int @int in list)
            { 
                Console.WriteLine(@int);     
            }



        }


    }




}


