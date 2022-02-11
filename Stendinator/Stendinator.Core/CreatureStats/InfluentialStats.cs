namespace Stendinator.Core.CreatureStats
{
    /// <summary>
    /// Influential stats are the stats that have impact on a creatures health based on the actions performed.
    /// </summary>
    public class InfluentialStats
    {
        public int HealthDecrease { get; set; }
        public int HealthIncrease { get; set; }
        public int DefenseDecrease { get; set; }
        public int DefenseIncrease { get; set; }
    }
}