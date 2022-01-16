using EventDriven.DDD.Abstractions.Entities;

namespace EventDriven.DDD.Abstractions.Commands;

/// <summary>
/// Command handler.
/// </summary>
/// <typeparam name="TCommand">Command type.</typeparam>
public interface ICommandHandler<in TCommand>
    where TCommand : class, ICommand
{
    /// <summary>
    /// Handles a command.
    /// </summary>
    /// <param name="command">The command.</param>
    /// <returns>The command result.</returns>
    Task<CommandResult> Handle(TCommand command);
}

/// <summary>
/// Command handler.
/// </summary>
/// <typeparam name="TEntity">Entity type.</typeparam>
/// <typeparam name="TCommand">Command type.</typeparam>
public interface ICommandHandler<TEntity, in TCommand>
    where TEntity : Entity
    where TCommand : class, ICommand
{
    /// <summary>
    /// Handles a command.
    /// </summary>
    /// <param name="command">The command.</param>
    /// <returns>The command result.</returns>
    Task<CommandResult<TEntity>> Handle(TCommand command);
}
