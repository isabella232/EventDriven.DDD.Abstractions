namespace EventDriven.DDD.Abstractions.Events;

/// <inheritdoc />
public interface IDomainEvent : IEvent
{
    /// <summary>
    /// The id of the entity that this event is "about".
    /// </summary>
    /// <value></value>
    Guid EntityId { get; }
}
