using Spectre.Console;

namespace SingleCommand;

public interface IGreeter
{
    void Greet(string name);
}

public sealed class HelloWorldGreeter : IGreeter
{
    public void Greet(string name)
    {
        AnsiConsole.MarkupLine($"[yellow]Hello[/]");
    }
}