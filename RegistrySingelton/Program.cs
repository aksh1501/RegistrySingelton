using SingletonRegistery;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Registery of Singeltons");

        SingletonRegister register= SingletonRegister.getRegistery();

        Human h=new Human("Akshit Sharma");

        register.RegisterSingelton(h.GetType(),h);

        Animal elephant=new Animal("Elephant Jumbo");

        Animal bird=new Animal("Bird");

        register.RegisterSingelton(elephant.GetType(),elephant);

        register.RegisterSingelton(bird.GetType(),bird);

        register.getSingelton(typeof(Animal)).action();

        register.getSingelton(typeof(Human)).action();
        

    }
}