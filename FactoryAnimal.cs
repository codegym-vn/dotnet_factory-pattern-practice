namespace Practice_Factory
{
    public class AnimalFactory
    {
        public IAnimal GetAnimal(string animal)
        {
            switch (animal)
            {
                case "dog":
                    return new Dog();
                default:
                    return new Cat();
            }
        }
    }
}