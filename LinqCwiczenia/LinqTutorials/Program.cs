using System;
using System.Collections.Generic;
using LinqTutorials.Models;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            void ShowTask(IEnumerable<object> t, int n)
            {
                foreach (var emp in t)
                {
                    Console.WriteLine("Task"+n+": "+emp);
                } 
            }
            
            //Task1
            var t1 = LinqTasks.Task1();
            ShowTask(t1,1);
            
            //Task2
            var t2 = LinqTasks.Task2();
            ShowTask(t2,2);
            
            //Task3
            var t3 = LinqTasks.Task3();
            Console.WriteLine("Task3: "+t3);
            
            //Task4
            var t4 = LinqTasks.Task4();
            ShowTask(t4,4);
            
            //Task5
            var t5 = LinqTasks.Task5();
            ShowTask(t5,5);

            //Task6
            var t6 = LinqTasks.Task6();
            ShowTask(t6,6);
            
            //Task7
            var t7 = LinqTasks.Task7();
            ShowTask(t7,7);
            
            //Task8
            var t8 = LinqTasks.Task8();
            Console.WriteLine("Task8: "+t8);
            
            //Task9
            var t9 = LinqTasks.Task9();
            Console.WriteLine("Task9: "+t9);
            
            //Task10
            var t10 = LinqTasks.Task10();
            ShowTask(t10,10);
            
            //Task11
            var t11 = LinqTasks.Task11();
            ShowTask(t11,11);
            
            //Task12
            var t12 = LinqTasks.Task12();
            ShowTask(t12,12);
            
            //Task13
            int[] nowaLista = { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            var t13 = LinqTasks.Task13(nowaLista);
            Console.WriteLine("Task13: "+t13);
            
            //Task14
            var t14= LinqTasks.Task14();
            foreach (var emp in t14)
            {
                //Needs toString method
                Console.WriteLine("Task14: "+emp);
            }
            
            //Task15
            var t15= LinqTasks.Task15();
            foreach (var emp in t15)
            {
                //Needs toString method
                Console.WriteLine("Task15: "+emp);
            }
            
            //Task16
            var t16= LinqTasks.Task16();
            foreach (var emp in t16)
            {
                //Needs toString method
                Console.WriteLine("Task16: "+emp);
            }
        }
    }
}
