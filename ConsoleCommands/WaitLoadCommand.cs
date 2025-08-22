namespace UCTools_CommandConsole
{
    /// <summary>
    /// Wait load command that pauses execution until level loading is complete
    /// Essential for scripting sequences that depend on scene state
    /// </summary>
    public class WaitLoadCommand : ConsoleCommandBase
    {
        public override string CommandName => "waitload";
        public override string Description => "Wait for level load to complete";
        public override string Category => "Scripting";

        public override void Execute(string[] args, IConsoleContext context)
        {
            if (!ValidateArgumentCount(args, 0, context))
                return;

            context.SetWaitForLoad(true);
            context.WriteLine("Waiting for level load to complete...");
        }

        public override string GetUsage()
        {
            return "Usage: waitload\n" +
                   "Pauses command execution until the current level finishes loading.";
        }

        public override bool ValidateArgs(string[] args)
        {
            return args.Length == 0;
        }
    }
}