using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public int Age {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            FindAllNumbersMultiplesOf2();
            ShowAllNames();
            GetReport();

        }

        static void FindAllNumbersMultiplesOf2(){
            List<int> list = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            List<int> evenNumbers = list.FindAll(x =>(x % 2)==0);

            foreach(var num in evenNumbers)
            {
                Console.WriteLine("{0}", num);
            }
            Console.WriteLine();
        } 

        // List thats Containes all Participants name.

        static void ShowAllNames(){
            List<Person> participants = new List<Person>(){
                new Person { FirstName = "Rohit",LastName = "Gore", Age = 22},
                new Person { FirstName = "Gaurav", LastName = "Desai", Age = 23},
                new Person { FirstName = "Rohan", LastName = "Dedge", Age = 20},
                new Person { FirstName = "Anil", LastName = "Kasare", Age = 21},
                new Person { FirstName = "Ganesh", LastName = "Kasare", Age = 24},
                new Person { FirstName = "Rushikesh", LastName = "Jambhulkar", Age = 20}
            };

            var peopleResult = participants.Select(x => new {
                                                               Age=x.Age,
                                                               FirstLatter = x.FirstName,
                                                               LastNameLatter = x.FirstName[0]
                                                            }
                                                  );

            foreach(var person in peopleResult)
            {
                Console.WriteLine(person);
            }
        }

        static void GetReport()
        {
            string[] studants = new string[] { "Akashay","Abhay","Sameer","Gaurav","Nikhil","Vedant","Shubham",
                                                "Anil","Adity","Sanket","Aman","Akhilesh","Lakshuman","Atharv",
                                                "Chetan","Sagar","Omkar","Sidharth","Swapnil","Abhishek","Tanmay"
                                                ,"stifan","Anuj","Yash"
                                            };
        
        var filtarNameByChar = studants.Where(n => n.Contains('i'));
        var namesOrderedBy = filtarNameByChar.OrderBy(n => n.Length);
        var InUpperCase = namesOrderedBy.Select(n => n.ToUpper());

        Console.WriteLine("\nStudents names containing i in Inreasing Order in Upper Case ");

        foreach(var item in InUpperCase)
        {
            Console.WriteLine(item);
        }
        }
    }
}
