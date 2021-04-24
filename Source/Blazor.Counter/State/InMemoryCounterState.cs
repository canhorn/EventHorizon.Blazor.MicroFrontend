namespace Blazor.Counter.State
{
    public class InMemoryCounterState
         : CounterState,
         CounterActions
    {
        public long Count { get; private set; }
        public long Increment { get; private set; } = 1;

        public event CounterStateChanged OnChanged;

        public void SetIncrementAmount(long amount)
        {
            Increment = amount;
            HandleChange();
        }

        public void Trigger()
        {
            Count += Increment;
            HandleChange();
        }

        protected void HandleChange()
        {
            OnChanged?.Invoke();
        }
    }
}