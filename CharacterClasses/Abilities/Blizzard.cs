using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Blizzard : Ability
    {
        public Blizzard()
        {
            Name = "Blizzard";
            FlavorText = "Lose sight and continue to get pelted by snow.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 10;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 6;
        }
    }
}
