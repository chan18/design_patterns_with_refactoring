
using System;

namespace DesignPatterns.FactoryMethod;


public interface IProduct
{
    string Operation();
}

public class ConcreateCreator2 : IProduct
{
    public string Operation()
    {
        return "";
    }
}

public class ConcreateCreator1 : IProduct
{
     public string Operation()
    {
        return "";
    }   
}

public class Client
{
        public void Main()
        {
            ClientCode(new ConcreateCreator1());
            ClientCode(new ConcreateCreator2());
        }

        public void ClientCode(Creator creator)
        {
            creator.SomeOperation();
        }

}


/// <summary>
/// Main Program
/// </summary>
public class Program
{
    static void Main(string[] args)
    {
        new Client().Main();
    }
}