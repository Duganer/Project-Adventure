using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class HeavenlyBody : Ability
    {
        public HeavenlyBody()
        {
            Name = "Heavenly Body";
            FlavorText = "Bring the heavens to the earth.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 10;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
