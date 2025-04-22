using System;
using System.Collections.Generic;

public class DIContainer
{
    private readonly Dictionary<Type, object> _services = new();

    public void Register<T>(T instance)
    {
        _services[typeof(T)] = instance;
    }

    public T Resolve<T>()
    {
        return (T)_services[typeof(T)];
    }

    public void Unregister<T>()
    {
        _services.Remove(typeof(T));
    }
}
