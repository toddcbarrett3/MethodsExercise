namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What id your favorite activity?");
            string activity = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine("Where is your favorite place to be?");
            string place = Console.ReadLine();

            Console.WriteLine($"{name} loves to spend time in {place}.  When {name} is in {place} they like to spend time {activity}.  When {name} gets hungry they like to eat {food}.");

        }
    }
}
