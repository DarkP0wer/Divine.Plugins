﻿namespace O9K.Evader.Abilities.Heroes.Lycan.Shapeshift
{
    using Base.Evadable;

    using Core.Entities.Abilities.Base;
    using Core.Entities.Units;

    using Divine;

    using Metadata;

    using Pathfinder.Obstacles.Modifiers;

    internal sealed class ShapeshiftEvadable : ModifierCounterEvadable
    {
        public ShapeshiftEvadable(Ability9 ability, IPathfinder pathfinder, IMainMenu menu)
            : base(ability, pathfinder, menu)
        {
            this.ModifierDisables.UnionWith(Abilities.PhysDisable);
            this.ModifierDisables.UnionWith(Abilities.Root);
        }

        public override bool ModifierEnemyCounter { get; } = true;

        public override void AddModifier(Modifier modifier, Unit9 modifierOwner)
        {
            var obstacle = new ModifierEnemyObstacle(this, modifier, modifierOwner, 500);
            this.Pathfinder.AddObstacle(obstacle);
        }
    }
}