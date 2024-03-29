﻿namespace O9K.Evader.Abilities.Heroes.WraithKing.WraithfireBlast
{
    using Base;
    using Base.Evadable;
    using Base.Usable.CounterAbility;
    using Base.Usable.DisableAbility;

    using Core.Entities.Abilities.Base;
    using Core.Entities.Metadata;

    using Divine;

    [AbilityId(AbilityId.skeleton_king_hellfire_blast)]
    internal class WraithfireBlastBase : EvaderBaseAbility, IEvadable, IUsable<DisableAbility>, IUsable<CounterEnemyAbility>
    {
        public WraithfireBlastBase(Ability9 ability)
            : base(ability)
        {
        }

        public EvadableAbility GetEvadableAbility()
        {
            return new WraithfireBlastEvadable(this.Ability, this.Pathfinder, this.Menu);
        }

        public DisableAbility GetUsableAbility()
        {
            return new DisableAbility(this.Ability, this.Menu);
        }

        CounterEnemyAbility IUsable<CounterEnemyAbility>.GetUsableAbility()
        {
            return new CounterEnemyAbility(this.Ability, this.Menu);
        }
    }
}