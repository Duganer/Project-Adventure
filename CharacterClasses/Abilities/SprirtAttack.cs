using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class SpiritAttack : Ability
    {
        public SpiritAttack()
        {
            Name = "Spirit Attack";
            FlavorText = "Release part of yourself to attack an opponent.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 6;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
