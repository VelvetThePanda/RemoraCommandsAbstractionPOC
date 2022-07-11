using System.ComponentModel;
using Remora.Commands.Attributes;
using Remora.Commands.Groups;
using Remora.Results;

namespace TestCommandsAssembly;

public partial class TestClasses : CommandGroup
{
    [Command("ooga")]
    [Description("It's a command.")]
    async Task OogaCommand() => await Task.CompletedTask;

    [Command("booga")]
    public Task<Result> BoogaCommand() => Task.FromResult(Result.FromSuccess());
}