using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProject
{
     class TestEmployee
    {
        static void Main()
        {
            Employee emp=new Employee(102,"Sameer","Bangalore",50000,"IT");
            Console.WriteLine(emp[0]);   //once we define Indexer in a class, the class behaves like an virtual array
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            Console.WriteLine(emp[3]);
            Console.WriteLine(emp[4]);

            emp[1] = "Sameer Singh";
            Console.WriteLine(emp[1]);

        }
    }
}
