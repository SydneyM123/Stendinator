namespace Stendinator.Core.Components.Factories
{
    public interface IRandomComponentFactory
    {
        public Component GetRandomComponent(bool malicious);
        public Component GetRandomArm(bool malicious);
        public Component GetRandomLeg(bool malicious);
        public Component GetRandomHead(bool malicious);
        public Component GetRandomTorso(bool malicious);
    }
}