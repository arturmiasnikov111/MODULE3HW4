using System;
using System.Collections.Generic;

namespace MODULE3HW4.delegateTasl
{
    public class MathMethods
    {

        private int SumCallsCount = 1;
        public List<int> results { get; set; }

        public MathMethods()
        {
            results = new List<int>();
        }

        public delegate int SomeDelegate(int a, int b);

        public int Sum(int a, int b) => SaveDelegateCall(InternalSum, a, b);
        private int InternalSum(int a, int b) => a + b;
        private int SaveDelegateCall(SomeDelegate sum, int a, int b)
        {
            SumCallsCount++;
            try
            {
                int result = sum(a, b);
                results.Add(result);
                return result;
            }
            catch
            {
                throw new ArgumentException("Something bad has been happened");
            }
        }
        
    }
}