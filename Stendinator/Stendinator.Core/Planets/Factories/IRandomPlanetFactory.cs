using Stendinator.Core.Creatures;

namespace Stendinator.Core.Planets.Factories
{
    public interface IRandomPlanetFactory
    {
        Planet Create(string name, Creature player);
    }
}