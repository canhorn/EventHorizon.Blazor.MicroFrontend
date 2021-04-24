namespace Blazor.Counter.State
{
    public delegate void CounterStateChanged();

    public interface CounterActions
    {
        event CounterStateChanged OnChanged;

        void Trigger();
        void SetIncrementAmount(
            long amount
        );
    }
}