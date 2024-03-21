using System;
using System.Runtime.Intrinsics.X86;


    namespace PASS_WK5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*TODO LIST:
             *
             *  ----- 5min intro/setup -----
             *
             *  Hellos,                        
             *               
             *  ----- 25min to go through this -----
             *
             *  Loop Types recap (2min)
             *  Arrays (15min) from last week (use this if you want to be fancy)
             *  Lists (10min)

             *  ----- 25min to go through this -----
             *
             *  1. Discuss what is a Function
             *  2. Demonstrate and explain Structure
             *  3. Everyone builds there own function for a different purpose
             *                
             *  ----- 5-10 min Q&A -----
             * 
             *   ask anything
             *               
             *  ----- Form/Survey(anon) -----
             *  
             *  https://forms.office.com/r/Y30Gf5ZDVF
             *  
             *  ----- Next week -----
             *  
             *  revise Functions (Module 5)
             *  Objects and Classes (Module 6)
             * 
            */
            int isE = 42;

            bool even = IsEven(isE);

            Console.WriteLine(even);

            //first things first, everyone say Hello or share 1 thing. 
            Console.WriteLine("RB says hi");
            Console.WriteLine("are you worried about devin AI");
            Console.WriteLine("Hey how you doin'?");

            // ----- Arrays ----
            //1. go to Wk4's project to finish Arrays

            double[] myNum = { 10, 20, 30, 40 };

            double Avergae = CalculateAverage(myNum);      

            Console.WriteLine(Avergae);

            

            string[] letterS = { "a", "b", "c" };
            string[] cars = { "volvo", "bmw", "Holden" };



            // ----- Lists ----
            //1. RB will now demonstrate lists, and why they are the go to.

            List<int> newList = new();
            List<string> newList2 = new List<string>();

            newList.Add(1);
            newList2.Add("2");    

            foreach (int i in newList)
            {
                Console.WriteLine($"{i}");
            }



            // ----- Functions ----
            //Definition: 
            //a re-usable code block, also called a method



            // resource -> https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions
            // ----- Functions to make/choose from ----
            // 1. calculate average of numbers from an array - Annaliese
            // 2. a function that tells you if the number is even CR
            // 3. fibonacci sequence
            // 4. sum of Numbers
            // 5. if the number is prime
            // 6. find the highest prime number
            // 7. reverse string 
            // 8. get number from user
         
        }
                    // doing it up here so the screen stops jumping
          
        static int Add(int a, int b)
        {
            return 0;
        }

        static double CalculateAverage(double[] numbers)
        {
            double sum = 0;
            double count = 0;
            foreach (double d in numbers)
            {
                 sum += d;
                 count ++;
            }         

            return sum / count;
        }

        static string GreetUser(string name)
        {
            return "";
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            { return true; }
            return false;
        }

        static int[] GenerateFibonacci(int n)
        {
         
            int[] fibonacciSequence = new int[n];           

            return fibonacciSequence;
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public Person CreatePerson(string name, int age)
        {
            return new Person { Name = name, Age = age };
        }


        static int Multiply(int a, int b)
        {
            return 0;
        }

        static string GetGrade(int score)
        {
            return "";
        }

        static int SumOfNumbers(int n)
        {
            return n;
        }


        static bool IsPrime(int num)
        {
            
            return true;
        }

        static string ReverseString(string input)
        {
            return "";
        }

        static int GetNumberFromUser()
        {
            return 0;
        }

       
            



    }
}
