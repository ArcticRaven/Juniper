namespace Juniper.Core.Events.System;

public interface IEventRegistry
{
    void Register<TEvent>() where TEvent : IEvent;
    bool IsRegistered<TEvent>() where TEvent : IEvent;
    Task DispatchAsync<TEvent>(TEvent @event) where TEvent : IEvent;
    void Subscribe<TEvent>(Func<TEvent, Task> handler) where TEvent : IEvent;
    void Unsubscribe<TEvent>(Func<TEvent, Task> handler) where TEvent : IEvent;
    IReadOnlyList<Type> RegisteredEvents { get; }
}