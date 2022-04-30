using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class RockOut : Ability
    {
        public RockOut()
        {
            Name = "Rock Out";
            FlavorText = "The headbanging begins!! And continues all night long!!!";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 12;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
