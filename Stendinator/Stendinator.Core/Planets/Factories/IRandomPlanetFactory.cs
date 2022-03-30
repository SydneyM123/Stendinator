namespace Stendinator.Core.Planets.Factories
{
    internal interface IRandomPlanetFactory
    {
        Planet Create(int difficulty, string name);
    }
}