namespace Stendinator.Core.Components.Factories
{
    public interface IActiveComponentFactory
    {
        ActiveComponent Create(string name, bool malicious);
        string[] GetNames();
    }
}