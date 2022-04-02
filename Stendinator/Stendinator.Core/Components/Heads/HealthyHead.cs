﻿using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class HealthyHead : Component
    {
        public HealthyHead(bool malicious) : base(new InfluentialStats
        {
            Health = 20 * GameState.Instance.CurrentStage,
            Defense = 10 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                PassiveStats.Health = (int)Math.Ceiling(PassiveStats.Health * 0.8);
            }
        }
    }
}