namespace PASS_WK4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Ctrl+D to duplicate = efficient programming");

            Console.WriteLine("hello!! ");

            Console.WriteLine(" Hey People ");


            /*TODO LIST:
             *
             *  ----- 5min intro/setup -----
             *
             * hellos
             *
             *  ----- 25min to go through this -----
             *
             *  Loop Types (10min)
             *  Arrays (10min)
             *  Lists (5min)
             *  
             *  ----- 25min to go through this -----
             *
             *  Switch (5min)
             *  Enums   (5min)
             *  
             *  Nested Loops (10-15min)
             * 
             *  ----- 5-10 min Q&A -----
             * 
             * ask anything
             *                           
             *  ----- Next week -----
             *  
             *  Functions/Methods
             *      Explanation
             *      Structure
             *      Building
             *      
             * 
            */


            // ----- Loops ----

            //(Annaliese)
            //1. while loop 

            int f = 2;
            while (f < 10)
            {
                Console.WriteLine(f);
                f++;
            }
            Console.WriteLine("value of f: {0}", f);

            //2. Do while loop

            int p = 0;
            do
            {
                Console.WriteLine(p);
                p++;
            }
            while (p < 6);
            // 2) explanation: DO p will increase by 1 until it counts to <6 WHILE: it will stopping at < 6
            //a) explanation: f = 2 while f is less than 10 it will loop and continully increment f by 1 until it is 10  then iexplanation:
             /* 
            */
            //b) example code (loop while meaning of life is != 42 )



            //Chaitan
            //3. For loop
            //a) explanation : 
            //b) example code (100 iterations, number starts at 1, triple it, then half it) ()
            //int stored value
            float number = 1;
            for (int i = 1; i <= 100; i++)
            {
                number *= 3;
                number /= 2;
                Console.WriteLine(number);
            }

            //cout << stored value


            //4, Foreach 
            //a) explanation
            // Allows you to go through the elements of a collection. (taner)
            //b) example code (iterate through each char in "HiPpoPlatyroo", then output how many vowels in the word  )

            string letters = "HiPpoPlatyrOo";
            string vowels = "aeiou";
            string tempLetters = letters.ToLower();
            int vowelQuantity = 0;


            foreach (char c in tempLetters)
            {
                foreach (char c2 in vowels)
                {
                    if (c2 == c)
                    {
                        vowelQuantity++;
                        continue;
                    }
                }    
            }

            Console.WriteLine(vowelQuantity);


            // resource -> https://www.w3schools.com/cs/cs_arrays.php
            // resource -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays (i like this one a little better)
            // ----- Arrays ----
            //1. Create an Array
            {
                string[] sport = { "basketball", "Cricket", "tenis" };
                Console.WriteLine(sport[0]);
            }







        }
    }
}