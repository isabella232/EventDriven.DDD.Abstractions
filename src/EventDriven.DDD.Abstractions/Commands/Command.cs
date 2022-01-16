using EventDriven.DDD.Abstractions.Entities;

namespace EventDriven.DDD.Abstractions.Commands;

/// <summary>
/// An object that is sent to the domain for a state change which is handled by a command handler.
/// </summary>
public record Command(Guid EntityId = default, IEntity? Entity = null) : ICommand;