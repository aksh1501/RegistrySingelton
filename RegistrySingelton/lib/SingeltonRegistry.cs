using System;

namespace SingletonRegistery{

    class SingletonRegister
    {
        private static SingletonRegister instance;

        private Dictionary < Type, ISingelton > registery;

        private SingletonRegister()
        {
            registery=new Dictionary<Type, ISingelton> ();         
        }


        public static SingletonRegister getRegistery()
        {   
            if(instance==null)
            {
                instance=new SingletonRegister();
            }
        
            return instance;
        }


        public ISingelton getSingelton(Type key)
        {
            if(!registery.ContainsKey(key))
            {
                throw new InvalidDataException("Singleton of type" + key + "is not found.");
            }
           
            return registery[key];
        }

        public void RegisterSingelton(Type key, ISingelton obj)
        {
            if (registery.ContainsKey(key))
            {
                Console.WriteLine("Singleton of type" + key + "is already Registered");
                //throw new InvalidDataException("Singleton of type" + key + "is already Registered.");
            }
            else
            {
                registery[key]=obj;
            }
        }

    }

    interface ISingelton
    {
        void action();
    }


    class Human : ISingelton
    {
        string name;
    
        public Human(string name)
        {
            this.name=name;
        }

        public void action()
        {
            Console.WriteLine("Human " + name);
        }

    }


    class Animal : ISingelton
    {
        string name;

        public Animal(string name)
        {
            this.name=name;
        }

        public void action()
        {
            Console.WriteLine("Animal : " + name);
        }
    }
} 