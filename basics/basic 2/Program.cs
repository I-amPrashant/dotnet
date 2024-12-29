using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_2
{

    //PASSING OBJECT BY REFERENCE

    //internal class ReferencedClass
    //{
    //    public int value;
    //}


    //class MainClass {
    //    static void Main(string[] args)
    //    {

    //var can be used to automatically determine the type of variable based on the value assigned to it 

    //        var newObj=new ReferencedClass();
    //        newObj.value = 40;
    //        modifyObject(newObj);
    //        Console.WriteLine(newObj.value);
    //    }

    //    static void modifyObject(ReferencedClass obj)
    //    {
    //        obj.value = 33;
    //        Console.WriteLine(obj.value);
    //    }
    //}

    // PASSING VARIABLE BY VALUE
    //passing the copy of the data(changes doesnot reflect in the original data)

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int a = 10;
    //        Console.WriteLine(a);
    //        modifyValue(a);
    //        Console.WriteLine(a);
    //    }

    //    static void modifyValue(int i)
    //    {
    //        i = 20;
    //        Console.WriteLine(i);
    //    }
    //}



    //PASSING VARIABLE BY REFERENCE
    //passing the memory address(changes reflect in the original data)
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            modifyValue(ref a);
            Console.WriteLine(a);
        }

        static void modifyValue(ref int i)
        {
            i = 20;
            Console.WriteLine(i);
        }
    }

}
