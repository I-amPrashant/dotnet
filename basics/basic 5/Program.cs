using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_5
{
    //internal class Program
    //{
    //    //CONSTRUCTOS 
    //    //they are mainly used to initialize the object instance when created and also to maintain consistency in all instances. 

    //    int a;
    //    string b;

    //    //default constructor
    //    public Program()
    //    {
    //        a = 1;
    //        b = "default value";
    //        Console.WriteLine("constructor is callled");
    //    }


    //    //parameterized constructor. Can be used to assign diff values for diff instances 
    //    public Program(int a, string b)
    //    {
    //        this.a = a;
    //        this.b = b;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Program obj = new Program();//default constructor is called for each instance created.
    //        Program obj2 = new Program();

    //        obj.a = 15;
    //        obj.b = "prashant";
    //        Console.WriteLine($"first: {obj.a}, second: {obj.b} ");//parameterized constructor sets value
    //        Console.WriteLine($"first: {obj2.a}, second: {obj2.b} ");//default constructor sets the value

    //    }
    //}


    //   OOP CONCEPTS

    //INHERITANCE

    //class Rectangle {
    //    public int length;
    //    public int width;

    //    public Rectangle(int l, int w)//parameterized constructor
    //    {
    //        this.length = l; this.width = w;
    //    }

    //    public int GetArea()
    //    {
    //        return length * width;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine($"Length: {length}");
    //        Console.WriteLine($"Width: {width}");
    //        Console.WriteLine("Area: {0}", GetArea());

    //    }
    //}

    //class TableTop : Rectangle//derived:base class. derived class can access public and protected member of base class
    //{
    //    public int cost;
    //    public TableTop(int l, int w):base(l, w) { }//calling the base class constructor using base keyword

    //    public int GetCost()
    //    {
    //        int cost = GetArea() * 20;
    //        return cost;
    //    }

    //    //overloading (same name diff parameter or return type)
    //    //overriding (inherited from base class, use virtual and override keyword and have same parameter return type and name. It completely overrides functionality of the previoud method )
    //    public void Display()//method  overriding 
    //    {
    //        base.Display();//used to explicitly call the Display method of the base class
    //        Console.WriteLine("Cost: {0}", GetCost());
    //    }
    //    public void Display(string c)//method  overloading 
    //    {
    //        base.Display();//used to explicitly call the Display method of the base class
    //        Console.WriteLine("Cost: {0}", GetCost());
    //    }
    //    public void DisplaySame()
    //    {
    //        Console.WriteLine("Area: {0}", GetArea());
    //        Console.WriteLine("Cost: {0}", GetCost());

    //    }
    //}

    ////class interface baseClass1, or class interface baseClass2 because c# doesnot allow multiple inheritance.
    ////class NewClass:baseClass1, baseClass2//multiple inheritance
    //internal class SampleProgram { 
    //    static void Main(string[] args)
    //    {
    //        TableTop t=new TableTop(5, 8);
    //        t.Display();
    //    }
    //}


    //  METHOD HIDING AND OVERRIDING 
    class FirstClass
    {
        public virtual void Display()
        {
            Console.WriteLine("first class method");
        }
    }

    class SecondClass:FirstClass {
        public override void Display() {//overriding Display method
            base.Display();
            Console.WriteLine("derived class method");
        }

        //public new void Display()//METHOD HIDING 
        //{
        //    base.Display();
        //    Console.WriteLine("derived class method");
        //}
    }

    class MainClass
    {
        static void Main(string[] args)
        {
                SecondClass t= new SecondClass();    
                t.Display();

        }
    }
}


