﻿using EventDriven.DDD.Abstractions.Events;

namespace EventDriven.DDD.Abstractions.Commands;

/// <summary>
/// Processes a command by generating a domain event.
/// </summary>
/// <typeparam name="TCommand">Command type.</typeparam>
public interface ICommandProcessor<in TCommand> where TCommand : class, ICommand
{
    /// <summary>
    /// Process specified command by creating a domain event.
    /// </summary>
    /// <param name="command">The command to process.</param>
    /// <returns>Domain event resulting from the command.</returns>
    IDomainEvent Process(TCommand command);
}

/// <summary>
/// Processes a command by generating a domain event.
/// </summary>
/// <typeparam name="TCommand">Command type.</typeparam>
/// <typeparam name="TDomainEvent">Domain event type.</typeparam>
public interface ICommandProcessor<in TCommand, out TDomainEvent>
    where TCommand : class, ICommand
    where TDomainEvent : IDomainEvent
{
    /// <summary>
    /// Process specified command by creating a domain event.
    /// </summary>
    /// <param name="command">The command to process.</param>
    /// <returns>{TDomainEvent} event resulting from the command.</returns>
    TDomainEvent Process(TCommand command);
}