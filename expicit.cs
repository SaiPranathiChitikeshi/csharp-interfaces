using System;

namespace explic
{
    interface Iinterface_1

{

    void interface1_method();

}
class Class1 : Iinterface_1

{
    public void Display()

    {

        Console.WriteLine("Class1 Display Method.");
        //Call Explicit interface method

        Iinterface_1 obj_1 = new Class1();

        obj_1.interface1_method();

    }

    //Implicit interface implementation

    public void interface1_method()
    {
        Console.WriteLine("Iinterface_1 Method Implicit interface implementation.");

    }

 

    //Explicit interface implementation

    void Iinterface_1.interface1_method()
    {

        Console.WriteLine("Iinterface_1 Method Explicit interface implementation.");

    }

}
    class Program
    {
        static void Main(string[] args)
        {
            Class1 objClass1 = new Class1();

        objClass1.Display(); //Call Implicit interface method
        objClass1.interface1_method();
        Console.ReadLine();
        }
    }
}
