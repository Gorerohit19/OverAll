using System;

namespace ExtensionMathod
{

    public sealed class MathsHelper
    {
        public int Addition(int num1, int num2){
            return num1 + num2;
        } 

        public int Subtraction(int num1, int num2){
            return num1 - num2;
        }
    }

    public class Person
    {
        public string GetFullName(){
            return "Rohit Gore";
        }
    }

    public static class UtilityManager
    {
        public static int Multiplication(this MathsHelper m, int num1, int num2){
            return num1 * num2;
        }

        public static int Division(this MathsHelper m, int num1, int num2){
            return num1 / num2;
        }

        public static string GetNationalityDetails(this Person p){
            return "Indian";
        }

        public static string GetStarPrifices(this string name){
            return "*****"+ name;
        }
    }
    
  class Program
  {
    public static void Main(string[] args)
    {
        MathsHelper mathsEngine = new MathsHelper();
        int Number1=50;
        int Number2=30;

        // Intance Method Call
        int result1 = mathsEngine.Addition(Number1, Number2);
        Console.WriteLine("Addition Result =" + result1);

        int result2 = mathsEngine.Subtraction(Number1, Number2);
        Console.WriteLine("Subtraction Result = " + result2);

        // Extension Method Call
        int result3 = mathsEngine.Multiplication(Number1, Number2);
        Console.WriteLine("Multiplication Result = " + result3);

        int result4 = mathsEngine.Division(Number1, Number2);
        Console.WriteLine("Division Result =" + result4);

       Person thePerson = new Person();
       string fullName=thePerson.GetFullName();
       string country=thePerson.GetNationalityDetails();

       Console.WriteLine(fullName+" "+country);

       string state = "Maharashtra";
       Console.WriteLine(state.GetStarPrifices());
    }
  }
}