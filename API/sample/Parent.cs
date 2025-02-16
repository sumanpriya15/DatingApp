namespace API.sample
{
    public class Parent
    {
        public Parent(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public string GetName()
        {
            return Name;
        }
    }
}
