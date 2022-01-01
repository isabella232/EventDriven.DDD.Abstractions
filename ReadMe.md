# EventDriven.DDD.Abstractions

Abstractions for implementing Domain Driven Design in .NET.

## Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download) (6.0 or greater)

## Packages
- [EventDriven.DDD.Abstractions](https://www.nuget.org/packages/EventDriven.DDD.Abstractions)

> **Note**: This package replaces the now _deprecated_ [EventDriven.CQRS.Abstractions](https://www.nuget.org/packages/EventDriven.CQRS.Abstractions) package. The packages have nearly identical API's, but the **DDD** moniker more accurately describes the intent of the library to support a **Domain Driven Design** approach to .NET software development.

## Introduction

[Domain Driven Design](https://en.wikipedia.org/wiki/Domain-driven_design) (DDD) is a software design approach focusing on modelling software to match a domain according to input from domain experts.


The **EventDriven.DDD.Abstractions** library contains interfaces and abstract base classes to support these concepts:
- **Entity**: A type that has an identity with behavior and state that can change over time.
- **Command**: An object that is sent to the domain for a state change which is handled by a command handler.
- **Event**: A statement of fact about what change has been made to the domain state.

### Reference Architecture and Development Guide

Please refer to the [EventDriven.CQRS](https://github.com/event-driven-dotnet/EventDriven.CQRS) repository for a reference architecture and development guide based on Domain Driven Design principles and the **EventDriven.DDD.Abstractions** package.