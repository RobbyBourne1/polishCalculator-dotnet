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
            rpnExpression = "12,2.7,-";
            expectedResult = 9.3;
            actualResult = rpc.Calculate(rpnExpression);
            checkResult(rpnExpression, expectedResult, actualResult);

            rpnExpression = "3.5,52,*";
            expectedResult = 182;
            actualResult = rpc.Calculate(rpnExpression);
            checkResult(rpnExpression, expectedResult, actualResult);

            rpnExpression = "4.3,2,/";
            expectedResult = 2.15;
            actualResult = rpc.Calculate(rpnExpression);
            checkResult(rpnExpression, expectedResult, actualResult);
            // Uncomment this test which has many operators
            rpnExpression = "5,1,2,+,4,*,+,3,-";
            expectedResult = 14.0;
            actualResult = rpc.Calculate(rpnExpression);
            checkResult(rpnExpression, expectedResult, actualResult);
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


