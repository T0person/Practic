namespace Bar
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "Домашняя смесь";
        }
        public override double cost()
        {
            return .89;
        }
    }
}
