namespace MODULE3HW4.delegateTasl
{
    public class MassContainer
    {
        private const int _limit = 200;
        private int _counter = 1;
        
        public event MathMethods.SomeDelegate CounterIsTooBig;

        public void Multiply(int multiplier)
        {
            _counter *= multiplier;

            if (_counter > _limit)
            {
                CounterIsTooBig?.Invoke(_counter / 5, _counter % 7);
            }
        }
    }
}