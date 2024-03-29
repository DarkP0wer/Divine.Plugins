﻿namespace O9K.Evader.Abilities.Items.Bloodstone
{
    using Base;
    using Base.Usable.CounterAbility;

    using Core.Entities.Abilities.Base;
    using Core.Entities.Metadata;

    using Divine;

    [AbilityId(AbilityId.item_bloodstone)]
    internal class BloodstoneBase : EvaderBaseAbility, IUsable<CounterAbility>
    {
        public BloodstoneBase(Ability9 ability)
            : base(ability)
        {
        }

        public CounterAbility GetUsableAbility()
        {
            return new CounterHealAbility(this.Ability, this.Menu);
        }
    }
}