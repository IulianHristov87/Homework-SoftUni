namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class OverCommand : Command
    {
        public OverCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }
    }
}
