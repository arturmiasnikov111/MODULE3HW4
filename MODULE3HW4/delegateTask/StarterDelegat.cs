using System;

namespace MODULE3HW4.delegateTasl
{
    public class StarterDelegat
    {
        public void Run()
        {
            var massContainer = new MassContainer();
            var mathMethods = new MathMethods();
            
            massContainer.CounterIsTooBig += mathMethods.Sum;
            massContainer.CounterIsTooBig += mathMethods.Sum;

            for (int i = 0; i < 10; i++)
            {
                massContainer.Multiply(5);
            }
            
            foreach (var item in mathMethods.results)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}