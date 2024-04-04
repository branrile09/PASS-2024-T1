namespace PASS_WK7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int newInt = 3;

            Employee newb = new Employee(3, "RB", false);
            List<Employee> TaskForce = new List<Employee>();

            Employee zombie = new();

            TaskForce.Add(newb);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);
            TaskForce.Add(zombie);

            Console.WriteLine(TaskForce.Count());




            Console.WriteLine($"Hello {newb._name}, your DOB is:{newb._birthDate.day}/{newb._birthDate.month}/{newb._birthDate.year}");


        }
    }
}
