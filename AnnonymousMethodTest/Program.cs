using System;

namespace AnnonymousMethod
{
    public delegate void BasicOpration();
    public delegate void DoSomeThing();
    public delegate int AnnonymousOpration1(int i);
    public delegate int AnnonymousOpration2(int a, int b);
    class Program
    {
        //Call Back Function
        void PrintReport()
        {
            Console.WriteLine(" Printing Report Represent : Graph, Table, ScoreCard ...");
        }
    static void Main(string[] args)
    {
        //Registering Function
        Program theProgram = new Program();
        //Registering Callback Function
        BasicOpration opration1 = new BasicOpration(theProgram.PrintReport);
        // Resolving Name Of Function At Runtime
        opration1();

        //Inline Function
        //Annonymous Method
        BasicOpration opretion2 = delegate(){
            Console.WriteLine(" Printing the Annual Report of Company ...");
        };
        opretion2();

        //Lambda 
        DoSomeThing opration3=()=>{Console.WriteLine(" Printing COVID Spread Report");};
        opration3();

        AnnonymousOpration1 proxy1 = new AnnonymousOpration1(
                                                              delegate(int x){
                                                                return x * 2;
                                                              }
                                                            );
        Console.WriteLine("{0}", proxy1(2));

        AnnonymousOpration1 proxy2 =x=>x*2; // Use of Lambda 
        Console.WriteLine("{0}", proxy2(25));

        //(InputParameter) => Expression
        AnnonymousOpration2 getBigNumber = (x, y) => {if (x > y) return x ; else return y ;};
        Console.WriteLine(getBigNumber(45,30));
    }    
    }
}

