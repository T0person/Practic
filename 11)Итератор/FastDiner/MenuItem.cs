namespace FastDiner
{
    public class MenuItem
    {
        public string Name;
        public string Description;
        public bool Vegetarian;
        public double Price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Vegetarian = vegetarian;
            this.Price = price;
        }
    }
}
