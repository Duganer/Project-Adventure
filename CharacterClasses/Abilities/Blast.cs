using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Blast : Ability
    {
        public Blast()
        {
            Name = "Blast";
            FlavorText = "Hit them with your best spell. It's a simple one but still a spell.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 2;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 2;
        }
    }
}
