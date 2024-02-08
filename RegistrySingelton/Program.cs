using SingletonRegistery;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Registery of Singeltons");

        SingletonRegister register= SingletonRegister.getRegistery();

        Human h=new Human("Akshit Sharma");

        register.RegisterSingelton(h.GetType(),h);

        Animal elephant1=new Animal("Elephant Jumbo");

        Animal elephant2=new Animal("Elephant Simba");

        register.RegisterSingelton(elephant1.GetType(),elephant1);

        register.RegisterSingelton(elephant2.GetType(),elephant2);

        register.getSingelton(typeof(Animal)).action();

        register.getSingelton(typeof(Human)).action();
        

    }
}