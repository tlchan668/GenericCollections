using System;
using System.Collections.Generic;

namespace GenericCollections {
    class Program {
        static void Main(string[] args) {

            //dynamic arrays
            //collection of ints  list is class name usin capstone can pu t\\
            var ints = new List<int>();
            //add some things to collection
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            var numberInList = ints.Count; //tells how many are in your collection
            //ints.Capacity; //says how many things can I put in 
            //print off items in list
            Console.WriteLine($"Number of ints is {ints.Count}");
            //print off items in collection using foreach, for or while
            foreach(var anInt in ints) {
                //variant of console.writeline to stay on same line
                Console.Write($" {anInt} ");
            }
            //want to take 2 out 
            ints.Remove(2);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints) {
                Console.Write($" {anInt} ");
            }

            //create a generic collections of strings and put in everyones first name
            //print those out
            var students = new List<string>();
            students.Add("Traci");
            students.Add("Danea");
            students.Add("Robbie");
            students.Add("Armon");
            students.Add("Vaughn");
            students.Add("Manish");
            students.Add("George");
            students.Add("Parker");
            students.Add("Laura");
            students.Add("Ian");
            students.Add("Sarah");
            students.Add("David");

            foreach (var astudent in students) {
                Console.Write($" {astudent } ");
            }
            Console.WriteLine($"Number of ints is {students.Count}");

            //create some instances of customre and load into dynamic array
            //generic array of strings
            var customers = new List<Customer>();
            //create an instance of our customer
            var amazon = new Customer(1, "Amazon", true);
            var pg = new Customer(2, "P&G", true);
            //another way to initialze constructors better way
            var meijer = new Customer { Id = 3, Name = "Meijer", Active = true };
            var target = new Customer { Id = 4, Name = "Target"};//leave active out of list because default is active
            var microsoft = new Customer { Id = 5, Name = "Microsoft", Active = false };
            //put into our collection
            customers.Add(amazon);
            customers.Add(pg);
            Console.WriteLine();
            //can add multiple prolly unlikly to do with small items but with bigger collections that 
            //might be passed to you from sql other formats
            var custArray = new Customer[] { meijer, target, microsoft };
            customers.AddRange(custArray);
            //list out our customers only if active
            foreach (var customer in customers) {
                if (customer.Active == false) {
                    continue;
                }
                Console.Write($"Customer {customer.Id} Name={customer.Name} " );
            }
            Console.WriteLine();
            //give me the name of the customer with id of 3
            //gregs way better way
            var custName = "Not Found;";
            foreach(var cust in customers) {
                if (cust.Id == 3) {
                    custName = cust.Name;
                    break;
                }
            }
            Console.WriteLine($"gregs way  {custName}");
            //my way
            foreach (var customer in customers) {
                if (customer.Id!=3) {
                    continue;
                }
                Console.WriteLine($"Name={customer.Name} ");
            }


            //dictionary how to return just an id of 3
            var custDictionary = new Dictionary<int, Customer>();
            //add data to dictionary
            custDictionary.Add(amazon.Id, amazon);//juse the key value and the whole instance of customer
            custDictionary.Add(target.Id, target);
            custDictionary.Add(pg.Id, pg);
            custDictionary.Add(microsoft.Id, microsoft);
            custDictionary.Add(meijer.Id, meijer);

            //wanted to print off customer with id 3
            var cust2 = custDictionary[3];
            Console.WriteLine($"customer id 3 with dict is {cust2.Name}");
            Console.WriteLine($"customer id 3 with dict is  and no var{custDictionary[3].Name}");

            //get customer for id 2
            //my way better way
            Console.WriteLine($"customer 2 with dict is {custDictionary[2].Name}");
            //gregs way
            cust2 = custDictionary[2];
            Console.WriteLine($"Gcustomer id 2 with dict is {cust2.Name}");

            foreach (var key in custDictionary.Keys) {
                //gives just keys in dictionary now can 
                var customer = custDictionary[key];//now hold them in customer
                Console.WriteLine($"{customer.Name}");

                //want to sequence would have to sort the keys
                
            }

        }
    }
}
