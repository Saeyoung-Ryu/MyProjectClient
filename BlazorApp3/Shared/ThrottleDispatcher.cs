using System;
using System.Threading;
using System.Threading.Tasks;

public class ThrottleDispatcher
{
    private DateTime _lastInvokeTime = DateTime.MinValue;
    private readonly int _thresholdInMilliseconds;
    private readonly object _lock = new object();

    public ThrottleDispatcher(int thresholdInMilliseconds)
    {
        _thresholdInMilliseconds = thresholdInMilliseconds;
    }

    public bool ShouldInvoke()
    {
        lock (_lock)
        {
            var now = DateTime.UtcNow;
            if ((now - _lastInvokeTime).TotalMilliseconds > _thresholdInMilliseconds)
            {
                _lastInvokeTime = now;
                return true;
            }
            return false;
        }
    }
}