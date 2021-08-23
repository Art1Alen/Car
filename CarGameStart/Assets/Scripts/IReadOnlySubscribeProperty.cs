using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IReadOnlySubscribeProperty<T>
{
    T Value { get; }
    void SubscribeOnChahge(Action<T> subscribeAction);
    void UnSubscribeOnChahge(Action<T> unsubscribeAction);

}
