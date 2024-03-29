﻿namespace O9K.Evader.Abilities.Heroes.Chen.HolyPersuasion
{
    using Base.Evadable;
    using Base.Usable;

    using Core.Entities.Abilities.Base;
    using Core.Entities.Units;

    using Divine;

    using Metadata;

    using Pathfinder.Obstacles;

    internal sealed class HolyPersuasionEvadable : ModifierCounterEvadable
    {
        public HolyPersuasionEvadable(Ability9 ability, IPathfinder pathfinder, IMainMenu menu)
            : base(ability, pathfinder, menu)
        {
            this.ModifierDisables.Add(Abilities.EulsScepterOfDivinity);
            this.ModifierDisables.Add(Abilities.WindWaker);
            this.ModifierDisables.Add(Abilities.Glimpse);
        }

        public override bool ModifierEnemyCounter { get; } = true;

        public override void AddModifier(Modifier modifier, Unit9 modifierOwner)
        {
            var obstacle = new HolyPersuasionEvadableModifier(this, modifier, modifierOwner, 1000);
            this.Pathfinder.AddObstacle(obstacle);
        }

        public override bool IgnoreRemainingTime(IObstacle obstacle, UsableAbility usableAbility)
        {
            return false;
        }
    }
}