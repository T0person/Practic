namespace Bar
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Кофе темной обжарки";
        }

        public override double cost()
        {
            return .99;
        }
    }
}
