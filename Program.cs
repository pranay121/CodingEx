//using System;
//using System.Runtime.InteropServices;

//namespace Coding
//{

//    // Base class
//    class My_Parent
//    {
//        int i = 19;
//        // virtual method
//        public void display()
//        {
//            Console.WriteLine("My new parent class.. !" + i);
//        }
//    }

//    // Derived class
//    class My_Child : My_Parent
//    {
//        int i = 8;
//        // Here display method is overridden
//        public void displaychild()
//        {
//            Console.WriteLine("My new child class.. !" + i);
//        }
//    }

//    class GFG
//    {

//        // Main Method
//        public static void Main()
//        {

//            My_Parent obj;

//            // Creating object of the base class
//            obj = new My_Child();

//            Console.WriteLine("P ref" + obj.GetType());

//            // Invoking method of the base class
//            obj.display();

//            // Creating object of the derived class
//            My_Child obj1 = new My_Child();

//            // Invoking method of derived class
//            obj1.display();
//        }
//    }
//}
