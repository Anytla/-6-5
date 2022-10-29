namespace MordorsCruelPlan
{
    public abstract class Food
    {
        public abstract string Name { get; } // вводимо назву їжі яку споживає Гендельф

        public abstract int Points { get; } // вводимо очки які відповідають кожній страві
    }

    public class Apple : Food
    {
        public override string Name => "Apple";// яблуко

        public override int Points => 1; // одне очко щастя
    }

    public class Cram : Food
    {
        public override string Name => "Cram";

        public override int Points => 2;
    }

    public class HoneyCake : Food
    {
        public override string Name => "Honey Cake";

        public override int Points => 5;
    }

    public class Lembas : Food
    {
        public override string Name => "Lembas";

        public override int Points => 3;
    }

    public class Melon : Food
    {
        public override string Name => "Melon";

        public override int Points => 1;
    }

    public class Mushrooms : Food
    {
        public override string Name => "Mushrooms";

        public override int Points => -10;
    }

    public class OtherFood : Food
    {
        public OtherFood(string name) // інша їжа
        {
            this.Name = name;
        }

        public override string Name { get; }

        public override int Points => -1;
    }
}
