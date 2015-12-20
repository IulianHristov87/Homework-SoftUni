namespace MassEffect.Engine.Commands
{
    using System;

    using MassEffect.Interfaces;

    public class Command
    {
        public Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public IGameEngine GameEngine { get; set; }

        public void Execute(string[] commandArgs)
        {
            throw new NotImplementedException();
        }
    }
}
