# Wiki contribution workflow

The [repository wiki](https://github.com/haribo841/C-Sharp-challenges/wiki) is stored in a separate Git repository, not in the main source checkout. A code push does not publish wiki edits.

## One solution, one page

1. Keep the numeric identifier consistent in the source filename, test filename, solution class, and current wiki page.
2. Use [the source/test catalog](CHALLENGES.md) to resolve titles. Do not assign local reference notes by an old numeric prefix alone.
3. Link the current source and NUnit fixture from each page. Label older diagrams and timings as historical unless they have been reproduced.
4. For a renamed page, keep a short forwarding page so existing links continue to work.
5. Add the entry to `Home.md` and `_Sidebar.md` in the wiki checkout.

## Separate local checkout

~~~powershell
git clone https://github.com/haribo841/C-Sharp-challenges.wiki.git
~~~

Edit the wiki checkout independently. Before publishing either checkout, inspect its status, run the relevant checks, and obtain authorization for that publication. The user's daily limit applies to ordinary repository publications counted as profile contributions. Wiki publications are separate activity and do not consume that limit; they still require publication authorization.

## Checks

~~~powershell
dotnet restore edabit.sln
dotnet test Tests/Tests.csproj --configuration Release
~~~

Check that every current Edabit identifier has exactly one implementation, one test file and one wiki entry, and that the catalog's local links resolve. Advent of Code pages must link their year-specific source and test files as well.

The source repository keeps tests as the expected-behavior record. A copied example or a historical benchmark table is not evidence that the current implementation passes.

Non-numbered shared samples, such as Fibonacci and integer powers, use descriptive wiki page names and link their own source and test files.
