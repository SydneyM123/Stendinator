namespace Stendinator.Core.Planets.Factories
{
    public interface IRandomPlanetFactory
    {
        Planet Create(int difficulty, string name);
    }
}