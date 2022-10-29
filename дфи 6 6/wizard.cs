using System.Text;

namespace MordorsCruelPlan
{
    public class Wizard
    {
        private int happinessPoints;
        private Mood mood;
        private MoodFactory moodFactory;
        private FoodFactory foodFactory;

        public Wizard(string name)
        {
            this.Name = name;
            this.happinessPoints = 0;
            this.moodFactory = new MoodFactory();
            this.foodFactory = new FoodFactory();
        }

        public string Name { get; }

        public void Eat(string foodName)
        {
            var food = this.foodFactory.GetFood(foodName);// перевіряємо до чого належить
            this.happinessPoints += food.Points; // додаємо очки щастя
            this.mood = this.moodFactory.GetMood(this.happinessPoints);// перевіряємо чому належить така к-сть очок
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.happinessPoints.ToString());//перетворює в рядок
            sb.Append(this.mood.Name);
            return sb.ToString();
        }
    }
}
