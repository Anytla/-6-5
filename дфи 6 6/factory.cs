namespace MordorsCruelPlan
{
    public class FoodFactory
    {
        public Food GetFood(string name)
        {
            switch (name.ToLower())
            {
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new Apple();
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new OtherFood(name);
            }
        }
    }

    public class MoodFactory
    {
        public Mood GetMood(int points)
        {
            if (points < -5)
            {
                return new Angry();
            }
            else if (points >= -5 && points <= 0)
            {
                return new Sad();
            }
            else if (points > 0 && points <= 15)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}