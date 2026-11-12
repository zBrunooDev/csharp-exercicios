using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDelegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperation2(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);

            // double result = op(a, b);
            double result = op.Invoke(a, b);

            Console.WriteLine(result);

            Console.WriteLine("----------------------------------------------------");
            // Example of multicast delegates

            double d = 10;
            double e = 12;

            BinaryNumericOperation2 op1 = CalculationService.ShowSum;
            op1 += CalculationService.ShowMax;
            op1(d, e);


        }
    }   
}
