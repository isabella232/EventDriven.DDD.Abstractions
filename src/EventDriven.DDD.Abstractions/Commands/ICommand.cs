namespace EventDriven.DDD.Abstractions.Commands;

/// <summary>
/// An object that is sent to the domain for a state change which is handled by a command handler.
/// </summary>
public interface ICommand
{
    /// <summary>
    /// Represents the ID of the entity the command is in reference to.
    /// </summary>
    Guid EntityId { get; }
}