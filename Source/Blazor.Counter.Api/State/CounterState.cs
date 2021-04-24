namespace Blazor.Counter.State
{
    public interface CounterState
    {
        long Count { get; }
        long Increment { get; }
    }
}