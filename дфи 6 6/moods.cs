namespace MordorsCruelPlan
{
    public abstract class Mood
    {
        public abstract string Name { get; }
    }

    public class Angry : Mood
    {
        public override string Name => "Angry";
    }

    public class Happy : Mood
    {
        public override string Name => "Happy";
    }

    public class Sad : Mood
    {
        public override string Name => "Sad";
    }


    public class JavaScript : Mood
    {
        public override string Name => "JavaScript";
    }
}