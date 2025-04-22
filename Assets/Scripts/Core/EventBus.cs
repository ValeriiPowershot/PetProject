using System;
using System.Collections.Generic;

namespace Core
{
    public class EventBus
    {
        private readonly Dictionary<Type, Delegate> _events = new();

        public void Subscribe<T>(Action<T> listener)
        {
            if (_events.TryGetValue(typeof(T), out Delegate del))
                _events[typeof(T)] = Delegate.Combine(del, listener);
            else
                _events[typeof(T)] = listener;
        }

        public void Unsubscribe<T>(Action<T> listener)
        {
            if (_events.TryGetValue(typeof(T), out Delegate del))
                _events[typeof(T)] = Delegate.Remove(del, listener);
        }

        public void Publish<T>(T eventData)
        {
            if (_events.TryGetValue(typeof(T), out Delegate del))
                ((Action<T>)del)?.Invoke(eventData);
        }
    }
}
