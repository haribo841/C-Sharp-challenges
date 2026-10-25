# C# coding challenges

A personal collection of C# solutions to Edabit programming challenges. Each exercise is kept with NUnit coverage, while selected solutions also contain BenchmarkDotNet measurements. This is a practice repository, not a distributed application or library.

## What is included

- Numbered challenge implementations under [Challenges/Edabit](Challenges/Edabit).
- Matching NUnit tests under [Tests/Edabit](Tests/Edabit).
- A BenchmarkDotNet entry point for selected implementations.
- A .NET solution targeting .NET 7.

## Quick start

Requirements: .NET 7 SDK.

~~~powershell
dotnet restore edabit.sln
dotnet test Tests/Tests.csproj
~~~

The regular start command runs the currently selected BenchmarkDotNet scenario, which is deliberately slower than a unit-test run:

~~~powershell
dotnet run --project Challenges/Challenges.csproj
~~~

See [the project structure guide](docs/STRUCTURE.md) for the testing and benchmark workflow.

## Supported platform

The code targets .NET 7 and can run on supported .NET platforms. No graphical interface, package release, or executable download is provided; clone or download the source to explore individual exercises.

## Documentation, license, and support

- [Project structure guide](docs/STRUCTURE.md)
- [Previous README archive](docs/archive/README-2026-09-16.md)
- [License](LICENSE)
- Report a reproducible issue with the challenge number, expected result, actual result, and .NET SDK version.
