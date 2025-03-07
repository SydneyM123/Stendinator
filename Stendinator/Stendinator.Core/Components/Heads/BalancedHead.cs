﻿using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class BalancedHead : Component
    {
        public BalancedHead(bool malicious) : base(new InfluentialStats
        {
            Health = 15 * GameState.Instance.CurrentStage,
            Defense = 8 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                Passives.Health = (int)Math.Ceiling(Passives.Health * 0.8);
            }
        }
    }
}