using Remora.Commands.Attributes;
using Remora.Commands.Groups;
using Remora.Results;

namespace TestCommandsAssembly;

public class TestClasses : CommandGroup
{
    [Command("ooga")]
    async Task OogaCommand() => await Task.CompletedTask;
    
    [Command("booga")]
    public Task<Result> BoogaCommand() => Task.FromResult(Result.FromSuccess());
    
}