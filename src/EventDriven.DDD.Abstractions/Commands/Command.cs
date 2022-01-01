namespace EventDriven.DDD.Abstractions.Commands;

/// <summary>
/// An object that is sent to the domain for a state change which is handled by a command handler.
/// </summary>
public record Command : ICommand
{
    /// <summary>
    /// Command constructor.
    /// </summary>
    /// <param name="entityId">Represents the ID of the entity the command is in reference to.</param>
    public Command(Guid entityId = default)
    {
        EntityId = entityId;

    }

    /// <inheritdoc />
    public Guid EntityId { get; }
}