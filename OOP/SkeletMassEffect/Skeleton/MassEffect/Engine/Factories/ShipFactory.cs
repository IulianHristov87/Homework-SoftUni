namespace MassEffect.Engine.Factories
{
    using System;

    using MassEffect.GameObjects.Locations;
    using MassEffect.GameObjects.Ships;
    using MassEffect.Interfaces;

    public class ShipFactory
    {
        public IStarship CreateShip(StarshipType type, string name, StarSystem location)
        {
            switch (type)
            {
                case StarshipType.Frigate:
                    // TODO:
                case StarshipType.Cruiser:
                    // TODO:
                case StarshipType.Dreadnought:
                    // TODO:
                default:
                    throw new NotSupportedException("Starship type not supported.");
            }
        }
    }
}
