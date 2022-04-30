using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Hurricane : Ability
    {
        public Hurricane()
        {
            Name = "Hurricane";
            FlavorText = "Giant gusts of wind sweep you off your feet.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 12;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
