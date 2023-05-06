using System;

namespace GovtLib
{
    public class TaxManager
    {
        public void PayIncomeTax()
        {
            Console.WriteLine(" Income Tax Has Been Deducted From Your Account ...");
        }

        public void PayServiceTax()
        {
            Console.WriteLine(" Service Tax Has Been Deducted From Your Account ...");
        }

        public void PayTDSTax()
        {
            Console.WriteLine(" TDS Tax Has Been Deducted From Your Account ...");
        }
    }
}