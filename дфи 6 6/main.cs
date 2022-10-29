namespace MordorsCruelPlan
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var wizard = new Wizard("Gandalf the Gray");

            var foodList = Console.ReadLine().Split( );

            foreach (var food in foodList) // для кожного елемента foodlist виконати з класу wizard метод Eat
            {
                wizard.Eat(food);
            }

            Console.WriteLine(wizard);// виводимо wizard
        }
    }
}
