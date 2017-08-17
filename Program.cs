using System;

namespace Daily_Project_Reverse_Polish_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var rpc = new ReversePolishCalc();

            var rpnExpression = "2.5,4.8,+";
            var expectedResult = 7.3;
            var actualResult = rpc.Calculate(rpnExpression);
            checkResult(rpnExpression, expectedResult, actualResult);

            // Write tests for the other operators (-, *, /)

            // Uncomment this test which has many operators
            //        rpnExpression = "5,1,2,+,4,*,+,3,-";
            //        expectedResult = 14.0;
            //        actualResult = rpn.calculate(rpnExpression);
            //        checkResult(rpnExpression, expectedResult, actualResult);
        }

        private static void checkResult(String expression, double expected, double actual)
        {
            if (expected == actual)
            {
                Console.WriteLine("SUCCESS: " + expression + " is " + expected);
            }
            else
            {
                Console.WriteLine("ERROR: " + expression + " expected " + expected + " actual " + actual);
            }
        }
    }
}


