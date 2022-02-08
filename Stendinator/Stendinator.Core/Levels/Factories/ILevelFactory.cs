namespace Stendinator.Core.Levels.Factories
{
    public interface ILevelFactory
    {
        Level Create(ILevelFactoryModel model);
    }

    public interface ILevelFactoryModel
    {
    }
}