namespace Stendinator.Core.CreatureStats
{
    internal class CreatureStats
    {
        /// <summary>
        /// The creatures health
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Defense causes less impact of influential stats on Health
        /// </summary>
        public int Defense { get; set; }
    }
}