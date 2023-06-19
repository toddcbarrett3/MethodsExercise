namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1:

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What id your favorite activity?");
            string activity = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine("Where is your favorite place to be?");
            string place = Console.ReadLine();

            Console.WriteLine($"{name} loves to spend time in {place}.  When {name} is in {place} they like to spend time {activity}.  When {name} gets hungry they like to eat {food}.");


            //Exercise 2: (Methods are on seraparate tab)

            Console.WriteLine("Do you want to \"Add\", \"Subtract\", \"Multiply\", or \"Divide\" 2 numbers?");
            string math = Console.ReadLine();

            Console.WriteLine("First Number?");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Number?");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            if(math == "Add") 
            {
                Method1.Add(num1, num2);
            }
            else if (math == "Subtract")
            {
                Method1.Subtract(num1, num2);
            }
            else if (math == "Multiply")
            {
                Method1.Multiply(num1, num2);
            }
            else if (math == "Divide")
            {
                Method1.Divide(num1, num2);
            }
            else
            {
                Console.WriteLine("Try Again - Make Sure to Capitalize the First Letter!");
            }
        }
    }
}
