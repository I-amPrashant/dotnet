using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_4
{

    // CLASS AND OBJECTS BASICS

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SampleClass Obj1 = new SampleClass();
    //        Obj1.firstVar = 1;//public field
    //        Console.WriteLine(Obj1.firstVar);
    //        //Obj1.secondVar = 1; //private field(not accessible)
    //        Obj1.SetPropertiesY = 10;//setting value of private field
    //        Console.WriteLine("getting value of private field secondVar:  {0}", Obj1.SetPropertiesY);//getting private values 

    //        //using the method to display both public and private field or values
    //        Obj1.Show();
    //    }

    //}

    //public class SampleClass{
    //    public int firstVar;
    //    private int secondVar;

    //    public int SetPropertiesY
    //    {
    //        get { return secondVar; }
    //        set { secondVar = 10; }
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine($"{firstVar}, {secondVar}");
    //    }
    //}

    //AUTO IMPLEMENTED PROPERTIES

    //class SampleProgram
    //{
    //    public int SetProperty { get; set; }//auto implemented properties(automatically get and set fields with simple operations)
    //    static public int x;//static value(can be accessed without instance of the class).
    //}

    //class MainProgram { 
    //    static void Main(string[] args)
    //    {
    //        SampleProgram Obj1 = new SampleProgram();

    //        Obj1.SetProperty = 1;
    //        Console.WriteLine($"{Obj1.SetProperty}");
    //        Obj1.SetProperty = 20;
    //        Console.WriteLine($"{Obj1.SetProperty}");

    //        //accessing static field of SampleProgram class
    //        SampleProgram.x = 333;
    //        Console.WriteLine(SampleProgram.x);
    //    }
    //}
}
