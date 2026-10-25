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
dotnet test Tests/Tests.csproj --configuration Release
~~~

The regular start command runs the currently selected BenchmarkDotNet scenario, which is deliberately slower than a unit-test run:

~~~powershell
dotnet run --project Challenges/Challenges.csproj
~~~

See [the project structure guide](docs/STRUCTURE.md) for the testing and benchmark workflow.

## Supported platform

The code retains its historical .NET 7 target. This framework is out of support; the SDK reports warning NETSDK1138. A framework migration is separate from the exercise-numbering update. No graphical interface, package release, or executable download is provided; clone or download the source to explore individual exercises.

## Documentation, license, and support

- [Project structure guide](docs/STRUCTURE.md)
- [Numbered solution and test catalog](docs/CHALLENGES.md)
- [Repository wiki](https://github.com/haribo841/C-Sharp-challenges/wiki) and [wiki contribution workflow](docs/WIKI.md)
- [Previous README archive](docs/archive/README-2026-09-16.md)
- [README before the numbering update](docs/archive/README-2026-10-25.md)
- [License](LICENSE)
- Report a reproducible issue with the challenge number, expected result, actual result, and .NET SDK version.
