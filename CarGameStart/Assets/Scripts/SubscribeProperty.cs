using System;

public class SubscribeProperty<T> : IReadOnlySubscribeProperty<T>
{
    private T _value;
    private Action<T> _onChangeValue;

    public T Value
    {
        get => _value;
        set
        {
            _value = Value;
            _onChangeValue?.Invoke(value);
        }
    }
    public void SubscribeOnChahge(Action<T> subscribeAction)
    {
        _onChangeValue += subscribeAction;
    }

    public void UnSubscribeOnChahge(Action<T> unsubscribeAction)
    {
        _onChangeValue -= unsubscribeAction;
    }

    
  
}
