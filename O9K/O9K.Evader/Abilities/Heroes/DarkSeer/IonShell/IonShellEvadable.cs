﻿namespace O9K.Evader.Abilities.Heroes.DarkSeer.IonShell
{
    using Base.Evadable;

    using Core.Entities.Abilities.Base;
    using Core.Entities.Units;

    using Divine;

    using Metadata;

    using Pathfinder.Obstacles.Modifiers;

    internal sealed class IonShellEvadable : ModifierCounterEvadable
    {
        public IonShellEvadable(Ability9 ability, IPathfinder pathfinder, IMainMenu menu)
            : base(ability, pathfinder, menu)
        {
            this.ModifierDisables.UnionWith(Abilities.EnemyPurge);

            this.ModifierCounters.UnionWith(Abilities.MagicShield);
        }

        public override bool ModifierEnemyCounter { get; } = true;

        public override void AddModifier(Modifier modifier, Unit9 modifierOwner)
        {
            var obstacle = new ModifierEnemyObstacle(this, modifier, modifierOwner, this.ActiveAbility.Radius);
            this.Pathfinder.AddObstacle(obstacle);
        }
    }
}