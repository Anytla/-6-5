
namespace MordorsCruelPlan
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var wizard = new Wizard("Gandalf the Gray");

            var foodList = Console.ReadLine().Split();

            foreach (var food in foodList)
            {
                wizard.Eat(food);
            }

            Console.WriteLine(wizard);
        }
    }
}