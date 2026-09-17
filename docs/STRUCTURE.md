# Project structure guide

## Layout

| Location | Purpose |
| --- | --- |
| [Challenges/Edabit](../Challenges/Edabit) | Numbered C# challenge implementations and their benchmark classes. |
| [Tests/Edabit](../Tests/Edabit) | NUnit tests corresponding to challenge solutions. |
| [Challenges/Program.cs](../Challenges/Program.cs) | BenchmarkDotNet entry point and configuration. |
| [edabit.sln](../edabit.sln) | Solution containing the challenge and test projects. |

## Test workflow

Restore packages and run the NUnit test project:

~~~powershell
dotnet restore edabit.sln
dotnet test Tests/Tests.csproj
~~~

The source set is a practice collection, so add a test alongside a solution and use the tests as the expected-behavior record for that challenge.

## Benchmark workflow

The challenge project references BenchmarkDotNet. Its current program entry point selects BenchmarkProgram60. Benchmark runs are intentionally more expensive than ordinary tests and may generate result artifacts, so run them only when benchmarking is the goal:

~~~powershell
dotnet run --project Challenges/Challenges.csproj
~~~

To benchmark a different exercise, review the entry point and the relevant benchmark class before changing the selected runner.

## Contribution convention

1. Put the solution in the appropriately numbered challenge location.
2. Add or update its NUnit test.
3. Run the focused test suite.
4. State the challenge title/number and expected behavior in the change description.
