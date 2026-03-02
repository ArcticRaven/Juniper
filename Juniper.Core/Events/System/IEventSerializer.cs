namespace Juniper.Core.Events.System;

public interface IEventSerializer
{
    byte[] Serialize<TEvent>(TEvent @event) where TEvent : IEvent;
    TEvent Deserialize<TEvent>(byte[] data) where TEvent : IEvent;
}