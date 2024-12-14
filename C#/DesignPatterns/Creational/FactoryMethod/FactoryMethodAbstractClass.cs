namespace DesignPatterns.FactoryMethod;

using System;



abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public string SomeOperation()
    {
        var product = FactoryMethod();

        var result = product.Operation();

        return result;
    }

}

 class  ConcreateCreator1 : Creator
 {
    public override  IProduct FactoryMethod()
    {
        return new ConcreateProduct1();      
    }
 }

 class  ConcreateCreator2 : Creator
 {
    public override  IProduct FactoryMethod()
    {
        return new ConcreateProduct2();      
    }
 }

class Program
{
    public static void Main(string[] args)
    {
        
    }
    
}